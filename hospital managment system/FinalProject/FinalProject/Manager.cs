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
   
    public partial class Manager : Form
    {
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
        public static string aq="";
        public static string section="";
        AddMember addmember;
        DeleteMember de_upMember;
        public static string s,c;
        public static int  i;
        Login l;
        public Manager()
        {
            InitializeComponent();
            c = "";
            comboBoxID.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            cls.methodPanelHeight(panelSection, 55, 490);
            if(panelOperation.Height== 380)
            cls.methodPanelHeight(panelOperation, 62, 380);
            if (panelMember.Height == 377)
                cls.methodPanelHeight(panelMember, 57, 377);
        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            cls.methodPanelHeight(panelOperation, 62, 380);
            if (panelSection.Height == 490)
                cls.methodPanelHeight(panelSection, 55, 490);
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.methodPanelHeight(panelMember, 57, 377);
            if (panelSection.Height == 490)
                cls.methodPanelHeight(panelSection, 55, 490);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            groupBox.Visible = false;
            if (cls.methodSetMessage("Add a New ", c))
            {
                addmember = new AddMember();
                addmember.Text = "Add a New " + c;
                addmember.ShowDialog();
                
                s = "Add";
                sql.set_update_or_add(s);
            }
           
        }

        private void btnUpate_Click(object sender, EventArgs e)
        {
            label1.Text = "Update a " + c;
            groupBox.Visible = true;
            s = "Update";
            sql.set_update_or_add(s);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            label1.Text = "Delete a " + c;
            groupBox.Visible = true;

            s = "Delete";
            

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Search about " + c;
            groupBox.Visible = true;
            s = "Search";

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                MessageBox.Show("Please Enter " + comboBoxID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

            
                if (s == "Delete")
                {
                  

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

                    int id = Convert.ToInt32(txtID.Text);
                    if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5)
                    {
                        sql.delete_employee(id);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                    }
                    else if (employeetypeid == 2)
                    {
                        sql.delete_doctor(id);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                    }
                    else if (employeetypeid == 3)
                    {
                        sql.delete_nurse(id);
                        MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                    }




                }
                if (s == "Search")
                {

                    if (aq == "Acountants")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        sql.get_employee_few_data(id);
                    
                        txtID.Text = "";

                    }
                    else if (aq == "Doctor")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        
                        sql.get_doc_few_data(id);
                   
                        txtID.Text = "";
                    }

                    else if (aq == "Nurses")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        sql.get_nurse_few_data(id);
                        
                        txtID.Text = "";
                    }
                    else if (aq == "Pharmacy")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        sql.get_employee_few_data(id);
                     
                        txtID.Text = "";
                    }
                    else if (aq == "Reception")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        sql.get_employee_few_data(id);
                  
                        txtID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Text = "";
                    }
                        

                }
            }

        }

        private void btnNurses_Click(object sender, EventArgs e)
        {
            c = "Nurses";
            panelOperation.Visible = true;
            aq= "Nurses";

        }

        private void btnAcountants_Click(object sender, EventArgs e)
        {
            c = "Acountants";
            panelOperation.Visible = true;
            aq = "Acountants";
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            c = "Doctor";
            panelOperation.Visible = true;
            aq = "Doctor";
        }
        DeleteMember d = new DeleteMember();
        private void button12_Click(object sender, EventArgs e)
        {
            
       
            section = "الباطنة";
            
            sql.viewallemployee_withsection(section,this);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            section = "النسا والتوليد";
            sql.viewallemployee_withsection(section, this);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            section = "العظام";
            sql.viewallemployee_withsection(section, this);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            section = "انف واذن وحنجره";
            sql.viewallemployee_withsection(section, this);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            section = "عيون";
            sql.viewallemployee_withsection(section, this);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            section = "الجراحه";
            sql.viewallemployee_withsection(section, this);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            section = "الجلديه";
            sql.viewallemployee_withsection(section, this);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            section = "مخ واعصاب";
            sql.viewallemployee_withsection(section, this);
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

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "View All About " + c;


            i = 0;


            if (Manager.aq == "Acountants")
            {
                i = 1;
                viewMember w = new viewMember();
                w.ShowDialog();
            }
            else if (Manager.aq == "Doctor")
            {
                i = 2;
                viewMember w = new viewMember();
                w.ShowDialog();
            }
              
            else if (Manager.aq == "Nurses")
            {
                i = 3;
                viewMember w = new viewMember();
                w.ShowDialog();
            }
            else if (Manager.aq == "Pharmacy")
            {
                i = 4;
                viewMember w = new viewMember();
                w.ShowDialog();
            }
            else if (Manager.aq == "Reception")
            {
                i = 5;
                viewMember w = new viewMember();
                w.ShowDialog();
            }
            else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

           // SearchMember w = new SearchMember();
           


        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = "Pharmacy";
            panelOperation.Visible = true;
            aq = "Pharmacy";
        }

        private void panelOperation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            c = "Reception";
            panelOperation.Visible = true;
            aq = "Reception";
        }
    }
}
