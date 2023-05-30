using GroupProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using GroupProject.Models;

namespace GroupProject
{
    public partial class ProductForm : Form
    {
        private ShopContext? _dbContext;

        public ProductForm()
        {
            InitializeComponent();
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            refreshDataGridView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int categoryId = (int)cbCategory.SelectedValue;
                Product product = new()
                {
                    ProductName = txtProductName.Text.Trim(),
                    CategoryId = categoryId,
                    Size = (Product.ProductSize)cbSize.SelectedIndex,
                    Color = (Product.ProductColor)cbColor.SelectedIndex
                };
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                MessageBox.Show("success");
                refreshDataGridView();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void refreshDataGridView()
        {
            _dbContext = new ShopContext();
            this.productBindingSource.DataSource = _dbContext.Products.ToList();
            this.categoryBindingSource.DataSource = _dbContext.Categories.ToList();
            dgvProducts.Refresh();
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                var product = _dbContext.Products.Find(dgvProducts.SelectedCells[0].Value);
                txtProductId.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProductName;
                cbCategory.SelectedIndex = product.CategoryId - 1;
                cbSize.SelectedIndex = (int)product.Size;
                cbColor.SelectedIndex = (int)product.Color;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = _dbContext.Products.Find(dgvProducts.SelectedCells[0].Value);
            product.ProductName = txtProductName.Text.Trim().ToLower();
            product.CategoryId = cbCategory.SelectedIndex + 1;
            product.Size = (Product.ProductSize)cbSize.SelectedIndex;
            product.Color = (Product.ProductColor)cbColor.SelectedIndex;
            _dbContext.Update(product);
            MessageBox.Show("success");
            _dbContext.SaveChanges();
            refreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var product = _dbContext.Products.Find(dgvProducts.SelectedCells[0].Value);
            _dbContext.Remove(product);
            MessageBox.Show("success");
            _dbContext.SaveChanges();
            refreshDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.productBindingSource.DataSource = _dbContext.Products.Where(p => p.ProductName.Contains(txtSearch.Text.Trim())).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
