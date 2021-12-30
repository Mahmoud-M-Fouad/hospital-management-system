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
    public partial class AddMember : Form
    {
        string user = "";
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
       
        public AddMember()
        {
            InitializeComponent();
        
            comboBoxYear.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;
            comboBoxDay.SelectedIndex = 0;
            comboBoxSection.SelectedIndex = 0;
            comboBoxGraduation.SelectedIndex = 0;


        }

        private void btnPicture_Click(object sender, EventArgs e)
        {

        }

        private void radioSome_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSome.Checked)
                checkedListBox.Enabled = true;
            else
                checkedListBox.Enabled = false;

        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAll.Checked)
                checkedListBox.Enabled = false;
            else
                checkedListBox.Enabled = true;

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetLatter(e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetLatter(e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPicture_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images Files |*.JPG; *.PNG; *.GIF";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            int age ;
            string city = txtCity.Text;
            string country = txtCountry.Text;
            string phone_number = txtPhone.Text;
            string SSN = txtNationalId.Text;
            string gender = "";
            if (Male.Checked == true)
                gender = "Male";
            else gender = "Female";
            double sallary ;
            int specialize_id = comboBoxSection.SelectedIndex;
            int num_of_days_of_work = 0;
            string days_of_work = "";
            if (radioAll.Checked == true)
            {
                num_of_days_of_work = 7;
                days_of_work = "Saturday Sunday Monday Tuesday Wednesday Thursday Friday";
            }
            else
            {
                num_of_days_of_work = checkedListBox.CheckedIndices.Count;
                days_of_work = "";
                for (int i = 0; i < num_of_days_of_work; i++)
                {
                    days_of_work += checkedListBox.CheckedItems[i].ToString() + " ";
                }
            }
            string year = comboBoxYear.Text;
            string month = comboBoxMonth.Text;
            string day = comboBoxDay.Text;
            string date_of_employee = year + "-" + month + "-" + day;
            string img = pictureBox1.ImageLocation;
            string login_username = txtUserName.Text;
            string mail = txtMail.Text;
            int Year_of_graduation;

            int employeetypeid = 0;


            if (Manager.aq == "Acountants")
            {
                employeetypeid = 1; 
            }
            else if (Manager.aq == "Doctor")
                employeetypeid = 2;
            else if (Manager.aq == "Nurses")
                employeetypeid = 3;
            else if (Manager.aq == "Pharmacy")
                employeetypeid = 4;
            else if (Manager.aq == "Reception")
                employeetypeid = 5;
            else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            if (sql.get_update_or_add() == "Add")
            {
                if (txtMail.Text == "" || txtName.Text == "" || txtCountry.Text == "" || txtAge.Text == "" || txtNationalId.Text == "" || txtPhone.Text == "" || txtSalary.Text == "")
                    MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    age = Convert.ToInt32(txtAge.Text);
                    sallary = Convert.ToDouble(txtSalary.Text);
                    Year_of_graduation = Convert.ToInt32(comboBoxGraduation.Text);
                    if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5)
                    {
                        sql.addnewemployee(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, date_of_employee, img, user, mail, phone_number, employeetypeid);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMail.Text = ""; txtName.Text = ""; txtUserName.Text=""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text ="";
                    }
                    else if (employeetypeid == 2)
                    {
                        sql.addnewdoctor(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, Year_of_graduation, date_of_employee, img, user, mail, phone_number);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMail.Text = ""; txtName.Text = ""; txtUserName.Text = ""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text = "";
                    }
                    else if (employeetypeid == 3)
                    {
                        sql.addnewnurse(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, Year_of_graduation, date_of_employee, img, user, mail, phone_number);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMail.Text = ""; txtName.Text = ""; txtUserName.Text = ""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text = "";
                    }
                    }

                }


            
                else if(sql.get_update_or_add() == "Update")
            {
                age = Convert.ToInt32(txtAge.Text);
                sallary = Convert.ToDouble(txtSalary.Text);
                Year_of_graduation = Convert.ToInt32(comboBoxGraduation.Text);
                if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5)
                {
                    sql.addnewemployee(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, date_of_employee, img, login_username, mail, phone_number, employeetypeid);
                    MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMail.Text = ""; txtName.Text = ""; txtUserName.Text = ""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text = "";
                }
                else if (employeetypeid == 2)
                {
                    sql.addnewdoctor(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, Year_of_graduation, date_of_employee, img, login_username, mail, phone_number);
                    MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMail.Text = ""; txtName.Text = ""; txtUserName.Text = ""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text = "";
                }
                else if (employeetypeid == 3)
                {
                    sql.addnewnurse(name, age, city, country, SSN, gender, sallary, specialize_id, days_of_work, num_of_days_of_work, Year_of_graduation, date_of_employee, img, login_username, mail, phone_number);
                    MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMail.Text = ""; txtName.Text = ""; txtUserName.Text = ""; txtCountry.Text = ""; txtCity.Text = ""; txtAge.Text = ""; txtNationalId.Text = ""; txtPhone.Text = ""; txtSalary.Text = "";
                }
            }
            


            
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text == "" || txtPass2.Text == "" || txtUserName.Text == "")

                MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtPass2.Text != txtPass1.Text)
                    MessageBox.Show("The Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string username = txtUserName.Text;
                    this.user = username;
                    string password = txtPass1.Text;
                    string dept = Manager.aq;
                    sql.addnewlogin(username, password, dept);
                    MessageBox.Show("Successful operation", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtPass1.Text = ""; txtPass2.Text = ""; txtUserName.Text = "";
                }
            }
        }

        private void btn2show_Click(object sender, EventArgs e)
        {
            if (txtPass2.PasswordChar == '\0')
                btn2Unshow.BringToFront();
            txtPass2.PasswordChar = '*';
        }

        private void unshow_Click(object sender, EventArgs e)
        {
            if (txtPass1.PasswordChar == '*')


                show.BringToFront();
            txtPass1.PasswordChar = '\0';
        }

        private void btn2Unshow_Click(object sender, EventArgs e)
        {
            if (txtPass2.PasswordChar == '*')


                btn2show.BringToFront();
            txtPass2.PasswordChar = '\0';
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (txtPass1.PasswordChar == '\0')
                unshow.BringToFront();
            txtPass1.PasswordChar = '*';
        }

        

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void comboBoxSection_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGraduation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
