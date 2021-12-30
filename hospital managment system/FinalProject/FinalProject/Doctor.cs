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
    public partial class Doctor : Form
    {
        mysqlclass sql = new mysqlclass();
        Login l;
        public Doctor()
        {
            InitializeComponent();
            sql.all_patients(dataGridView1);
           
            //MessageBox.Show(Login.use);
            //sql.get_doc_Schield(Login.use, dataGridView1);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
