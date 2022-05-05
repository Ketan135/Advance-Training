using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            string a=NametextBox.Text;
            string b=ContacttextBox.Text;
            string c=AddresstextBox.Text;
            string d=EmailtextBox.Text;

            lblOutput.Text = a + "   "+b+   "    " +c+  "   "   +d;

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
    }
}
