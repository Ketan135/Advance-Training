using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void writebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept=new Department();
                dept.Name = NametextBox.Text;
                dept.Email=EmailtextBox.Text;
                dept.Contact= Convert.ToInt64(ContacttextBox.Text);
                dept.Address=AddresstextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\information2", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
               
                FileStream fs = new FileStream(@"D:\Employee Info\information2", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                NametextBox.Text = dept.Name; 
                EmailtextBox.Text=dept.Email;
                ContacttextBox.Text=dept.Contact.ToString();
                AddresstextBox.Text=dept.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
