namespace Bai5._3
{
    partial class Form1
    {
        private GroupBox grpProductInfo;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private NumericUpDown nudUnitPrice;
        private NumericUpDown nudQuantity;
        private TextBox txtCategory;
        private GroupBox grpFunctions;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colCategory;

        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            grpProductInfo = new GroupBox();
            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            nudUnitPrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            txtCategory = new TextBox();
            grpFunctions = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpProductInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            SuspendLayout();

            grpProductInfo.Text = "Thông tin sản phẩm";
            grpProductInfo.Location = new Point(12, 12);
            grpProductInfo.Size = new Size(776, 145);
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(20, 31);
            lblProductId.Text = "Mã SP:";
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(20, 67);
            lblProductName.Text = "Tên SP:";
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(385, 31);
            lblUnitPrice.Text = "Đơn giá:";
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(385, 67);
            lblQuantity.Text = "Số lượng:";
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 103);
            lblCategory.Text = "Danh mục:";
            txtProductId.Location = new Point(95, 27);
            txtProductId.Size = new Size(240, 23);
            txtProductName.Location = new Point(95, 63);
            txtProductName.Size = new Size(240, 23);
            nudUnitPrice.DecimalPlaces = 2;
            nudUnitPrice.Maximum = 1000000000;
            nudUnitPrice.ThousandsSeparator = true;
            nudUnitPrice.Location = new Point(465, 27);
            nudUnitPrice.Size = new Size(240, 23);
            nudQuantity.Maximum = 1000000;
            nudQuantity.Location = new Point(465, 63);
            nudQuantity.Size = new Size(240, 23);
            txtCategory.Location = new Point(95, 99);
            txtCategory.Size = new Size(240, 23);
            grpProductInfo.Controls.AddRange(new Control[] { lblProductId, lblProductName, lblUnitPrice, lblQuantity, lblCategory, txtProductId, txtProductName, nudUnitPrice, nudQuantity, txtCategory });

            grpFunctions.Text = "Chức năng";
            grpFunctions.Location = new Point(12, 163);
            grpFunctions.Size = new Size(776, 75);
            btnAdd.Location = new Point(20, 28);
            btnAdd.Size = new Size(90, 30);
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnEdit.Location = new Point(120, 28);
            btnEdit.Size = new Size(90, 30);
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnDelete.Location = new Point(220, 28);
            btnDelete.Size = new Size(90, 30);
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(365, 35);
            lblSearch.Text = "Tìm tên SP:";
            txtSearch.Location = new Point(445, 31);
            txtSearch.Size = new Size(210, 23);
            btnSearch.Location = new Point(665, 28);
            btnSearch.Size = new Size(90, 30);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            grpFunctions.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, lblSearch, txtSearch, btnSearch });

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 250);
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(776, 188);
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "Mã SP";
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Tên SP";
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.DefaultCellStyle.Format = "N2";
            colUnitPrice.HeaderText = "Đơn giá";
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số lượng";
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Danh mục";
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colUnitPrice, colQuantity, colCategory });

            ClientSize = new Size(800, 450);
            Controls.Add(grpProductInfo);
            Controls.Add(grpFunctions);
            Controls.Add(dgvProducts);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách sản phẩm";
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
