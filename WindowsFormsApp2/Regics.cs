using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApp2
{
    public partial class Regics : Form
    {
        
        public Regics()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            string a = nametextBox.Text;
            string b = contacttextBox.Text;
            string c = addresstextBox.Text;
            string d = emailtextBox.Text;

            label.Text = a + "   " + b + "    " + c + "   " + d;

        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Name = nametextBox.Text;
                dept.Email = emailtextBox.Text;
                dept.Contact = Convert.ToInt64(contacttextBox.Text);
                dept.Address = addresstextBox.Text;
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
                nametextBox.Text = dept.Name;
                emailtextBox.Text = dept.Email;
                contacttextBox.Text = dept.Contact.ToString();
                addresstextBox.Text = dept.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlwritebutton_Click(object sender, EventArgs e)
        {

            try
            {
                Department dept = new Department();
                dept.Name = nametextBox.Text;
                dept.Email = emailtextBox.Text;
                dept.Contact = Convert.ToInt64(contacttextBox.Text);
                dept.Address = addresstextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\xmlinformation",FileMode.Create,FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                MessageBox.Show("Done");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlreadbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\Employee Info\xmlinformation", FileMode.Open, FileAccess.Read);
                XmlSerializer xml= new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                nametextBox.Text = dept.Name;
                emailtextBox.Text = dept.Email;
                contacttextBox.Text = dept.Contact.ToString();
                addresstextBox.Text = dept.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapwritebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Name = nametextBox.Text;
                dept.Email = emailtextBox.Text;
                dept.Contact = Convert.ToInt64(contacttextBox.Text);
                dept.Address = addresstextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\soapinformation2", FileMode.Create, FileAccess.Write);
                SoapFormatter soap= new SoapFormatter();
                soap.Serialize(fs, dept);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapreadbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\Employee Info\soapinformation2", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                nametextBox.Text = dept.Name;
                emailtextBox.Text = dept.Email;
                contacttextBox.Text = dept.Contact.ToString();
                addresstextBox.Text = dept.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            label.Text = "";
        }

        private void jsonbutton_Click(object sender, EventArgs e)
        {
                try
                {
                    Department dept = new Department();
                    dept.Name = nametextBox.Text;
                    dept.Email = emailtextBox.Text;
                    dept.Contact =Convert.ToInt32(contacttextBox.Text);
                    dept.Address = addresstextBox.Text;
                  
                   FileStream fs = new FileStream(@"D:\Employee Info\jsonInformation", FileMode.Create, FileAccess.Write);
                   JsonSerializer.Serialize(fs, dept);
                    MessageBox.Show("Done");
                    fs.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

        private void jsonreadbutton_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Department dept = new Department();
                    FileStream fs = new FileStream(@"D:\Employee Info\EmployeeJson", FileMode.Open, FileAccess.Read);
                    dept = JsonSerializer.Deserialize<Department>(fs);               //change here. 
                    nametextBox.Text = dept.Name;
                    emailtextBox.Text = dept.Email;
                    contacttextBox.Text = dept.Contact.ToString();
                    addresstextBox.Text = dept.Address;
                fs.Close ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
}
    

