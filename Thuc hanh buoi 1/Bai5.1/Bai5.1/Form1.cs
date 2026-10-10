namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            epCheck.Clear();
            var isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống.");
                isValid = false;
            }

            if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu nhập lại không khớp.");
                isValid = false;
            }

            if (GetAge(dtpBirthDate.Value.Date, DateTime.Today) < 18)
            {
                epCheck.SetError(dtpBirthDate, "Người đăng ký phải đủ 18 tuổi.");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với điều khoản dịch vụ.");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
            rdoMale.Checked = true;
            chkTerms.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }

        private static int GetAge(DateTime birthDate, DateTime today)
        {
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
