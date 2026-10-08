using System;
using System.Text;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoLow.Checked = true;
            cboType.SelectedIndex = 0;
        }

        private void btnLoadImage_Click(object? sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var path = openFileDialog1.FileName;
                    picError.Image?.Dispose();
                    picError.Image = System.Drawing.Image.FromFile(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSend_Click(object? sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("---- Tóm tắt yêu cầu ----");
            sb.AppendLine("Mã phiếu: " + txtTicketId.Text);
            sb.AppendLine("Người yêu cầu: " + txtRequestor.Text);
            sb.AppendLine("Ngày ghi nhận: " + dtpDate.Value.ToShortDateString());

            string priority = rdoLow.Checked ? "Thấp" : rdoMedium.Checked ? "Trung bình" : rdoHigh.Checked ? "Khẩn cấp" : "";
            sb.AppendLine("Mức độ ưu tiên: " + priority);

            var type = cboType.SelectedItem?.ToString() ?? string.Empty;
            sb.AppendLine("Loại sự cố: " + type);

            var devices = new System.Collections.Generic.List<string>();
            if (chkDesktop.Checked) devices.Add("Máy tính bàn");
            if (chkLaptop.Checked) devices.Add("Laptop");
            if (chkPrinter.Checked) devices.Add("Máy in");
            if (chkPhone.Checked) devices.Add("Điện thoại");
            sb.AppendLine("Thiết bị ảnh hưởng: " + (devices.Count > 0 ? string.Join(", ", devices) : "Không có"));

            sb.AppendLine("Ảnh lỗi: " + (picError.Image != null ? "Đã chọn" : "Chưa có"));

            MessageBox.Show(sb.ToString(), "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtTicketId.Text = string.Empty;
            txtRequestor.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            rdoLow.Checked = true;
            cboType.SelectedIndex = 0;
            chkDesktop.Checked = chkLaptop.Checked = chkPrinter.Checked = chkPhone.Checked = false;
            if (picError.Image != null)
            {
                picError.Image.Dispose();
                picError.Image = null;
            }
        }
    }
}
