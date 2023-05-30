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
    public partial class CategoryForm : Form
    {
        private ShopContext? _dbContext;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            _dbContext = new ShopContext();
            this.categoryBindingSource.DataSource = _dbContext.Categories.ToList();
            dgvCategory.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Category category = new()
                {
                    CategoryName = txtName.Text.Trim().ToLower(),
                    CategoryDesc = txtDesc.Text.Trim().ToLower()
                };
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
                MessageBox.Show("success");
                refreshDataGridView();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //_dbContext.Categories.ExecuteDelete
        }
    }
}
