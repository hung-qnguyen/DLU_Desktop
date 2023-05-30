using GroupProject.Database;
using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        private ShopContext? _dbContext;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateInputAndVerifyLogin())
            {

                MainForm mainForm = new();
                this.Hide();
                mainForm.ShowDialog();
            }

        }

        private bool validateInputAndVerifyLogin()
        {
            _dbContext = new ShopContext();
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons button = MessageBoxButtons.OK;
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text.Contains(" "))
            {
                MessageBox.Show("Ten tai khoan khong hop le", "Loi", button, icon);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mat khau khong hop le", "Loi", button, icon);
                return false;
            }
            if (_dbContext.Users.Where(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text).FirstOrDefault() == null)
            {
                MessageBox.Show("Sai tai khoan hoac mat khau", "Loi", button, icon);
                return false;
            }
            _dbContext?.Dispose();
            _dbContext = null;
            return true;
        }

    }
}