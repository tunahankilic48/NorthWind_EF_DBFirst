using NorthWind_EF_DBFirst.Models;
using NorthWind_ET_DBFirst.Forms;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NorthWind_EF_DBFirst.Forms
{
    public partial class frmCustomers : Form
    {
        public frmCustomers(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        NORTHWNDContext context = new NORTHWNDContext();
        private frmHomePage _frm;
        void ListCustomers()
        {
            dataGridView1.DataSource = context.Customers.ToList();
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["CustomerTypes"].Visible = false;
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
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            ListCustomers();
            CleanTheControls();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtCompanyName.Text = dataGridView1.CurrentRow.Cells["CompanyName"].Value.ToString();
            txtContactName.Text = (string)dataGridView1.CurrentRow.Cells["ContactName"].Value;
            txtContactTitle.Text = (string)dataGridView1.CurrentRow.Cells["ContactTitle"].Value;
            txtAddress.Text = (string)dataGridView1.CurrentRow.Cells["Address"].Value;
            txtCity.Text = (string)dataGridView1.CurrentRow.Cells["City"].Value;
            txtRegion.Text = (string)dataGridView1.CurrentRow.Cells["Region"].Value;
            txtPostalCode.Text = (string)dataGridView1.CurrentRow.Cells["PostalCode"].Value;
            txtCountry.Text = (string)dataGridView1.CurrentRow.Cells["Country"].Value;
            txtPhone.Text = (string)dataGridView1.CurrentRow.Cells["Phone"].Value;
            txtFax.Text = (string)dataGridView1.CurrentRow.Cells["Fax"].Value;
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Length != 5)
            {
                erpCustomerID.SetError(txtCustomerID, "CustomerID must be 5 character");
            }
            else
            {
                erpCustomerID.Clear();
            }
        }
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Length > 40)
            {
                erpCompanyName.SetError(txtCompanyName, "Length of the company name must be less than 40 character");
            }
            else
            {
                erpCompanyName.Clear();
            }
        }
        private void txtContactName_TextChanged(object sender, EventArgs e)
        {
            if (txtContactName.Text.Length > 30)
            {
                erpContactName.SetError(txtContactName, "Length of the contact name must be less than 30 character");
            }
            else
            {
                erpContactName.Clear();
            }
        }
        private void txtContactTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtContactTitle.Text.Length > 30)
            {
                erpContactTitle.SetError(txtContactTitle, "Length of the contact title must be less than 30 character");
            }
            else
            {
                erpContactTitle.Clear();
            }
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length > 60)
            {
                erpAddress.SetError(txtContactTitle, "Length of the address must be less than 60 character");
            }
            else
            {
                erpAddress.Clear();
            }
        }
        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 15)
            {
                erpCity.SetError(txtCity, "Length of the city must be less than 15 character");
            }
            else
            {
                erpCity.Clear();
            }
        }
        private void txtRegion_TextChanged(object sender, EventArgs e)
        {
            if (txtRegion.Text.Length > 15)
            {
                erpRegion.SetError(txtRegion, "Length of the region must be less than 15 character");
            }
            else
            {
                erpRegion.Clear();
            }
        }
        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostalCode.Text.Length > 10)
            {
                erpPostalCode.SetError(txtPostalCode, "Length of the postal code must be less than 10 character");
            }
            else
            {
                erpPostalCode.Clear();
            }
        }
        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (txtCountry.Text.Length > 15)
            {
                erpCountry.SetError(txtCountry, "Length of the country must be less than 15 character");
            }
            else
            {
                erpCountry.Clear();
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 24)
            {
                erpPhone.SetError(txtPhone, "Length of the phone must be less than 24 character");
            }
            else
            {
                erpPhone.Clear();
            }
        }
        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            if (txtFax.Text.Length > 24)
            {
                erpFax.SetError(txtFax, "Length of the fax must be less than 24 character");
            }
            else
            {
                erpFax.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(txtFax.Text.Length > 24 || txtPhone.Text.Length > 24 || txtCountry.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtRegion.Text.Length > 15 || txtCity.Text.Length > 15 || txtAddress.Text.Length > 60 || txtContactTitle.Text.Length > 30 || txtContactName.Text.Length > 30 || txtCompanyName.Text.Length > 40 || txtCustomerID.Text.Length != 5) && !string.IsNullOrEmpty(txtCustomerID.Text) && !string.IsNullOrEmpty(txtCompanyName.Text))
            {
                DialogResult answer = MessageBox.Show("Are you sure adding new customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    context.Customers.Add(new Customer()
                    {
                        CustomerId = txtCustomerID.Text,
                        CompanyName = txtCompanyName.Text,
                        ContactName = txtContactName.Text,
                        ContactTitle = txtContactTitle.Text,
                        Address = txtAddress.Text,
                        City = txtCity.Text,
                        Region = txtRegion.Text,
                        PostalCode = txtPostalCode.Text,
                        Country = txtCountry.Text,
                        Phone = txtPhone.Text,
                        Fax = txtFax.Text,
                    });
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("New customer is added into Customers table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Addition of new customer has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCustomers();
                CleanTheControls();
            }
            else
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text))
                    MessageBox.Show("Customer ID and Company Name cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Checked the Errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerID.Text))
            {
                DialogResult answer = MessageBox.Show("Are you sure delete the customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (context.Customers.Find(txtCustomerID.Text) != null)
                    {
                        Customer customer = context.Customers.Find(txtCustomerID.Text);
                        context.Customers.Remove(customer);
                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("The customer is deleted from Customers table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                        MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Deletion of the customer has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCustomers();
                CleanTheControls();
            }
            else
            {
                MessageBox.Show("Customer ID cannot be null in the deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(txtFax.Text.Length > 24 || txtPhone.Text.Length > 24 || txtCountry.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtRegion.Text.Length > 15 || txtCity.Text.Length > 15 || txtAddress.Text.Length > 60 || txtContactTitle.Text.Length > 30 || txtContactName.Text.Length > 30 || txtCompanyName.Text.Length > 40 || txtCustomerID.Text.Length != 5) && !string.IsNullOrEmpty(txtCustomerID.Text) && !string.IsNullOrEmpty(txtCompanyName.Text))
            {
                DialogResult answer = MessageBox.Show("Are you sure update the customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (context.Customers.Find(txtCustomerID.Text) != null)
                    {
                        Customer customer = context.Customers.Find(txtCustomerID.Text);
                        customer.CompanyName = txtCompanyName.Text;
                        customer.ContactName = txtContactName.Text;
                        customer.ContactTitle = txtContactTitle.Text;
                        customer.Region = txtRegion.Text;
                        customer.City = txtCity.Text;
                        customer.Address = txtAddress.Text;
                        customer.Phone = txtPhone.Text;
                        customer.Fax = txtFax.Text;
                        customer.Country = txtCountry.Text;
                        customer.PostalCode = txtPostalCode.Text;
                        context.Customers.Update(customer);
                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("The customer is updated on Customers table", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Update of the customer has been cancelled", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                ListCustomers();
                CleanTheControls();
            }
            else
            {
                if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text))
                    MessageBox.Show("Customer ID and Company Name cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Checked the Errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbCustomerID.Checked)
            {
                var customer = context.Customers.Where(x=>x.CustomerId== txtCustomerIDSearch.Text);
                dataGridView1.DataSource= customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else if (rdbCompanyName.Checked)
            {
                var customer = from x in context.Customers where x.CompanyName.Contains(txtCompanyNameSearch.Text) select x;
                dataGridView1.DataSource = customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else if (rdbPhone.Checked)
            {
                var customer = from x in context.Customers where x.Phone.Contains(txtPhoneSearch.Text) select x;
                dataGridView1.DataSource = customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else if (rdbCity.Checked)
            {
                var customer = from x in context.Customers where x.City.Contains(txtCitySearch.Text) select x;
                dataGridView1.DataSource = customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else if (rdbCountry.Checked)
            {
                var customer = from x in context.Customers where x.Country.Contains(txtCountrySearch.Text) select x;
                dataGridView1.DataSource = customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else if (rdbRegion.Checked)
            {
                var customer = from x in context.Customers where x.Region.Contains(txtRegionSearch.Text) select x;
                dataGridView1.DataSource = customer.ToList();
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["CustomerTypes"].Visible = false;
            }
            else
            {
                MessageBox.Show("One of the search options must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListallCustomers_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }
    }
}
