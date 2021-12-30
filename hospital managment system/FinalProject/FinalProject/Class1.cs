using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace FinalProject
{
    class Class1
    {
        public void methodToolTipButton(ToolTip t, string s, Button b)
        {
            t.Show(s, b);
            t.OwnerDraw = true;
            t.ForeColor = Color.Red;

            t.BackColor = Color.Yellow;
        }
        public void methodToolTipTextBox(ToolTip t, string s, TextBox b)
        {
            t.Show(s, b);
            t.OwnerDraw = true;
            t.ForeColor = Color.Red;

            t.BackColor = Color.Yellow;
        }
        public void methodPanelHeight(Panel p, int size1, int size2)
        {
            if (p.Height == size1)
            {
                while (p.Height < size2)
                    p.Height += 1;
            }
            else
            {

                while (p.Height > size1)
                    p.Height -= 1;
            }
        }
        public void methodPanelWidth(Panel p, int size1, int size2)
        {
            if (p.Width == size1)
            {
                while (p.Width < size2)
                    p.Width += 1;
            }
            else
            {

                while (p.Width > size1)
                    p.Width -= 1;
            }
        }
        public void methodSetForm(Panel p, Form f)
        {
            p.Controls.Clear();

            f.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Add(f);
            f.Show();

        }
        public bool methodSetMessage(string s, string c)
        {


            DialogResult result = MessageBox.Show("Want " + s + c, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }
        public void methodSetInteger(KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void methodSetLatter(KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
