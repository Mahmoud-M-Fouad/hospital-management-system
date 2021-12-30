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
    public partial class mamdohsearch : Form
    {
        mysqlclass sql = new mysqlclass();
        public mamdohsearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            //sql.get_doc_few_data(id,dataGridView1);
        }
    }
}
