namespace Bai4._6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExportCsv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            grpDetails = new GroupBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblAvatar = new Label();
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.BackgroundColor = SystemColors.Window;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(760, 210);
            dgvStudents.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblStudentId);
            grpDetails.Controls.Add(txtStudentId);
            grpDetails.Controls.Add(lblFullName);
            grpDetails.Controls.Add(txtFullName);
            grpDetails.Controls.Add(lblAge);
            grpDetails.Controls.Add(txtAge);
            grpDetails.Controls.Add(lblGender);
            grpDetails.Controls.Add(cboGender);
            grpDetails.Controls.Add(lblAvatar);
            grpDetails.Controls.Add(picAvatar);
            grpDetails.Controls.Add(btnChooseAvatar);
            grpDetails.Location = new Point(12, 234);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(760, 170);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Thông tin sinh viên";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(18, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(54, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(90, 27);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(180, 27);
            txtStudentId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(289, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(360, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(180, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(18, 70);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(90, 67);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 27);
            txtAge.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(289, 70);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(360, 67);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(180, 28);
            cboGender.TabIndex = 7;
            // 
            // lblAvatar
            // 
            lblAvatar.AutoSize = true;
            lblAvatar.Location = new Point(559, 14);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(55, 20);
            lblAvatar.TabIndex = 8;
            lblAvatar.Text = "Avatar:";
            lblAvatar.Click += lblAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(589, 37);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(120, 96);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 9;
            picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(589, 139);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(120, 25);
            btnChooseAvatar.TabIndex = 10;
            btnChooseAvatar.Text = "Chọn ảnh...";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(120, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(632, 415);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(140, 30);
            btnExportCsv.TabIndex = 5;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(dgvStudents);
            Controls.Add(grpDetails);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnExportCsv);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
