using LoginForm19;
using System;
using System.Windows.Forms;

namespace LoginForm019
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnProgram1_Click(object sender, EventArgs e)
        {
            Program1Form p = new Program1Form();
            p.Show();
        }

        private void btnProgram2_Click(object sender, EventArgs e)
        {
            Program2Form p = new Program2Form();
            p.Show();
        }

        private void btnProgram3_Click(object sender, EventArgs e)
        {
            Program3Form p = new Program3Form();
            p.Show();
        }

        private void btnProgram4_Click(object sender, EventArgs e)
        {
            Program4Form p = new Program4Form();
            p.Show();
        }
    }
}
