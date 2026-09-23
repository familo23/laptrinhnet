namespace baitap4._3
{
    partial class Form1
    {
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
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 420);
            Text = "Calculator";

            // Display
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtDisplay.Location = new System.Drawing.Point(10, 10);
            this.txtDisplay.Size = new System.Drawing.Size(290, 40);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Controls.Add(this.txtDisplay);

            // Number buttons 1-9 arranged in grid
            int startX = 10, startY = 60, btnW = 70, btnH = 50, gap = 10;
            for (int i = 1; i <= 9; i++)
            {
                var btn = new System.Windows.Forms.Button();
                int row = (i - 1) / 3;
                int col = (i - 1) % 3;
                btn.Location = new System.Drawing.Point(startX + col * (btnW + gap), startY + row * (btnH + gap));
                btn.Size = new System.Drawing.Size(btnW, btnH);
                btn.Name = "btn" + i.ToString();
                btn.Text = i.ToString();
                btn.Click += new System.EventHandler(this.NumberButton_Click);
                this.Controls.Add(btn);
                // keep a reference for btn0..btn9 fields
                switch (i)
                {
                    case 1: this.btn1 = btn; break;
                    case 2: this.btn2 = btn; break;
                    case 3: this.btn3 = btn; break;
                    case 4: this.btn4 = btn; break;
                    case 5: this.btn5 = btn; break;
                    case 6: this.btn6 = btn; break;
                    case 7: this.btn7 = btn; break;
                    case 8: this.btn8 = btn; break;
                    case 9: this.btn9 = btn; break;
                }
            }

            // Zero button
            this.btn0 = new System.Windows.Forms.Button();
            this.btn0.Location = new System.Drawing.Point(startX + (btnW + gap), startY + 3 * (btnH + gap));
            this.btn0.Size = new System.Drawing.Size(btnW, btnH);
            this.btn0.Name = "btn0";
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);
            this.Controls.Add(this.btn0);

            // Operator buttons
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPlus.Location = new System.Drawing.Point(startX + 3 * (btnW + gap) - (btnW + gap), startY);
            this.btnPlus.Size = new System.Drawing.Size(btnW, btnH);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Text = "+";
            this.Controls.Add(this.btnPlus);

            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMinus.Location = new System.Drawing.Point(startX + 3 * (btnW + gap) - (btnW + gap), startY + (btnH + gap));
            this.btnMinus.Size = new System.Drawing.Size(btnW, btnH);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Text = "-";
            this.Controls.Add(this.btnMinus);

            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMultiply.Location = new System.Drawing.Point(startX + 3 * (btnW + gap) - (btnW + gap), startY + 2 * (btnH + gap));
            this.btnMultiply.Size = new System.Drawing.Size(btnW, btnH);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Text = "*";
            this.Controls.Add(this.btnMultiply);

            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDivide.Location = new System.Drawing.Point(startX + 3 * (btnW + gap) - (btnW + gap), startY + 3 * (btnH + gap));
            this.btnDivide.Size = new System.Drawing.Size(btnW, btnH);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Text = "/";
            this.Controls.Add(this.btnDivide);

            // Equals and Clear
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnEquals.Location = new System.Drawing.Point(startX + 2 * (btnW + gap), startY + 3 * (btnH + gap));
            this.btnEquals.Size = new System.Drawing.Size(btnW, btnH);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Text = "=";
            this.Controls.Add(this.btnEquals);

            this.btnClear = new System.Windows.Forms.Button();
            this.btnClear.Location = new System.Drawing.Point(startX, startY + 3 * (btnH + gap));
            this.btnClear.Size = new System.Drawing.Size(btnW, btnH);
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            this.Controls.Add(this.btnClear);
        }

        #endregion
    }
}
