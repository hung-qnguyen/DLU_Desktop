using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class MainForm : Form
    {
        Dashboard dashboard = new();
        ProductForm productForm = new();
        CategoryForm categoryForm = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new();
            dashboard.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void TabForm_Load(object sender, EventArgs e)
        {

            dashboard.TopLevel = false;
            panelMain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.Gray;
            btnCategory.BackColor = Color.Transparent;
            btnProduct.BackColor = Color.Transparent;
            productForm.Hide();
            categoryForm.Hide();
            dashboard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.Transparent;
            btnCategory.BackColor = Color.Transparent;
            btnProduct.BackColor = Color.Transparent;
            Application.Exit();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.Transparent;
            btnCategory.BackColor = Color.Gray;
            btnProduct.BackColor = Color.Transparent;

            dashboard.Hide();
            productForm.Hide();

            categoryForm.TopLevel = false;
            panelMain.Controls.Add(categoryForm);

            categoryForm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.Transparent;
            btnCategory.BackColor = Color.Transparent;
            btnProduct.BackColor = Color.Gray;

            productForm.TopLevel = false;
            dashboard.Hide();
            categoryForm.Hide();
            panelMain.Controls.Add(productForm);
            productForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
