using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FinalProject
{
    public partial class StartProject : Form
    {
        string s = ".";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
            int nleftRect, int ntopRect, int RightRect, int nBottomRect, int nwidthEllipse, int nhightEllips
            );
        public StartProject()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            t.Text = "" + DateTime.Now;
            guna2CircleProgressBar1.Value = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Increment(2);
            s += ".";
            label2.Text =guna2CircleProgressBar1.Value.ToString() + "%";
            labelLoad.Text = s + ".";
            if (guna2CircleProgressBar1.Value == 30) s = "";
            if (guna2CircleProgressBar1.Value == 50) s = "";
            if (guna2CircleProgressBar1.Value == 70) s = "";
            if (guna2CircleProgressBar1.Value == 90) s = "";

            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            }

        private void StartProject_Load(object sender, EventArgs e)
        {

        }

        private void labelMark_Click(object sender, EventArgs e)
        {

        }
    }
}
