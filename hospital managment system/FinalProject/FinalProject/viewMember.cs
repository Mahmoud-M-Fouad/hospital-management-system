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
    public partial class viewMember : Form
    {
        mysqlclass sql = new mysqlclass();
        
        public viewMember()
        {
            InitializeComponent();

            if (Manager.i == 1 || Manager.i == 4 || Manager.i == 5)
            {

                sql.viewemployee(Manager.i, data);

            }
            else if (Manager.i == 2)
            {

                sql.viewdoctor(data);

            }
            else if (Manager.i == 3)
            {
                sql.viewnurse(data);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(data.CurrentRow.Cells[0].Value.ToString());
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
                sql.viewemployeedata(employeetypeid, id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 2)
            {
                sql.viewdoctordata(id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (employeetypeid == 3)
            {
                sql.viewnursedata(id);
                MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
