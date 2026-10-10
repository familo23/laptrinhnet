namespace Bai5._1
{
    partial class Form1
    {
        private GroupBox grpPersonalInfo;
        private GroupBox grpAdditionalInfo;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblBirthDate;
        private Label lblGender;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private DateTimePicker dtpBirthDate;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkTerms;
        private Button btnRegister;
        private Button btnReset;
        private ErrorProvider epCheck;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpPersonalInfo = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            grpAdditionalInfo = new GroupBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpPersonalInfo.SuspendLayout();
            grpAdditionalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(lblUsername);
            grpPersonalInfo.Controls.Add(txtUsername);
            grpPersonalInfo.Controls.Add(lblPassword);
            grpPersonalInfo.Controls.Add(txtPassword);
            grpPersonalInfo.Controls.Add(lblConfirmPassword);
            grpPersonalInfo.Controls.Add(txtConfirmPassword);
            grpPersonalInfo.Location = new Point(30, 25);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(440, 190);
            grpPersonalInfo.TabIndex = 0;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Thông tin tài khoản";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(25, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(25, 125);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(160, 122);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(240, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // grpAdditionalInfo
            // 
            grpAdditionalInfo.Controls.Add(lblBirthDate);
            grpAdditionalInfo.Controls.Add(dtpBirthDate);
            grpAdditionalInfo.Controls.Add(lblGender);
            grpAdditionalInfo.Controls.Add(rdoMale);
            grpAdditionalInfo.Controls.Add(rdoFemale);
            grpAdditionalInfo.Location = new Point(30, 230);
            grpAdditionalInfo.Name = "grpAdditionalInfo";
            grpAdditionalInfo.Size = new Size(440, 145);
            grpAdditionalInfo.TabIndex = 1;
            grpAdditionalInfo.TabStop = false;
            grpAdditionalInfo.Text = "Thông tin bổ sung";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(25, 35);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(77, 20);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(160, 32);
            dtpBirthDate.MaxDate = new DateTime(2026, 10, 10, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 27);
            dtpBirthDate.TabIndex = 1;
            dtpBirthDate.Value = new DateTime(2008, 10, 10, 0, 0, 0, 0);
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(25, 78);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(160, 76);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 3;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(240, 76);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 4;
            rdoFemale.Text = "Nữ";
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(30, 397);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(253, 24);
            chkTerms.TabIndex = 5;
            chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(227, 439);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 35);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(388, 439);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 35);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 508);
            Controls.Add(grpPersonalInfo);
            Controls.Add(grpAdditionalInfo);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            Controls.Add(chkTerms);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpAdditionalInfo.ResumeLayout(false);
            grpAdditionalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
