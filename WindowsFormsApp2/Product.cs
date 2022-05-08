using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            string a = idtextBox.Text;
            string b = nameetextBox.Text;
            string c = pricetextBox.Text;
            string d = categorytextBox.Text;

            label1.Text = a + "   " + b + "    " + c + "   " + d;

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void binarywritebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Pro p1 = new Pro();
                p1.Id = Convert.ToInt32(idtextBox.Text);
                p1.Name =nameetextBox.Text;
                p1.Price = Convert.ToInt32(pricetextBox.Text);
                p1.Catagory = categorytextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\productinformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs,p1);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void binaryreadbutton_Click(object sender, EventArgs e)
        {

            try
            {
                Pro p1 = new Pro();

                FileStream fs = new FileStream(@"D:\Employee Info\productinformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                idtextBox.Text= p1.Id.ToString();
                nameetextBox.Text=p1.Name;
                pricetextBox.Text = p1.Price.ToString();
                categorytextBox.Text = p1.Catagory;
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
                Pro p1= new Pro();
                p1.Id = Convert.ToInt32(idtextBox.Text);
                p1.Name = nameetextBox.Text;
                p1.Price = Convert.ToInt32(pricetextBox.Text);
                p1.Catagory=categorytextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\xmlproductinformation", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Pro));
                xml.Serialize(fs, p1);
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
                Pro p1 = new Pro();

                FileStream fs = new FileStream(@"D:\Employee Info\xmlproductinformation", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                p1 = (Pro)xml.Deserialize(fs);
                idtextBox.Text = p1.Id.ToString();
                nameetextBox.Text = p1.Name;
                pricetextBox.Text = p1.Price.ToString();
                categorytextBox.Text = p1.Catagory;
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
                Pro p1 = new Pro();
                p1.Id = Convert.ToInt32(idtextBox.Text);
                p1.Name = nameetextBox.Text;
                p1.Price = Convert.ToInt32(pricetextBox.Text);
                p1.Catagory = categorytextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\soapproductinformation", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, p1);
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
                Pro p1= new Pro();

                FileStream fs = new FileStream(@"D:\Employee Info\soapproductinformation", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                idtextBox.Text = p1.Id.ToString();
                nameetextBox.Text = p1.Name;
                pricetextBox.Text = p1.Price.ToString();
                categorytextBox.Text = p1.Catagory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonwritebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Pro p1= new Pro();
                p1.Id = Convert.ToInt32(idtextBox.Text);
                p1.Name = nameetextBox.Text;
                p1.Price = Convert.ToInt32(pricetextBox.Text);
                p1.Catagory = categorytextBox.Text;

                FileStream fs = new FileStream(@"D:\Employee Info\jsonproductInformation", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, p1);
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
                Pro p1 = new Pro();
                FileStream fs = new FileStream(@"D:\Employee Info\jsonproductinformation", FileMode.Open, FileAccess.Read);
                p1 = JsonSerializer.Deserialize<Pro>(fs);               //change here. 
                idtextBox.Text = p1.Id.ToString();
                nameetextBox.Text = p1.Name;
                pricetextBox.Text = p1.Price.ToString();
                categorytextBox.Text = p1.Catagory;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
