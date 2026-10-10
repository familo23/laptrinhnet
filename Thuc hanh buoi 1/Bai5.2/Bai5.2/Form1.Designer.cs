namespace Bai5._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailableServices;
        private Label lblSelectedServices;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private GroupBox grpBilling;
        private Label lblSubtotalCaption;
        private Label lblDiscountCaption;
        private Label lblPaymentCaption;
        private Label lblSubtotal;
        private Label lblPayment;
        private NumericUpDown nudDiscount;

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
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailableServices = new Label();
            lblSelectedServices = new Label();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            grpBilling = new GroupBox();
            lblSubtotalCaption = new Label();
            lblDiscountCaption = new Label();
            lblPaymentCaption = new Label();
            lblSubtotal = new Label();
            lblPayment = new Label();
            nudDiscount = new NumericUpDown();
            grpBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(30, 28);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(145, 24);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 28);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblAvailableServices
            // 
            lblAvailableServices.AutoSize = true;
            lblAvailableServices.Location = new Point(30, 78);
            lblAvailableServices.Name = "lblAvailableServices";
            lblAvailableServices.Size = new Size(110, 20);
            lblAvailableServices.TabIndex = 2;
            lblAvailableServices.Text = "Dịch vụ hiện có";
            // 
            // lblSelectedServices
            // 
            lblSelectedServices.AutoSize = true;
            lblSelectedServices.Location = new Point(475, 78);
            lblSelectedServices.Name = "lblSelectedServices";
            lblSelectedServices.Size = new Size(115, 20);
            lblSelectedServices.TabIndex = 3;
            lblSelectedServices.Text = "Dịch vụ đã chọn";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(30, 108);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(330, 164);
            lstAvailableServices.TabIndex = 4;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(475, 108);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(330, 164);
            lstSelectedServices.TabIndex = 5;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(380, 125);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(70, 38);
            btnSelect.TabIndex = 6;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(380, 175);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(70, 38);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(380, 225);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(70, 38);
            btnClearAll.TabIndex = 8;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // grpBilling
            // 
            grpBilling.Controls.Add(lblSubtotalCaption);
            grpBilling.Controls.Add(lblDiscountCaption);
            grpBilling.Controls.Add(lblPaymentCaption);
            grpBilling.Controls.Add(lblSubtotal);
            grpBilling.Controls.Add(lblPayment);
            grpBilling.Controls.Add(nudDiscount);
            grpBilling.Location = new Point(30, 320);
            grpBilling.Name = "grpBilling";
            grpBilling.Size = new Size(775, 130);
            grpBilling.TabIndex = 9;
            grpBilling.TabStop = false;
            grpBilling.Text = "Tính tiền";
            // 
            // lblSubtotalCaption
            // 
            lblSubtotalCaption.AutoSize = true;
            lblSubtotalCaption.Location = new Point(20, 32);
            lblSubtotalCaption.Name = "lblSubtotalCaption";
            lblSubtotalCaption.Size = new Size(149, 20);
            lblSubtotalCaption.TabIndex = 0;
            lblSubtotalCaption.Text = "Tổng tiền chưa giảm:";
            // 
            // lblDiscountCaption
            // 
            lblDiscountCaption.AutoSize = true;
            lblDiscountCaption.Location = new Point(20, 70);
            lblDiscountCaption.Name = "lblDiscountCaption";
            lblDiscountCaption.Size = new Size(140, 20);
            lblDiscountCaption.TabIndex = 1;
            lblDiscountCaption.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // lblPaymentCaption
            // 
            lblPaymentCaption.AutoSize = true;
            lblPaymentCaption.Location = new Point(420, 50);
            lblPaymentCaption.Name = "lblPaymentCaption";
            lblPaymentCaption.Size = new Size(156, 20);
            lblPaymentCaption.TabIndex = 2;
            lblPaymentCaption.Text = "Thành tiền thanh toán:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtotal.Location = new Point(190, 32);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(55, 20);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "0 VNĐ";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPayment.ForeColor = Color.Crimson;
            lblPayment.Location = new Point(590, 47);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(70, 25);
            lblPayment.TabIndex = 4;
            lblPayment.Text = "0 VNĐ";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(190, 66);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(90, 27);
            nudDiscount.TabIndex = 5;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 490);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailableServices);
            Controls.Add(lblSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(lstSelectedServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(grpBilling);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng tính tiền dịch vụ và chiết khấu đơn hàng";
            grpBilling.ResumeLayout(false);
            grpBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
