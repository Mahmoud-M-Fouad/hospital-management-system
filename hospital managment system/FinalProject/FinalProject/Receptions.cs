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
    public partial class Receptions : Form
    {
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
        AddPatient addpatient;
        public static string ss;
        Login l;
        
        Delete_Update delete_update;
        
       public static string s,tID;
        public Receptions()
        {
            InitializeComponent();
            comboBoxID.SelectedIndex = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            cls.methodPanelWidth(panelPatient, 217, 727);
            label.Text = "";
            panelResult.Controls.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            s = "AddPatient";
            label.Text = "Add a new patient";
            ss = "AddPatient";
            groupBox1.Visible = false;

            btdelete.Enabled = false;
            btnSear.Enabled = false;
           
            addpatient = new AddPatient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cls.methodSetForm(panelResult, addpatient);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            s = "Upate Patient";
            label.Text = s;
            ss = "Upate Patient";
           
            btdelete.Enabled = false;
            groupBox1.Visible = true;
            btnSear.Enabled = false;
           

            delete_update = new Delete_Update() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cls.methodSetForm(panelResult, delete_update);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            s = "Search about Patient";
            label.Text = s;
            
            string sq = "Search";
        
            btdelete.Enabled = false;
            groupBox1.Visible = true;
            btnSear.Enabled = true;
           
            
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            s = "Delete Patient";
            label.Text = s;
         
            btdelete.Enabled = true;
            groupBox1.Visible = true;
            btnSear.Enabled = false;
            

            delete_update = new Delete_Update() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cls.methodSetForm(panelResult, delete_update);
            //sql.delete_patient(txtID.Text, comboBoxID.Text);
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            s = "Reserve Patient";
            label.Text = s;

            btdelete.Enabled = false;
            groupBox1.Visible = true;
            btnSear.Enabled = false;
           


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            l = new Login();
            l.Show();
            this.Close();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                MessageBox.Show("Please Enter " + comboBoxID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addpatient = new AddPatient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                cls.methodSetForm(panelResult, addpatient);
                sql.get_patient_few_details(txtID.Text,comboBoxID.Text, addpatient.txtName, addpatient.txtAge, addpatient.txtAddress, addpatient.txtNationalId,addpatient.radioMale,addpatient.txtdocid,addpatient.txtPhone,addpatient.txtState,addpatient.comboBoxBlood);
               
            }

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="") MessageBox.Show("Please Enter " + comboBoxID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                sql.delete_patient(txtID.Text, comboBoxID.Text);
            }
          
        }

        private void label_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btupdate_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                MessageBox.Show("Please Enter " + comboBoxID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
               
                datagrid form = new datagrid();
                sql.serch_patient(txtID.Text, comboBoxID.Text);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void panelResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                
                //btnReser.Enabled = false;
                datagrid form = new datagrid();
            
                sql.all_patients(form.dataGridView1);
            form.ShowDialog();

        }
    }
}
