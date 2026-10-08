namespace Baitap2
{
    partial class Form1
    {
  
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequestor;
        private System.Windows.Forms.TextBox txtRequestor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rdoLow;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblRequestor = new Label();
            txtRequestor = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            grpPriority = new GroupBox();
            rdoLow = new RadioButton();
            rdoMedium = new RadioButton();
            rdoHigh = new RadioButton();
            lblType = new Label();
            cboType = new ComboBox();
            lblDevices = new Label();
            chkDesktop = new CheckBox();
            chkLaptop = new CheckBox();
            chkPrinter = new CheckBox();
            chkPhone = new CheckBox();
            picError = new PictureBox();
            btnLoadImage = new Button();
            btnSend = new Button();
            btnReset = new Button();
            openFileDialog1 = new OpenFileDialog();
            grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picError).BeginInit();
            SuspendLayout();
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(20, 20);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(71, 20);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Mã phiếu";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(130, 17);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(200, 27);
            txtTicketId.TabIndex = 1;
            // 
            // lblRequestor
            // 
            lblRequestor.AutoSize = true;
            lblRequestor.Location = new Point(20, 55);
            lblRequestor.Name = "lblRequestor";
            lblRequestor.Size = new Size(105, 20);
            lblRequestor.TabIndex = 2;
            lblRequestor.Text = "Người yêu cầu";
            // 
            // txtRequestor
            // 
            txtRequestor.Location = new Point(130, 52);
            txtRequestor.Name = "txtRequestor";
            txtRequestor.Size = new Size(200, 27);
            txtRequestor.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 90);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(105, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(130, 86);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 5;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(rdoLow);
            grpPriority.Controls.Add(rdoMedium);
            grpPriority.Controls.Add(rdoHigh);
            grpPriority.Location = new Point(357, 17);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(237, 103);
            grpPriority.TabIndex = 6;
            grpPriority.TabStop = false;
            grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rdoLow
            // 
            rdoLow.AutoSize = true;
            rdoLow.Location = new Point(15, 25);
            rdoLow.Name = "rdoLow";
            rdoLow.Size = new Size(63, 24);
            rdoLow.TabIndex = 0;
            rdoLow.TabStop = true;
            rdoLow.Text = "Thấp";
            rdoLow.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(15, 45);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(100, 24);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Trung bình";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoHigh
            // 
            rdoHigh.AutoSize = true;
            rdoHigh.Location = new Point(15, 65);
            rdoHigh.Name = "rdoHigh";
            rdoHigh.Size = new Size(91, 24);
            rdoHigh.TabIndex = 2;
            rdoHigh.TabStop = true;
            rdoHigh.Text = "Khẩn cấp";
            rdoHigh.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 130);
            lblType.Name = "lblType";
            lblType.Size = new Size(76, 20);
            lblType.TabIndex = 7;
            lblType.Text = "Loại sự cố";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboType.Location = new Point(130, 127);
            cboType.Name = "cboType";
            cboType.Size = new Size(200, 28);
            cboType.TabIndex = 8;
            // 
            // lblDevices
            // 
            lblDevices.AutoSize = true;
            lblDevices.Location = new Point(20, 165);
            lblDevices.Name = "lblDevices";
            lblDevices.Size = new Size(134, 20);
            lblDevices.TabIndex = 9;
            lblDevices.Text = "Thiết bị ảnh hưởng";
            // 
            // chkDesktop
            // 
            chkDesktop.AutoSize = true;
            chkDesktop.Location = new Point(160, 165);
            chkDesktop.Name = "chkDesktop";
            chkDesktop.Size = new Size(117, 24);
            chkDesktop.TabIndex = 10;
            chkDesktop.Text = "Máy tính bàn";
            chkDesktop.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(294, 210);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 11;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            chkPrinter.AutoSize = true;
            chkPrinter.Location = new Point(160, 210);
            chkPrinter.Name = "chkPrinter";
            chkPrinter.Size = new Size(75, 24);
            chkPrinter.TabIndex = 12;
            chkPrinter.Text = "Máy in";
            chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.Location = new Point(294, 165);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(100, 24);
            chkPhone.TabIndex = 13;
            chkPhone.Text = "Điện thoại";
            chkPhone.UseVisualStyleBackColor = true;
            // 
            // picError
            // 
            picError.BorderStyle = BorderStyle.FixedSingle;
            picError.Location = new Point(436, 127);
            picError.Name = "picError";
            picError.Size = new Size(270, 172);
            picError.SizeMode = PictureBoxSizeMode.StretchImage;
            picError.TabIndex = 14;
            picError.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(464, 317);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(210, 34);
            btnLoadImage.TabIndex = 15;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(130, 276);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(117, 40);
            btnSend.TabIndex = 16;
            btnSend.Text = "Gửi yêu cầu";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(272, 276);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 40);
            btnReset.TabIndex = 17;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 363);
            Controls.Add(btnReset);
            Controls.Add(btnSend);
            Controls.Add(btnLoadImage);
            Controls.Add(picError);
            Controls.Add(chkPhone);
            Controls.Add(chkPrinter);
            Controls.Add(chkLaptop);
            Controls.Add(chkDesktop);
            Controls.Add(lblDevices);
            Controls.Add(cboType);
            Controls.Add(lblType);
            Controls.Add(grpPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequestor);
            Controls.Add(lblRequestor);
            Controls.Add(txtTicketId);
            Controls.Add(lblTicketId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Tiếp nhận & Phân loại sự cố IT";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
