using System;
using System.Windows.Forms;

namespace LoginForm019
{
    public partial class Program2Form : Form
    {
        public Program2Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCelsius.Text.Trim(), out double c))
            {
                lblResult.Text = "Enter a valid number.";
                return;
            }

            double f = (c * 9.0 / 5.0) + 32.0;
            lblResult.Text = "Fahrenheit: " + f.ToString("0.00");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
