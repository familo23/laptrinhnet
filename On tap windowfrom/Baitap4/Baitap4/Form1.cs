using System.Globalization;

namespace Baitap4
{
    public partial class Form1 : Form
    {
        private readonly List<Button> slotButtons = new();
        private readonly bool[] lockedSlots = new bool[20];
        private Label selectedLabel = null!;
        private Label totalLabel = null!;
        private ComboBox timeSlotComboBox = null!;

        private static readonly Color EmptyColor = Color.WhiteSmoke;
        private static readonly Color SelectedColor = Color.LightGreen;
        private static readonly Color LockedColor = Color.IndianRed;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Text = "Đặt vị trí / Đặt bàn hẹn giờ";
            MinimumSize = new Size(700, 600);
            ClientSize = new Size(800, 650);
            BackColor = Color.White;

            lockedSlots[2] = true;
            lockedSlots[11] = true;

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(20),
                BackColor = Color.White
            };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 125));
            Controls.Add(root);

            var titleLabel = new Label
            {
                Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkBlue
            };
            root.Controls.Add(titleLabel, 0, 0);

            var legend = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Anchor = AnchorStyles.None,
                AutoSize = true
            };
            legend.Controls.Add(CreateLegendItem(EmptyColor, "Trống"));
            legend.Controls.Add(CreateLegendItem(SelectedColor, "Đang chọn"));
            legend.Controls.Add(CreateLegendItem(LockedColor, "Đã khóa"));
            root.Controls.Add(legend, 0, 1);

            var slotGrid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 5,
                RowCount = 4,
                Padding = new Padding(8),
                BackColor = Color.Gainsboro,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };
            for (var column = 0; column < 5; column++)
            {
                slotGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            }
            for (var row = 0; row < 4; row++)
            {
                slotGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            }

            for (var index = 0; index < 20; index++)
            {
                var slotButton = new Button
                {
                    Text = $"Vị trí {index + 1}",
                    Dock = DockStyle.Fill,
                    Margin = new Padding(5),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Tag = index,
                    FlatStyle = FlatStyle.Flat
                };
                slotButton.Click += SlotButton_Click;
                slotButtons.Add(slotButton);
                UpdateSlotAppearance(slotButton, index);
                slotGrid.Controls.Add(slotButton, index % 5, index / 5);
            }
            root.Controls.Add(slotGrid, 0, 2);

            root.Controls.Add(CreateBookingPanel(), 0, 3);
            UpdateSummary();
        }

        private Control CreateLegendItem(Color color, string text)
        {
            var panel = new FlowLayoutPanel
            {
                AutoSize = true,
                WrapContents = false,
                Margin = new Padding(12, 3, 12, 3)
            };
            panel.Controls.Add(new Label
            {
                BackColor = color,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(22, 22),
                Margin = new Padding(0, 0, 5, 0)
            });
            panel.Controls.Add(new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                Margin = new Padding(0, 3, 0, 0)
            });
            return panel;
        }

        private Control CreateBookingPanel()
        {
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 2,
                Padding = new Padding(8, 10, 8, 0)
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            selectedLabel = new Label
            {
                Text = "Số vị trí đang chọn: 0",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panel.Controls.Add(selectedLabel, 0, 0);

            totalLabel = new Label
            {
                Text = "Tạm tính tiền: 0 đ",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen
            };
            panel.Controls.Add(totalLabel, 1, 0);

            timeSlotComboBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10),
                Margin = new Padding(3)
            };
            timeSlotComboBox.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });
            timeSlotComboBox.SelectedIndex = 0;
            timeSlotComboBox.SelectedIndexChanged += (_, _) => UpdateSummary();
            panel.Controls.Add(timeSlotComboBox, 2, 0);

            var confirmButton = new Button
            {
                Text = "Xác nhận đặt",
                Dock = DockStyle.Fill,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(3)
            };
            confirmButton.Click += ConfirmButton_Click;
            panel.Controls.Add(confirmButton, 3, 0);

            var cancelButton = new Button
            {
                Text = "Hủy chọn tất cả",
                Dock = DockStyle.Fill,
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(3)
            };
            cancelButton.Click += (_, _) => ClearSelections();
            panel.Controls.Add(cancelButton, 3, 1);

            return panel;
        }

        private void SlotButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button || button.Tag is not int index || lockedSlots[index])
            {
                return;
            }

            button.BackColor = button.BackColor == SelectedColor ? EmptyColor : SelectedColor;
            UpdateSummary();
        }

        private void ConfirmButton_Click(object? sender, EventArgs e)
        {
            var selectedCount = slotButtons.Count(button => button.BackColor == SelectedColor);
            if (selectedCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var button in slotButtons)
            {
                if (button.BackColor == SelectedColor && button.Tag is int index)
                {
                    lockedSlots[index] = true;
                    UpdateSlotAppearance(button, index);
                }
            }

            var total = selectedCount * GetCurrentPrice();
            MessageBox.Show($"Đặt thành công {selectedCount} vị trí.\nTổng tiền: {FormatCurrency(total)}", "Xác nhận đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateSummary();
        }

        private void ClearSelections()
        {
            foreach (var button in slotButtons)
            {
                if (button.Tag is int index && !lockedSlots[index])
                {
                    UpdateSlotAppearance(button, index);
                }
            }
            UpdateSummary();
        }

        private void UpdateSlotAppearance(Button button, int index)
        {
            button.BackColor = lockedSlots[index] ? LockedColor : EmptyColor;
            button.ForeColor = lockedSlots[index] ? Color.White : Color.Black;
            button.Enabled = !lockedSlots[index];
        }

        private void UpdateSummary()
        {
            if (selectedLabel is null || totalLabel is null || timeSlotComboBox is null)
            {
                return;
            }

            var selectedCount = slotButtons.Count(button => button.BackColor == SelectedColor);
            selectedLabel.Text = $"Số vị trí đang chọn: {selectedCount}";
            totalLabel.Text = $"Tạm tính tiền: {FormatCurrency(selectedCount * GetCurrentPrice())}";
        }

        private int GetCurrentPrice() => timeSlotComboBox.SelectedIndex == 1 ? 150000 : 100000;

        private static string FormatCurrency(int amount) => $"{amount.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} đ";
    }
}
