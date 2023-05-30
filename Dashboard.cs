using GroupProject.Database;
using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Dashboard : Form
    {
        private ShopContext? _dbContext;
        public Dashboard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            // Uncomment the line below to start fresh with a new database.
            //_dbContext.Database.EnsureDeleted();
            //_dbContext.Database.EnsureCreated();
            //_dbContext.Users.Load();

            _dbContext = new ShopContext();
            refreshDataGridView();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
            Application.Exit();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                User user = _dbContext.Users.Find(dgvUsers.SelectedCells[0].Value);
                txtId.Text = user.Id.ToString();
                txtName.Text = user.UserName;
                txtPassword.Text = user.Password;
                comboBox1.SelectedIndex = (int)user.Role;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new()
                {
                    UserName = txtName.Text.Trim().ToLower(),
                    Password = txtPassword.Text.Trim().ToLower(),
                    Role = (User.UserRole)comboBox1.SelectedIndex
                };
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                MessageBox.Show("success");
                refreshDataGridView();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = _dbContext.Users.Find(dgvUsers.SelectedCells[0].Value);
            user.UserName = txtName.Text.Trim().ToLower();
            user.Password = txtPassword.Text.Trim().ToLower();
            user.Role = (User.UserRole)comboBox1.SelectedIndex;
            _dbContext.Update(user);
            MessageBox.Show("success");
            _dbContext.SaveChanges();
            refreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = _dbContext.Users.Find(dgvUsers.SelectedCells[0].Value);
            _dbContext.Remove(user);
            MessageBox.Show("success");
            _dbContext.SaveChanges();
            refreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm tabForm = new MainForm();
            this.Hide();
            tabForm.Show();
        }
        private void refreshDataGridView()
        {
            this.userBindingSource.DataSource = _dbContext.Users.ToList();
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.userBindingSource.DataSource = _dbContext.Products.Where(p => p.ProductName.Contains(txtSearch.Text.Trim().ToLower())).ToList();

        }
    }
}
