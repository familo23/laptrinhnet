namespace Baitap1
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalValue;

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
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            lblTotalLabel = new Label();
            lblTotalValue = new Label();
            SuspendLayout();
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(24, 24);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(116, 20);
            lblUnitPrice.TabIndex = 0;
            lblUnitPrice.Text = "Đơn giá dịch vụ:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(160, 20);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(160, 27);
            txtUnitPrice.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 64);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(114, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Số lượng khách:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(160, 60);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(160, 27);
            txtQuantity.TabIndex = 1;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(24, 104);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(122, 20);
            lblDiscount.TabIndex = 0;
            lblDiscount.Text = "Mã giảm giá (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(160, 100);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(160, 27);
            txtDiscount.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(200, 150);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 30);
            btnReset.TabIndex = 4;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Location = new Point(24, 210);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(121, 20);
            lblTotalLabel.TabIndex = 0;
            lblTotalLabel.Text = "Tổng thanh toán:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalValue.Location = new Point(151, 210);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(40, 20);
            lblTotalValue.TabIndex = 0;
            lblTotalValue.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(lblTotalLabel);
            Controls.Add(lblTotalValue);
            Name = "Form1";
            Text = "Máy tính cước dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
