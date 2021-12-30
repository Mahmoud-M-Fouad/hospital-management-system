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
    public partial class DeleteMember : Form
    {
        mysqlclass sql = new mysqlclass();
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
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
            else employeetypeid = 2;
            // MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Manager re = new Manager();
              int id = Convert.ToInt32(re.txtID.Text);
            if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5)
            {
                sql.delete_employee(id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 2)
            {
                sql.delete_doctor(id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 3)
            {
                sql.delete_nurse(id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
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

            if (employeetypeid == 1 || employeetypeid == 4 || employeetypeid == 5)
            {
                sql.viewemployeedata(employeetypeid,id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 2)
            {
                //sql.delete_doctor(Convert.ToInt32(re.txtID.Text));
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 3)
            {
                //sql.delete_nurse(Convert.ToInt32(re.txtID.Text));
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
