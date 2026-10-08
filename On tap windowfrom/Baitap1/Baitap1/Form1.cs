using System;
using System.Globalization;
using System.Windows.Forms;

namespace Baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá và Số lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var unitPrice))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var quantity))
            {
                MessageBox.Show("Số lượng phải là số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            decimal discount = 0m;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                if (!decimal.TryParse(txtDiscount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out discount))
                {
                    MessageBox.Show("Mã giảm giá phải là số (phần trăm).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
                if (discount < 0 || discount > 100)
                {
                    MessageBox.Show("Phần trăm giảm giá phải trong khoảng 0 - 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
            }

            var subtotal = unitPrice * quantity;
            var total = subtotal * (100 - discount) / 100;

            lblTotalValue.Text = total.ToString("N2", CultureInfo.CurrentCulture);
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            lblTotalValue.Text = "0.00";
            txtUnitPrice.Focus();
        }
    }
}
