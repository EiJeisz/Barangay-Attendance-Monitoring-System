namespace BAMS.Forms
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            txtName = new TextBox();
            cmbGender = new ComboBox();
            cmbPosition = new ComboBox();
            btnCancel2 = new Button();
            label1 = new Label();
            txtEmployeeID = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(343, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(138, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 29);
            txtName.TabIndex = 0;
            txtName.Text = "Name";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(138, 193);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(293, 29);
            cmbGender.TabIndex = 1;
            cmbGender.Text = "Gender";
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(138, 233);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(293, 29);
            cmbPosition.TabIndex = 2;
            cmbPosition.Text = "Position";
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.Crimson;
            btnCancel2.FlatStyle = FlatStyle.Popup;
            btnCancel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel2.Location = new Point(138, 286);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(88, 34);
            btnCancel2.TabIndex = 6;
            btnCancel2.Text = "Cancel";
            btnCancel2.UseVisualStyleBackColor = false;
            btnCancel2.Click += btnCancel2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 63);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 7;
            label1.Text = "ADD USER";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 12F);
            txtEmployeeID.Location = new Point(138, 118);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(293, 29);
            txtEmployeeID.TabIndex = 8;
            txtEmployeeID.Text = "Employee ID";
            txtEmployeeID.TextChanged += txtEmployeeID_TextChanged;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(568, 417);
            Controls.Add(txtEmployeeID);
            Controls.Add(label1);
            Controls.Add(btnCancel2);
            Controls.Add(btnSave);
            Controls.Add(cmbPosition);
            Controls.Add(cmbGender);
            Controls.Add(txtName);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtName;
        private ComboBox cmbGender;
        private ComboBox cmbPosition;
        private Button btnCancel2;
        private Label label1;
        private TextBox txtEmployeeID;
    }
}