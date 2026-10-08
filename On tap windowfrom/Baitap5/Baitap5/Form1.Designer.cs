namespace Baitap5
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;
        private SplitContainer mainSplitContainer;
        private TabControl detailsTabControl;
        private TabPage customerTabPage;
        private TabPage shippingTabPage;
        private Label customerNameLabel;
        private TextBox customerNameTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label noteLabel;
        private TextBox noteTextBox;
        private Label shippingTypeLabel;
        private ComboBox shippingTypeComboBox;
        private Label deliveryDateLabel;
        private DateTimePicker deliveryDatePicker;
        private Label priorityLabel;
        private CheckBox priorityCheckBox;
        private Label dashboardTitleLabel;
        private DataGridView orderItemsDataGridView;
        private DataGridViewTextBoxColumn itemNameColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn weightColumn;
        private DataGridViewTextBoxColumn unitPriceColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private StatusStrip orderStatusStrip;
        private ToolStripStatusLabel clockStatusLabel;
        private ToolStripStatusLabel quantityStatusLabel;
        private ToolStripStatusLabel weightStatusLabel;
        private ToolStripStatusLabel totalStatusLabel;
        private ErrorProvider inputErrorProvider;
        private System.Windows.Forms.Timer clockTimer;

        
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
            mainSplitContainer = new SplitContainer();
            detailsTabControl = new TabControl();
            customerTabPage = new TabPage();
            customerNameLabel = new Label();
            customerNameTextBox = new TextBox();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            noteLabel = new Label();
            noteTextBox = new TextBox();
            shippingTabPage = new TabPage();
            shippingTypeLabel = new Label();
            shippingTypeComboBox = new ComboBox();
            deliveryDateLabel = new Label();
            deliveryDatePicker = new DateTimePicker();
            priorityLabel = new Label();
            priorityCheckBox = new CheckBox();
            orderItemsDataGridView = new DataGridView();
            itemNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            weightColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            dashboardTitleLabel = new Label();
            orderStatusStrip = new StatusStrip();
            clockStatusLabel = new ToolStripStatusLabel();
            quantityStatusLabel = new ToolStripStatusLabel();
            weightStatusLabel = new ToolStripStatusLabel();
            totalStatusLabel = new ToolStripStatusLabel();
            inputErrorProvider = new ErrorProvider(components);
            clockTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            detailsTabControl.SuspendLayout();
            customerTabPage.SuspendLayout();
            shippingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).BeginInit();
            orderStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.FixedPanel = FixedPanel.Panel1;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(detailsTabControl);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(orderItemsDataGridView);
            mainSplitContainer.Panel2.Controls.Add(dashboardTitleLabel);
            mainSplitContainer.Size = new Size(1163, 470);
            mainSplitContainer.SplitterDistance = 303;
            mainSplitContainer.TabIndex = 0;
            // 
            // detailsTabControl
            // 
            detailsTabControl.Controls.Add(customerTabPage);
            detailsTabControl.Controls.Add(shippingTabPage);
            detailsTabControl.Dock = DockStyle.Fill;
            detailsTabControl.Location = new Point(0, 0);
            detailsTabControl.Name = "detailsTabControl";
            detailsTabControl.Padding = new Point(12, 4);
            detailsTabControl.SelectedIndex = 0;
            detailsTabControl.Size = new Size(303, 470);
            detailsTabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Controls.Add(customerNameLabel);
            customerTabPage.Controls.Add(customerNameTextBox);
            customerTabPage.Controls.Add(phoneLabel);
            customerTabPage.Controls.Add(phoneTextBox);
            customerTabPage.Controls.Add(addressLabel);
            customerTabPage.Controls.Add(addressTextBox);
            customerTabPage.Controls.Add(noteLabel);
            customerTabPage.Controls.Add(noteTextBox);
            customerTabPage.Location = new Point(4, 31);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new Padding(12);
            customerTabPage.Size = new Size(295, 435);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Khách hàng";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(15, 20);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(111, 20);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Tên khách hàng";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customerNameTextBox.Location = new Point(15, 43);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.PlaceholderText = "Nhập tên khách hàng";
            customerNameTextBox.Size = new Size(265, 27);
            customerNameTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(15, 84);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(97, 20);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Số điện thoại";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTextBox.Location = new Point(15, 107);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "Nhập số điện thoại";
            phoneTextBox.Size = new Size(265, 27);
            phoneTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(15, 148);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(126, 20);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Địa chỉ giao hàng";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(15, 171);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(265, 72);
            addressTextBox.TabIndex = 5;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(15, 265);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(58, 20);
            noteLabel.TabIndex = 6;
            noteLabel.Text = "Ghi chú";
            // 
            // noteTextBox
            // 
            noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            noteTextBox.Location = new Point(15, 288);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(265, 72);
            noteTextBox.TabIndex = 7;
            // 
            // shippingTabPage
            // 
            shippingTabPage.Controls.Add(shippingTypeLabel);
            shippingTabPage.Controls.Add(shippingTypeComboBox);
            shippingTabPage.Controls.Add(deliveryDateLabel);
            shippingTabPage.Controls.Add(deliveryDatePicker);
            shippingTabPage.Controls.Add(priorityLabel);
            shippingTabPage.Controls.Add(priorityCheckBox);
            shippingTabPage.Location = new Point(4, 31);
            shippingTabPage.Name = "shippingTabPage";
            shippingTabPage.Padding = new Padding(12);
            shippingTabPage.Size = new Size(295, 435);
            shippingTabPage.TabIndex = 1;
            shippingTabPage.Text = "Vận chuyển";
            // 
            // shippingTypeLabel
            // 
            shippingTypeLabel.AutoSize = true;
            shippingTypeLabel.Location = new Point(15, 20);
            shippingTypeLabel.Name = "shippingTypeLabel";
            shippingTypeLabel.Size = new Size(114, 20);
            shippingTypeLabel.TabIndex = 0;
            shippingTypeLabel.Text = "Loại vận chuyển";
            // 
            // shippingTypeComboBox
            // 
            shippingTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shippingTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shippingTypeComboBox.Items.AddRange(new object[] { "Tiêu chuẩn", "Nhanh", "Hỏa tốc" });
            shippingTypeComboBox.Location = new Point(15, 43);
            shippingTypeComboBox.Name = "shippingTypeComboBox";
            shippingTypeComboBox.Size = new Size(345, 28);
            shippingTypeComboBox.TabIndex = 1;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new Point(15, 87);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new Size(131, 20);
            deliveryDateLabel.TabIndex = 2;
            deliveryDateLabel.Text = "Ngày giao dự kiến";
            // 
            // deliveryDatePicker
            // 
            deliveryDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deliveryDatePicker.Format = DateTimePickerFormat.Short;
            deliveryDatePicker.Location = new Point(15, 110);
            deliveryDatePicker.Name = "deliveryDatePicker";
            deliveryDatePicker.Size = new Size(345, 27);
            deliveryDatePicker.TabIndex = 3;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(15, 158);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(110, 20);
            priorityLabel.TabIndex = 4;
            priorityLabel.Text = "Mức độ ưu tiên";
            // 
            // priorityCheckBox
            // 
            priorityCheckBox.AutoSize = true;
            priorityCheckBox.Location = new Point(15, 184);
            priorityCheckBox.Name = "priorityCheckBox";
            priorityCheckBox.Size = new Size(146, 24);
            priorityCheckBox.TabIndex = 5;
            priorityCheckBox.Text = "Đơn hàng ưu tiên";
            // 
            // orderItemsDataGridView
            // 
            orderItemsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsDataGridView.BackgroundColor = SystemColors.Window;
            orderItemsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            orderItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { itemNameColumn, quantityColumn, weightColumn, unitPriceColumn, amountColumn });
            orderItemsDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            orderItemsDataGridView.Location = new Point(6, 53);
            orderItemsDataGridView.MultiSelect = false;
            orderItemsDataGridView.Name = "orderItemsDataGridView";
            orderItemsDataGridView.RowHeadersWidth = 44;
            orderItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderItemsDataGridView.Size = new Size(850, 389);
            orderItemsDataGridView.TabIndex = 1;
            orderItemsDataGridView.CellValidating += orderItemsDataGridView_CellValidating;
            orderItemsDataGridView.CellValueChanged += orderItemsDataGridView_CellValueChanged;
            orderItemsDataGridView.RowsAdded += orderItemsDataGridView_RowsChanged;
            orderItemsDataGridView.RowsRemoved += orderItemsDataGridView_RowsChanged;
            orderItemsDataGridView.KeyDown += orderItemsDataGridView_KeyDown;
            // 
            // itemNameColumn
            // 
            itemNameColumn.HeaderText = "Tên hàng";
            itemNameColumn.MinimumWidth = 6;
            itemNameColumn.Name = "itemNameColumn";
            itemNameColumn.Width = 210;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Số lượng";
            quantityColumn.MinimumWidth = 6;
            quantityColumn.Name = "quantityColumn";
            quantityColumn.Width = 90;
            // 
            // weightColumn
            // 
            weightColumn.HeaderText = "Trọng lượng (kg)";
            weightColumn.MinimumWidth = 6;
            weightColumn.Name = "weightColumn";
            weightColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            unitPriceColumn.HeaderText = "Đơn giá";
            unitPriceColumn.MinimumWidth = 6;
            unitPriceColumn.Name = "unitPriceColumn";
            unitPriceColumn.Width = 115;
            // 
            // amountColumn
            // 
            amountColumn.HeaderText = "Thành tiền";
            amountColumn.MinimumWidth = 6;
            amountColumn.Name = "amountColumn";
            amountColumn.ReadOnly = true;
            amountColumn.Width = 130;
            // 
            // dashboardTitleLabel
            // 
            dashboardTitleLabel.AutoSize = true;
            dashboardTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            dashboardTitleLabel.Location = new Point(16, 15);
            dashboardTitleLabel.Name = "dashboardTitleLabel";
            dashboardTitleLabel.Size = new Size(220, 35);
            dashboardTitleLabel.TabIndex = 2;
            dashboardTitleLabel.Text = "Chi tiết đơn hàng";
            // 
            // orderStatusStrip
            // 
            orderStatusStrip.ImageScalingSize = new Size(20, 20);
            orderStatusStrip.Items.AddRange(new ToolStripItem[] { clockStatusLabel, quantityStatusLabel, weightStatusLabel, totalStatusLabel });
            orderStatusStrip.Location = new Point(0, 470);
            orderStatusStrip.Name = "orderStatusStrip";
            orderStatusStrip.Size = new Size(1163, 30);
            orderStatusStrip.TabIndex = 1;
            // 
            // clockStatusLabel
            // 
            clockStatusLabel.Name = "clockStatusLabel";
            clockStatusLabel.Size = new Size(120, 24);
            clockStatusLabel.Text = "Thời gian: --:--:--";
            // 
            // quantityStatusLabel
            // 
            quantityStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            quantityStatusLabel.Name = "quantityStatusLabel";
            quantityStatusLabel.Size = new Size(124, 24);
            quantityStatusLabel.Text = "Tổng số lượng: 0";
            // 
            // weightStatusLabel
            // 
            weightStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            weightStatusLabel.Name = "weightStatusLabel";
            weightStatusLabel.Size = new Size(165, 24);
            weightStatusLabel.Text = "Tổng trọng lượng: 0 kg";
            // 
            // totalStatusLabel
            // 
            totalStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            totalStatusLabel.Name = "totalStatusLabel";
            totalStatusLabel.Size = new Size(104, 24);
            totalStatusLabel.Text = "Tổng tiền: 0 ₫";
            // 
            // inputErrorProvider
            // 
            inputErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            inputErrorProvider.ContainerControl = this;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 500);
            Controls.Add(mainSplitContainer);
            Controls.Add(orderStatusStrip);
            MinimumSize = new Size(850, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển quản lý đơn giao hàng";
            Load += Form1_Load;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            detailsTabControl.ResumeLayout(false);
            customerTabPage.ResumeLayout(false);
            customerTabPage.PerformLayout();
            shippingTabPage.ResumeLayout(false);
            shippingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).EndInit();
            orderStatusStrip.ResumeLayout(false);
            orderStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}
