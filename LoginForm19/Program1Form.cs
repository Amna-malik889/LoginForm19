using System;
using System.Windows.Forms;

namespace LoginForm019
{
    public partial class Program1Form : Form
    {
        public Program1Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text.Trim(), out int n))
            {
                lblResult.Text = "Enter a valid whole number.";
                return;
            }
            lblResult.Text = (n % 2 == 0) ? "Even Number" : "Odd Number";
        }
    }
}
