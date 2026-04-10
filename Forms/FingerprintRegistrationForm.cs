using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAMS.Forms
{
    public partial class FingerprintRegistrationForm : Form
    {
        private byte[]? finger1;
        private byte[]? finger2;
        private byte[]? finger3;

        private int currentStep = 1;
        private int employeeId;

        string connectionString = "Server=Your_SERVER;Database=Your_DATABASE;User Id=Your_USER;Password=Your_PASSWORD;TrustServerCertificate=True;";


        public FingerprintRegistrationForm(int empId)
        {
            InitializeComponent();

            if (empId <= 0)
            {
                MessageBox.Show("Invalid Employee ID.");
                this.Close();
                return;
            }

            employeeId = empId;
        }

        private void FingerprintRegistrationForm_Load(object sender, EventArgs e)
        {
            UpdateStepLabel();
        }

        private byte[] CaptureFingerprint()
        {
            return Guid.NewGuid().ToByteArray();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            byte[] captured = CaptureFingerprint();

            if (captured == null)
            {
                MessageBox.Show("Failed to capture fingerprint.");
                return;
            }

            if (currentStep == 1)
            {
                finger1 = captured;
                MessageBox.Show("✔ Finger 1 saved.");
                currentStep++;
            }
            else if (currentStep == 2)
            {
                finger2 = captured;
                MessageBox.Show("✔ Finger 2 saved.");
                currentStep++;
            }
            else if (currentStep == 3)
            {
                finger3 = captured;

                SaveFingerprints();

                MessageBox.Show("✔ All 3 fingerprints registered successfully!");

                ResetForm();
                this.Close();
                return;
            }

            UpdateStepLabel();
        }

        private void SaveFingerprints()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    UPDATE Users
                    SET Fingerprint1 = @F1,
                        Fingerprint2 = @F2,
                        Fingerprint3 = @F3
                    WHERE EmployeeID = @EmployeeID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@F1", (object?)finger1 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@F2", (object?)finger2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@F3", (object?)finger3 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving fingerprints: " + ex.Message);
            }
        }

        private void UpdateStepLabel()
        {
            if (lblStep != null)
            {
                lblStep.Text = $"Step {currentStep} of 3: Scan Finger {currentStep}";
            }
        }

        private void ResetForm()
        {
            finger1 = null;
            finger2 = null;
            finger3 = null;
            currentStep = 1;
        }
    }
}