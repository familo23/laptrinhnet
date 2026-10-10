namespace Bai5._2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<Service>> servicesByCategory = new()
        {
            ["Khám bệnh"] =
            [
                new("Khám tổng quát", 200000),
                new("Khám chuyên khoa", 300000),
                new("Khám sức khỏe định kỳ", 250000)
            ],
            ["Xét nghiệm"] =
            [
                new("Xét nghiệm máu", 150000),
                new("Xét nghiệm nước tiểu", 100000),
                new("Xét nghiệm đường huyết", 120000)
            ],
            ["Chụp X-Quang"] =
            [
                new("Chụp X-Quang ngực", 180000),
                new("Chụp X-Quang xương", 200000),
                new("Chụp X-Quang cột sống", 250000)
            ],
            ["Vắc-xin"] =
            [
                new("Vắc-xin cúm", 250000),
                new("Vắc-xin viêm gan B", 300000),
                new("Vắc-xin uốn ván", 180000)
            ]
        };

        public Form1()
        {
            InitializeComponent();
            cboCategory.Items.AddRange(servicesByCategory.Keys.ToArray());
            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            if (cboCategory.SelectedItem is string category && servicesByCategory.TryGetValue(category, out var services))
            {
                foreach (var service in services)
                {
                    if (!lstSelectedServices.Items.Contains(service))
                    {
                        lstAvailableServices.Items.Add(service);
                    }
                }
            }
        }

        private void lstAvailableServices_DoubleClick(object? sender, EventArgs e)
        {
            SelectService();
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            SelectService();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem is Service service)
            {
                lstSelectedServices.Items.Remove(service);
                RefreshAvailableServices();
                UpdateTotals();
            }
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            RefreshAvailableServices();
            UpdateTotals();
        }

        private void SelectService()
        {
            if (lstAvailableServices.SelectedItem is not Service service)
            {
                return;
            }

            lstSelectedServices.Items.Add(service);
            lstAvailableServices.Items.Remove(service);
            UpdateTotals();
        }

        private void RefreshAvailableServices()
        {
            if (cboCategory.SelectedItem is not string category || !servicesByCategory.TryGetValue(category, out var services))
            {
                return;
            }

            lstAvailableServices.Items.Clear();
            foreach (var service in services)
            {
                if (!lstSelectedServices.Items.Contains(service))
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void nudDiscount_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal subtotal = lstSelectedServices.Items
                .OfType<Service>()
                .Sum(service => service.Price);
            decimal discount = subtotal * nudDiscount.Value / 100;
            decimal payment = subtotal - discount;

            lblSubtotal.Text = $"{subtotal:N0} VNĐ";
            lblPayment.Text = $"{payment:N0} VNĐ";
        }

        private sealed record Service(string Name, decimal Price)
        {
            public override string ToString() => $"{Name} - {Price:N0} VNĐ";
        }
    }
}
