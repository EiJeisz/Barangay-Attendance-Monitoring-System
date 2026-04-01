using System;
using System.Windows.Forms;
using BAMS.UserControls;

namespace BAMS.Forms
{
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardUC());
            ApplyAdminAccess();
        }

        private void LoadDashboard()
        {
            labelHeader.Text = "Dashboard";
            panelTable.Visible = true;
            panelCards.Visible = true;
        }

        private void ApplyAdminAccess()
        {
            bool isAdmin = true;

            btnUserlist.Enabled = isAdmin;
            btnUploadData.Enabled = isAdmin;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardUC());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Attendance";

            panelTable.Visible = false;
            panelCards.Visible = false;

            LoadUserControl(new AttendanceUC());
        }

        private void btnUserlist_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "User Management";

            panelTable.Visible = false;
            panelCards.Visible = false;

            LoadUserControl(new UserListUC());
        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "Upload Biometric Logs";

            panelTable.Visible = false;
            panelCards.Visible = false;

            LoadUserControl(new UploadDataUC());
        }

        private void btnFpgrowth_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "FP-Growth Analysis";

            panelTable.Visible = false;
            panelCards.Visible = false;

            LoadUserControl(new FpGrowthUC());
        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTotalList_Click(object sender, EventArgs e) { }
        private void lblTotalStaff_Click(object sender, EventArgs e) { }
        private void lblTotalOfficial_Click(object sender, EventArgs e) { }
        private void labelHeader_Click(object sender, EventArgs e) { }
    }
}