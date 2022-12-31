using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using NorthWind_EF_DBFirst.Models;

namespace NorthWind_ET_DBFirst.Forms
{
    public partial class frmCategories : Form
    {
        public frmCategories(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        NORTHWNDContext context = new NORTHWNDContext();
        ErrorProvider erpCategoryName = new ErrorProvider(), erpCategoryID = new ErrorProvider();
        private frmHomePage _frm;

        void ListCategories()
        {
            var values = from x in context.Categories
                         select new
                         {
                             x.CategoryId,
                             x.CategoryName,
                             x.Description
                         };
            dataGridView1.DataSource = values.ToList();
        }
        void CleanTheControls()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            ListCategories();
            CleanTheControls();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }
        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text) || txtCategoryName.Text.Length > 15)
            {
                erpCategoryName.SetError(txtCategoryName, "Category Name cannot be null and maximum length can be 15 chracters.");
            }
            else
            {
                erpCategoryName.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCategoryName.Text) || txtCategoryName.Text.Length > 15))
            {
                DialogResult answer = MessageBox.Show("Are you sure adding new category?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    context.Categories.Add(new Category() { CategoryName = txtCategoryName.Text, Description = txtDescription.Text });
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("New category is added into Categories table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Addition of new category has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCategories();
                CleanTheControls();
            }
            else
            {
                MessageBox.Show("Category Name cannot be null and maximum length can be 15 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryID.Text))
            {
                DialogResult answer = MessageBox.Show("Are you sure delete the category?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Category? category = context.Categories.Find(int.Parse(txtCategoryID.Text));
                    context.Categories.Remove(category);
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("The category is deleted from Categories table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Deletion of the category has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCategories();
                CleanTheControls();
            }
            else
            {
                MessageBox.Show("Category ID cannot be null in the deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCategoryName.Text) || txtCategoryName.Text.Length > 15) && !string.IsNullOrEmpty(txtCategoryID.Text))
            {
                DialogResult answer = MessageBox.Show("Are you sure update the category?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Category? category = context.Categories.Find(int.Parse(txtCategoryID.Text));
                    category.CategoryName = txtCategoryName.Text;
                    category.Description = txtDescription.Text;
                    context.Categories.Update(category);
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("The category is updated on Categories table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Update of the category has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCategories();
                CleanTheControls();
            }
            else
                MessageBox.Show("Category Name and Category ID cannot be null and maximum length of Category Name can be 15 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                int categoryID = 0;
                if (!string.IsNullOrEmpty(txtCategoryIDSearch.Text) && int.TryParse(txtCategoryIDSearch.Text, out categoryID) && categoryID > 0)
                {
                    erpCategoryID.Clear();
                    var category = from x in context.Categories
                                   select new
                                   {
                                       x.CategoryId,
                                       x.CategoryName,
                                       x.Description
                                   };
                    dataGridView1.DataSource = category.Where(x => x.CategoryId == categoryID).ToList();
                }
                else
                    erpCategoryID.SetError(txtCategoryIDSearch, "Only positive integers can be acceoted.");
            }
            else if (rdbName.Checked)
            {
                var category = from x in context.Categories
                               where x.CategoryName.Contains(txtCategoryNameSearch.Text)
                               select new
                               {
                                   x.CategoryId,
                                   x.CategoryName,
                                   x.Description
                               };
                dataGridView1.DataSource = category.ToList();
            }
            else if (rdbDescription.Checked)
            {
                var category = from x in context.Categories
                               where Convert.ToString(x.Description).Contains(txtDescriptionSearch.Text)
                               select new
                               {
                                   x.CategoryId,
                                   x.CategoryName,
                                   x.Description
                               };
                dataGridView1.DataSource = category.ToList();
            }
            else
                MessageBox.Show("One of the search options must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ListCategories();
        }
    }
}
