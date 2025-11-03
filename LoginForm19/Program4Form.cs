using System;
using System.Windows.Forms;

namespace LoginForm019
{
    public partial class Program4Form : Form
    {
        public Program4Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome Amna Malik! Your project works perfectly!";
        }
    }
}
