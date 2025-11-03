using LoginForm019;
using System.Windows.Forms;

string user = txtUsername.Text.Trim();
string pass = txtPassword.Text;

if (user == "amna" && pass == "123")
{
    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    HomeForm home = new HomeForm();
    home.Show();
}
else
{
    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtPassword.Clear();
    txtUsername.Focus();
}
