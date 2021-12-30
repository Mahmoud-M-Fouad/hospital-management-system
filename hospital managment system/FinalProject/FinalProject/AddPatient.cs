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
    public partial class AddPatient : Form
    {
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
        public AddPatient()
        {
            InitializeComponent();
          //  comboBoxspecializedoc.SelectedIndex = 1;
          //  comboBoxdoctor.SelectedIndex = 0;
           // comboBoxnurse.SelectedIndex = 0;
           // comboBoxoppo.SelectedIndex = 0;
            //  comboBoxspecializedoc.SelectedIndex = 0;
            comboBoxBlood.SelectedIndex = 0;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetLatter(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            int age;
            string address = txtAddress.Text;
            string SSN = txtNationalId.Text;
            string gender = "";
            if (radioMale.Checked == true)
                gender = "Male";
            else gender = "Female";
            string state = txtState.Text;
            string phone = txtPhone.Text;
            string doc_sp_type = comboBoxspecializedoc.Text;
            string blood = comboBoxBlood.Text;
            string doctor =txtdocid.Text;
            string oppont = comboBoxoppo.Text;
           




            if (Receptions.ss == "AddPatient")
            {
                age = Convert.ToInt32(txtAge.Text);
                if (txtName.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || txtNationalId.Text == "" || txtPhone.Text == "" || txtState.Text == "")
                    MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    age = Convert.ToInt32(txtAge.Text);


                    sql.addnewpatient(name, age, address, SSN, gender, doctor, phone, state, blood);
                    sql.set_an_appointment(oppont, doctor, dataGridView2);
                    MessageBox.Show("Successful operation", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtName.Text = ""; txtAddress.Text = ""; txtAge.Text =""; txtNationalId.Text =""; txtPhone.Text =""; txtState.Text = ""; txtdocid.Text = "";

                }
            }
            else if (Receptions.ss == "Upate Patient")
            { 
            age = Convert.ToInt32(txtAge.Text);
                Receptions re = new Receptions();
                sql.update_patient(re.txtID.Text, re.comboBoxID.Text, name, age, address, SSN, gender, doctor, phone, state, blood);
                MessageBox.Show("Successful operation", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxspecializedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql.docor_in_reception(comboBoxspecializedoc.SelectedIndex+1, dataGridView1);
            //sql.docor_in_reception1(comboBoxspecializedoc.SelectedIndex + 1, comboBoxdoctor, dataGridView1);
            //    comboBoxspecializedoc.SelectedIndex = 0;

        }

        private void comboBoxdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string doctor_name = comboBoxdoctor.Text;
            //sql.get_doctor_schield_with_name(doctor_name, dataGridView2);
            //comboBoxdoctor.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dataGridView2
            if (txtdocid.Text == "") MessageBox.Show("Please Enter Doctor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(txtdocid.Text);
                sql.get_doctor_schield_with_name(id, dataGridView2);
            }
        }
    }
}
