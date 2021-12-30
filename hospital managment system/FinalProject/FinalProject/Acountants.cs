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
    public partial class Acountants : Form
    {
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
        Login l;
        public Acountants()
        {
            InitializeComponent();
            comboBoxEmployeeType.SelectedIndex = 0;
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

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text=="")
                MessageBox.Show("Please Enter "+ comboBoxEmployeeType.Text+"ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int employeetypeid = comboBoxEmployeeType.SelectedIndex + 1;
                sql.updatesallary(employeetypeid, id);
                labelSalary.Text = "";
            }
        }

      

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void comboBoxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int employeetypeid = comboBoxEmployeeType.SelectedIndex+1;
            if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5 || employeetypeid == 6)
            {
                string s = textBoxID.Text;
                int id = Convert.ToInt32(s);
                sql.viewemployeeforaccount(employeetypeid, dataGridView1);
            }
               
            else if (employeetypeid == 2)

            {
                int id = Convert.ToInt32(textBoxID.Text);
                sql.viewdoctorforaccount(dataGridView1);
            }
                
            else if (employeetypeid == 3)
            {
                int id = Convert.ToInt32(textBoxID.Text);
                sql.viewnurseforaccount(dataGridView1);
            }
                
            else MessageBox.Show("something is wrong");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            int employeetypeid = comboBoxEmployeeType.SelectedIndex + 1;
            sql.getsallary(employeetypeid, id, labelSalary);
        }
    }
}
