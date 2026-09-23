using System;
using System.Windows.Forms;

namespace baitap4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Append the button text to the display (UI only)
            this.txtDisplay.Text += btn.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = string.Empty;
        }
    }
}
