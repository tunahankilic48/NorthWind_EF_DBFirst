using NorthWind_EF_DBFirst.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind_ET_DBFirst.Forms
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void pnlCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories(this);
            frm.Show();
            this.Hide();
        }
        private void lblCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories(this);
            frm.Show();
            this.Hide();
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                this.Close();
        }

        private void pnlCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers(this);
            frm.Show();
            this.Hide();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers(this);
            frm.Show();
            this.Hide();
        }
    }
}
