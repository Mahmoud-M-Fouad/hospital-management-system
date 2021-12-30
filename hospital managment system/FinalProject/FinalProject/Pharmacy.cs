using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Pharmacy : Form
    {
        mysqlclass sql = new mysqlclass();
        Class1 cls = new Class1();
        Login l;
        public Pharmacy()
        {
            InitializeComponent();
            sql.allproducts_of_pharmacy(dataGridView1);
            sql.get_productsnames(comboaddanexistsproduct);
            sql.get_productsnames(combogetproduct);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            l = new Login();
            l.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
            
        }

        private void btnaddnewproduct_Click(object sender, EventArgs e)
        {
            if (txtaddnewproduct.Text == "" && txtmountaddnewproduct.Text == "") MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = txtaddnewproduct.Text;
                int mount = Convert.ToInt16(txtmountaddnewproduct.Text);
                sql.add_new_pharmacy_product(name, mount, dataGridView1);
                sql.get_productsnames(comboaddanexistsproduct);
                sql.get_productsnames(combogetproduct);
                txtaddnewproduct.Text = "";
                txtmountaddnewproduct.Text ="";
            }
        }

        private void btnaddanexistsproduct_Click(object sender, EventArgs e)
        {
            if (txtaddanexistsproduct.Text == "") MessageBox.Show("Please Enter A Mount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = comboaddanexistsproduct.Text;
                int mount = Convert.ToInt32(txtaddanexistsproduct.Text);
                MessageBox.Show(name);
                sql.add_an_exists_product(name, mount, dataGridView1);
                txtaddanexistsproduct.Text = "";
            }
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            if (txtgetmount.Text == "" )
                MessageBox.Show("Please Enter A Mount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = combogetproduct.Text;
                int mount = Convert.ToInt32(txtgetmount.Text);
                sql.get_an_product(name, mount, dataGridView1);
                txtgetmount.Text = "";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            sql.get_productsnames(comboaddanexistsproduct);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            sql.get_productsnames(combogetproduct);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtgetmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void txtaddanexistsproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void txtmountaddnewproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void txtaddnewproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetLatter(e);
        }
    }
}
