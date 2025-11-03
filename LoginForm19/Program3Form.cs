using System;
using System.Windows.Forms;

namespace LoginForm019
{
    public partial class Program3Form : Form
    {
        public Program3Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text.Trim(), out double a) ||
                !double.TryParse(txtNum2.Text.Trim(), out double b))
            {
                lblResult.Text = "Enter valid numbers.";
                return;
            }

            double sum = a + b;
            lblResult.Text = "Sum = " + sum.ToString();
        }
    }
}
