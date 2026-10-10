namespace Bai5._4
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private ComboBox cboViewMode;
        private Label lblViewMode;
        private ImageList treeImageList;
        private ImageList employeeImageList;
        private ColumnHeader colEmployeeId;
        private ColumnHeader colFullName;
        private ColumnHeader colPosition;
        private ColumnHeader colStartDate;

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
            splitContainer = new SplitContainer();
            tvDepartments = new TreeView();
            treeImageList = new ImageList(components);
            lsvEmployees = new ListView();
            employeeImageList = new ImageList(components);
            colEmployeeId = new ColumnHeader();
            colFullName = new ColumnHeader();
            colPosition = new ColumnHeader();
            colStartDate = new ColumnHeader();
            cboViewMode = new ComboBox();
            lblViewMode = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(lsvEmployees);
            splitContainer.Panel2.Controls.Add(cboViewMode);
            splitContainer.Panel2.Controls.Add(lblViewMode);
            splitContainer.Size = new Size(1044, 490);
            splitContainer.SplitterDistance = 280;
            splitContainer.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.HideSelection = false;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = treeImageList;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(280, 490);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // treeImageList
            // 
            treeImageList.ColorDepth = ColorDepth.Depth32Bit;
            treeImageList.ImageSize = new Size(16, 16);
            treeImageList.TransparentColor = Color.Transparent;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { colEmployeeId, colFullName, colPosition, colStartDate });
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = employeeImageList;
            lsvEmployees.Location = new Point(0, 50);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(760, 440);
            lsvEmployees.SmallImageList = employeeImageList;
            lsvEmployees.TabIndex = 0;
            lsvEmployees.TileSize = new Size(320, 48);
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // employeeImageList
            // 
            employeeImageList.ColorDepth = ColorDepth.Depth32Bit;
            employeeImageList.ImageSize = new Size(32, 32);
            employeeImageList.TransparentColor = Color.Transparent;
            // 
            // colEmployeeId
            // 
            colEmployeeId.Text = "Mã NV";
            colEmployeeId.Width = 100;
            // 
            // colFullName
            // 
            colFullName.Text = "Họ Tên";
            colFullName.Width = 190;
            // 
            // colPosition
            // 
            colPosition.Text = "Chức vụ";
            colPosition.Width = 180;
            // 
            // colStartDate
            // 
            colStartDate.Text = "Ngày vào làm";
            colStartDate.Width = 140;
            // 
            // cboViewMode
            // 
            cboViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile" });
            cboViewMode.Location = new Point(104, 15);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(140, 28);
            cboViewMode.TabIndex = 1;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // lblViewMode
            // 
            lblViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblViewMode.AutoSize = true;
            lblViewMode.Location = new Point(7, 18);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new Size(91, 20);
            lblViewMode.TabIndex = 2;
            lblViewMode.Text = "Chế độ xem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 490);
            Controls.Add(splitContainer);
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trình quản lý nhân viên";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
