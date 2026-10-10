namespace Bai5._4
{
    public partial class Form1 : Form
    {
        private readonly List<Employee> employees = new();

        public Form1()
        {
            InitializeComponent();
            CreateIcons();
            CreateSampleData();
            BuildDepartmentTree();
            cboViewMode.SelectedIndex = 0;
            tvDepartments.SelectedNode = tvDepartments.Nodes[0];
        }

        private void CreateIcons()
        {
            treeImageList.Images.Add(CreateIcon(Color.SteelBlue, 16));
            treeImageList.Images.Add(CreateIcon(Color.DarkOrange, 16));
            employeeImageList.Images.Add(CreateIcon(Color.SeaGreen, 32));
        }

        private static Bitmap CreateIcon(Color color, int size)
        {
            Bitmap bitmap = new(size, size);
            using Graphics graphics = Graphics.FromImage(bitmap);
            using SolidBrush brush = new(color);
            graphics.FillEllipse(brush, 1, 1, size - 2, size - 2);
            return bitmap;
        }

        private void CreateSampleData()
        {
            employees.AddRange(new[]
            {
                new Employee("NV001", "Nguyễn Minh Anh", "Trưởng phòng", "Kinh doanh", "Bán hàng", new DateTime(2019, 3, 12)),
                new Employee("NV002", "Trần Quốc Bảo", "Nhân viên", "Kinh doanh", "Bán hàng", new DateTime(2021, 7, 1)),
                new Employee("NV003", "Lê Thu Hà", "Nhân viên", "Kinh doanh", "Chăm sóc khách hàng", new DateTime(2022, 2, 15)),
                new Employee("NV004", "Phạm Hoàng Nam", "Trưởng phòng", "Kỹ thuật", "Phát triển phần mềm", new DateTime(2018, 10, 8)),
                new Employee("NV005", "Vũ Ngọc Linh", "Lập trình viên", "Kỹ thuật", "Phát triển phần mềm", new DateTime(2020, 5, 20)),
                new Employee("NV006", "Đỗ Thanh Tùng", "Lập trình viên", "Kỹ thuật", "Kiểm thử", new DateTime(2021, 11, 3)),
                new Employee("NV007", "Hoàng Mai Phương", "Trưởng phòng", "Nhân sự", "Tuyển dụng", new DateTime(2017, 1, 9)),
                new Employee("NV008", "Ngô Đức Long", "Chuyên viên", "Nhân sự", "Tuyển dụng", new DateTime(2023, 4, 17))
            });
        }

        private void BuildDepartmentTree()
        {
            TreeNode company = new("Công ty ABC") { ImageIndex = 0, SelectedImageIndex = 1 };
            AddDepartment(company, "Kinh doanh", "Bán hàng", "Chăm sóc khách hàng");
            AddDepartment(company, "Kỹ thuật", "Phát triển phần mềm", "Kiểm thử");
            AddDepartment(company, "Nhân sự", "Tuyển dụng");
            tvDepartments.Nodes.Add(company);
            company.Expand();
        }

        private static void AddDepartment(TreeNode company, string department, params string[] groups)
        {
            TreeNode departmentNode = new(department) { ImageIndex = 0, SelectedImageIndex = 1 };
            foreach (string group in groups)
                departmentNode.Nodes.Add(new TreeNode(group) { ImageIndex = 0, SelectedImageIndex = 1 });
            company.Nodes.Add(departmentNode);
            departmentNode.Expand();
        }

        private void tvDepartments_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.FullPath;
            string? department = e.Node.Level >= 1 ? e.Node.Parent?.Text : null;
            string? group = e.Node.Level >= 2 ? e.Node.Text : null;
            IEnumerable<Employee> matching = employees.Where(employee =>
                e.Node.Level == 0 || (group != null && employee.Group == group) ||
                (department != null && e.Node.Level == 1 && employee.Department == e.Node.Text));

            lblViewMode.Text = $"Chế độ xem ({selectedPath}):";
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();
            foreach (Employee employee in matching)
            {
                ListViewItem item = new(employee.Id, 0);
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.StartDate.ToString("dd/MM/yyyy"));
                lsvEmployees.Items.Add(item);
            }
            lsvEmployees.EndUpdate();
        }

        private void cboViewMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem is string mode && Enum.TryParse(mode, out View view))
                lsvEmployees.View = view;
        }

        private sealed record Employee(string Id, string Name, string Position, string Department, string Group, DateTime StartDate);
    }
}
