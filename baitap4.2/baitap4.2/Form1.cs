using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace baitap4._2
{
    public partial class cboCourse : Form
    {
        public cboCourse()
        {
            InitializeComponent();

            // Nạp danh sách khóa học
            List<Course> courses = new List<Course>()
            {
                new Course { Id = "C01", Name = "Lập trình C#" },
                new Course { Id = "C02", Name = "Lập trình Java" },
                new Course { Id = "C03", Name = "Lập trình Python" },
                new Course { Id = "C04", Name = "Lập trình Web" }
            };

            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            // Mask số điện thoại
            mtxtPhone.Mask = "(000) 000-0000";

            // Ngày sinh
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void mtxtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;

            string gioiTinh = "";

            if (radioButton1.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (radioButton2.Checked)
            {
                gioiTinh = "Nữ";
            }

            string ngaySinh = dtpBirthDate.Value.ToString("dd/MM/yyyy");

            string soDienThoai = mtxtPhone.Text;

            string khoaHoc = comboBox1.Text;

            string ngonNgu = "";

            if (checkBox1.Checked)
            {
                ngonNgu += "C#, ";
            }

            if (checkBox2.Checked)
            {
                ngonNgu += "Java, ";
            }

            if (checkBox3.Checked)
            {
                ngonNgu += "Python, ";
            }

            if (ngonNgu == "")
            {
                ngonNgu = "Không chọn";
            }
            else
            {
                ngonNgu = ngonNgu.Substring(0, ngonNgu.Length - 2);
            }

            string thongTin =
                "THÔNG TIN ĐĂNG KÝ\n" +
                "--------------------------\n" +
                "Họ tên: " + hoTen + "\n" +
                "Giới tính: " + gioiTinh + "\n" +
                "Ngày sinh: " + ngaySinh + "\n" +
                "Điện thoại: " + soDienThoai + "\n" +
                "Khóa học: " + khoaHoc + "\n" +
                "Ngôn ngữ: " + ngonNgu;

            MessageBox.Show(
                thongTin,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}