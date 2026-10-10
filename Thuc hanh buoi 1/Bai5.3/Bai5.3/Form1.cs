namespace Bai5._3
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private readonly BindingSource productBindingSource = new();
        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();
            productBindingSource.DataSource = products;
            dgvProducts.DataSource = productBindingSource;

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!TryReadProduct(out Product? product))
            {
                return;
            }

            if (products.Any(item => item.ProductId.Equals(product.ProductId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            products.Add(product);
            RefreshProducts();
            ClearInputs();
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryReadProduct(out Product? product))
            {
                return;
            }

            bool duplicateId = products.Any(item => !ReferenceEquals(item, selectedProduct) &&
                item.ProductId.Equals(product.ProductId, StringComparison.OrdinalIgnoreCase));
            if (duplicateId)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            selectedProduct.ProductId = product.ProductId;
            selectedProduct.ProductName = product.ProductName;
            selectedProduct.UnitPrice = product.UnitPrice;
            selectedProduct.Quantity = product.Quantity;
            selectedProduct.Category = product.Category;
            RefreshProducts();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm '{selectedProduct.ProductName}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            products.Remove(selectedProduct);
            selectedProduct = null;
            RefreshProducts();
            ClearInputs();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            IEnumerable<Product> result = string.IsNullOrWhiteSpace(keyword)
                ? products
                : products.Where(product => product.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase));

            productBindingSource.DataSource = result.ToList();
            productBindingSource.ResetBindings(false);
            selectedProduct = null;
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product product)
            {
                selectedProduct = product;
                txtProductId.Text = product.ProductId;
                txtProductName.Text = product.ProductName;
                nudUnitPrice.Value = Math.Clamp(product.UnitPrice, nudUnitPrice.Minimum, nudUnitPrice.Maximum);
                nudQuantity.Value = Math.Clamp(product.Quantity, nudQuantity.Minimum, nudQuantity.Maximum);
                txtCategory.Text = product.Category;
            }
        }

        private bool TryReadProduct(out Product product)
        {
            string productId = txtProductId.Text.Trim();
            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Mã SP và Tên SP không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                product = new Product();
                return false;
            }

            product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                UnitPrice = nudUnitPrice.Value,
                Quantity = (int)nudQuantity.Value,
                Category = txtCategory.Text.Trim()
            };
            return true;
        }

        private void RefreshProducts()
        {
            productBindingSource.DataSource = products;
            productBindingSource.ResetBindings(false);
        }

        private void ClearInputs()
        {
            selectedProduct = null;
            txtProductId.Clear();
            txtProductName.Clear();
            nudUnitPrice.Value = 0;
            nudQuantity.Value = 0;
            txtCategory.Clear();
            dgvProducts.ClearSelection();
            txtProductId.Focus();
        }
    }
}
