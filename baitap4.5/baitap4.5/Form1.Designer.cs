namespace baitap4._5
{
    partial class Form1
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.Panel panelListArea;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxInputs = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panelListArea = new System.Windows.Forms.Panel();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();

            // Form
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);

            // groupBoxInputs (Column 0)
            this.groupBoxInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputs.Text = "Inputs";
            this.groupBoxInputs.Padding = new System.Windows.Forms.Padding(10);

            // Labels and TextBoxes in GroupBox
            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 28);
            this.labelName.Text = "Name:";
            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(17, 46);
            this.textBoxName.Width = 200;
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(14, 80);
            this.labelEmail.Text = "Email:";
            // textBoxEmail
            this.textBoxEmail.Location = new System.Drawing.Point(17, 98);
            this.textBoxEmail.Width = 200;
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(14, 132);
            this.labelPhone.Text = "Phone:";
            // textBoxPhone
            this.textBoxPhone.Location = new System.Drawing.Point(17, 150);
            this.textBoxPhone.Width = 200;
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // Add controls to groupBox
            this.groupBoxInputs.Controls.Add(this.labelName);
            this.groupBoxInputs.Controls.Add(this.textBoxName);
            this.groupBoxInputs.Controls.Add(this.labelEmail);
            this.groupBoxInputs.Controls.Add(this.textBoxEmail);
            this.groupBoxInputs.Controls.Add(this.labelPhone);
            this.groupBoxInputs.Controls.Add(this.textBoxPhone);

            // panelListArea (Column 1)
            this.panelListArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListArea.Padding = new System.Windows.Forms.Padding(8);

            // listBoxItems
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 52);

            // Buttons (anchored Bottom, Right)
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            this.buttonEdit.Text = "Edit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 30);
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // Position buttons at bottom-right with spacing
            // We'll place them relative to panel size by setting their initial Location near bottom-right.
            int buttonsRightOffset = 8;
            int buttonsBottomOffset = 8;
            // initial positions (will remain anchored to bottom-right)
            this.buttonDelete.Location = new System.Drawing.Point(800 - 75 - buttonsRightOffset - 17, 450 - 30 - buttonsBottomOffset - 8);
            this.buttonEdit.Location = new System.Drawing.Point(this.buttonDelete.Left - 85, this.buttonDelete.Top);
            this.buttonAdd.Location = new System.Drawing.Point(this.buttonEdit.Left - 85, this.buttonDelete.Top);

            // Add list and buttons to panel
            this.panelListArea.Controls.Add(this.listBoxItems);
            this.panelListArea.Controls.Add(this.buttonAdd);
            this.panelListArea.Controls.Add(this.buttonEdit);
            this.panelListArea.Controls.Add(this.buttonDelete);

            // Add columns to table
            this.tableLayoutPanel1.Controls.Add(this.groupBoxInputs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelListArea, 1, 0);

            // Add tableLayoutPanel to Form
            this.Controls.Add(this.tableLayoutPanel1);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
