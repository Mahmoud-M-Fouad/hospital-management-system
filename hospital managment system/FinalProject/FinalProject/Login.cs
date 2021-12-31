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
    public partial class Login : Form
    {
        public static string Log;
        public static string use="";
        Class1 cls = new Class1();
        mysqlclass sql = new mysqlclass();
        string s = "Welcome As ", login;
        public Login()
        {
            InitializeComponent();
            
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
           /* toolTip1.Show("Login", btnLogin);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;

            toolTip1.BackColor = Color.Yellow;*/
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
           
           //cls.methodToolTipTextBox(toolTip1, "Enter User Name",txtUsername);
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
         
          cls.methodToolTipTextBox(toolTip1, "Enter Your Password", txtUsername);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void show_Click(object sender, EventArgs e)
        {
           // cls.methodToolTipButton(toolTip1, "Show Password", unshow);

            if (txtPassword.PasswordChar == '\0')
                unshow.BringToFront();
            txtPassword.PasswordChar = '*';

        }

        private void unshow_Click(object sender, EventArgs e)
        {
            //cls.methodToolTipButton(toolTip1, "UnShow Password", show);

            if (txtPassword.PasswordChar == '*')
               

            show.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void show_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {

            login = "Manager";
            label.Text =" "+ s + btnManager.Text;
           panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\Manag.png");
            panelLogin.Visible = true;
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            login = "Reception";
            label.Text = " " + s + btnReception.Text;
            panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\Rece.png");
            panelLogin.Visible = true;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            login = "Doctor";
            label.Text = " " + s + btnDoctor.Text;
            panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\Doc.png");
            panelLogin.Visible = true;
        }

        private void btnNurses_Click(object sender, EventArgs e)
        {
            login = "Nurses";
           
            label.Text =  " " + s + btnNurses.Text;
            panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\Nurs.png");
            panelLogin.Visible = true;
        }

        private void btnAcountants_Click(object sender, EventArgs e)
        {
            login = "Acountants";
            label.Text =  " " + s + btnAcountants.Text;
            panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\Acco.png");
            panelLogin.Visible = true;
        }

        private void btnpharmacy_Click(object sender, EventArgs e)
        {
            login = "pharmacy";
            label.Text =  " " + s + btnpharmacy.Text;
            panelLogin.Enabled = true;
            this.pictureBoxLogin.Image = Image.FromFile(@"G:\E_study\ProjectGitHub\hospital-management-system\hospital managment system\Icon\New folder\phar.png");
            panelLogin.Visible = true;
        }

        private void txtUsername_MouseUp(object sender, MouseEventArgs e)
        {
            cls.methodToolTipTextBox(toolTip1, "Enter User Name", txtUsername);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text==""&&txtUsername.Text=="") MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string username = txtUsername.Text;
                use = username;
                string password = txtPassword.Text;

                sql.login(username, password, login, this);
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.methodPanelWidth(panel3, 0, 220);
        }
    }
}
