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
  
    public partial class Delete_Update : Form
    {
        Class1 cls = new Class1();
        public Delete_Update()
        {
            InitializeComponent();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls.methodSetInteger(e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
