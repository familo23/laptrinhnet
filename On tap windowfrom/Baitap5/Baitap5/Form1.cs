using System.Globalization;

namespace Baitap5
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo VietnameseCulture = CultureInfo.GetCultureInfo("vi-VN");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            clockTimer.Start();
            clockTimer_Tick(sender, EventArgs.Empty);
            UpdateOrderSummary();
            orderItemsDataGridView.Focus();
        }

        private void clockTimer_Tick(object? sender, EventArgs e)
        {
            clockStatusLabel.Text = $"Thời gian: {DateTime.Now:HH:mm:ss dd/MM/yyyy}";
        }

        private void orderItemsDataGridView_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateLineAmount(e.RowIndex);
                UpdateOrderSummary();
            }
        }

        private void orderItemsDataGridView_RowsChanged(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateOrderSummary();
        }

        private void orderItemsDataGridView_RowsChanged(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateOrderSummary();
        }

        private void orderItemsDataGridView_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= orderItemsDataGridView.Rows.Count - 1)
            {
                return;
            }

            DataGridViewColumn column = orderItemsDataGridView.Columns[e.ColumnIndex];
            string? error = null;
            if (column == quantityColumn || column == weightColumn)
            {
                if (!TryGetPositiveDecimal(e.FormattedValue?.ToString(), out _))
                {
                    error = column == quantityColumn
                        ? "Số lượng phải lớn hơn 0."
                        : "Trọng lượng phải lớn hơn 0.";
                }
            }

            orderItemsDataGridView.Rows[e.RowIndex].ErrorText = error ?? string.Empty;
            inputErrorProvider.SetError(orderItemsDataGridView, error ?? string.Empty);
            UpdateLineAmount(e.RowIndex);
            UpdateOrderSummary();
        }

        private void orderItemsDataGridView_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                int rowIndex = orderItemsDataGridView.Rows.Add();
                orderItemsDataGridView.CurrentCell = orderItemsDataGridView.Rows[rowIndex].Cells[itemNameColumn.Index];
                orderItemsDataGridView.BeginEdit(true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete && orderItemsDataGridView.CurrentRow is { IsNewRow: false } row)
            {
                orderItemsDataGridView.Rows.Remove(row);
                e.Handled = true;
                e.SuppressKeyPress = true;
                UpdateOrderSummary();
            }
        }

        private void UpdateLineAmount(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= orderItemsDataGridView.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = orderItemsDataGridView.Rows[rowIndex];
            if (row.IsNewRow)
            {
                return;
            }

            bool validQuantity = TryGetPositiveDecimal(row.Cells[quantityColumn.Index].Value?.ToString(), out decimal quantity);
            bool validUnitPrice = TryGetDecimal(row.Cells[unitPriceColumn.Index].Value?.ToString(), out decimal unitPrice);
            row.Cells[amountColumn.Index].Value = validQuantity && validUnitPrice
                ? (quantity * unitPrice).ToString("N0", VietnameseCulture)
                : string.Empty;
        }

        private void UpdateOrderSummary()
        {
            decimal totalQuantity = 0;
            decimal totalWeight = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in orderItemsDataGridView.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                bool validQuantity = TryGetPositiveDecimal(row.Cells[quantityColumn.Index].Value?.ToString(), out decimal quantity);
                bool validWeight = TryGetPositiveDecimal(row.Cells[weightColumn.Index].Value?.ToString(), out decimal weight);
                bool validUnitPrice = TryGetDecimal(row.Cells[unitPriceColumn.Index].Value?.ToString(), out decimal unitPrice);
                if (validQuantity)
                {
                    totalQuantity += quantity;
                }

                if (validQuantity && validWeight)
                {
                    totalWeight += quantity * weight;
                }

                if (validQuantity && validUnitPrice)
                {
                    totalAmount += quantity * unitPrice;
                }
            }

            quantityStatusLabel.Text = $"Tổng số lượng: {totalQuantity:N0}";
            weightStatusLabel.Text = $"Tổng trọng lượng: {totalWeight:N2} kg";
            totalStatusLabel.Text = $"Tổng tiền: {totalAmount:N0} ₫";
        }

        private static bool TryGetPositiveDecimal(string? value, out decimal result)
        {
            return TryGetDecimal(value, out result) && result > 0;
        }

        private static bool TryGetDecimal(string? value, out decimal result)
        {
            return decimal.TryParse(value, NumberStyles.Number, VietnameseCulture, out result)
                || decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out result);
        }
    }
}
