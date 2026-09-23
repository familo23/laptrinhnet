namespace baitap4._2
{
    partial class cboCourse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lblKhoahoc = new Label();
            label2 = new Label();
            lblDienthoai = new Label();
            lblHoten = new Label();
            lblNgaysinh = new Label();
            lblDangKyHocVien = new Label();
            lblGioiTinh = new Label();
            textBox1 = new TextBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            dtpGio = new DateTimePicker();
            comboBox1 = new ComboBox();
            mtxtPhone = new MaskedTextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblKhoahoc
            // 
            lblKhoahoc.AutoSize = true;
            lblKhoahoc.Location = new Point(192, 277);
            lblKhoahoc.Name = "lblKhoahoc";
            lblKhoahoc.Size = new Size(78, 20);
            lblKhoahoc.TabIndex = 0;
            lblKhoahoc.Text = "Khoá hoc: ";
            lblKhoahoc.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 113);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // lblDienthoai
            // 
            lblDienthoai.AutoSize = true;
            lblDienthoai.Location = new Point(192, 218);
            lblDienthoai.Name = "lblDienthoai";
            lblDienthoai.Size = new Size(81, 20);
            lblDienthoai.TabIndex = 0;
            lblDienthoai.Text = "Điện thoại:";
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(192, 66);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(59, 20);
            lblHoten.TabIndex = 0;
            lblHoten.Text = "Họ Tên:";
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Location = new Point(192, 168);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new Size(77, 20);
            lblNgaysinh.TabIndex = 0;
            lblNgaysinh.Text = "Ngày sinh:";
            // 
            // lblDangKyHocVien
            // 
            lblDangKyHocVien.AutoSize = true;
            lblDangKyHocVien.Location = new Point(319, 19);
            lblDangKyHocVien.Name = "lblDangKyHocVien";
            lblDangKyHocVien.Size = new Size(147, 20);
            lblDangKyHocVien.TabIndex = 0;
            lblDangKyHocVien.Text = "ĐĂNG KÝ HỌC VIÊN ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(192, 117);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 1;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 2;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(268, 115);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 3;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(360, 115);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 3;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // dtpGio
            // 
            dtpGio.Location = new Point(284, 163);
            dtpGio.Name = "dtpGio";
            dtpGio.Size = new Size(250, 27);
            dtpGio.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(279, 215);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(255, 27);
            mtxtPhone.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(336, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cboCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(mtxtPhone);
            Controls.Add(comboBox1);
            Controls.Add(dtpGio);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(textBox1);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblDangKyHocVien);
            Controls.Add(lblHoten);
            Controls.Add(lblNgaysinh);
            Controls.Add(lblDienthoai);
            Controls.Add(label2);
            Controls.Add(lblKhoahoc);
            Name = "cboCourse";
            Text = "Khoahoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKhoahoc;
        private Label label2;
        private Label lblDienthoai;
        private Label lblHoten;
        private Label lblNgaysinh;
        private Label lblDangKyHocVien;
        private Label lblGioiTinh;
        private TextBox textBox1;
        private RadioButton radNam;
        private RadioButton radNu;
        private DateTimePicker dtpGio;
        private ComboBox comboBox1;
        private MaskedTextBox mtxtPhone;
        private Button btnRegister;
    }
}
