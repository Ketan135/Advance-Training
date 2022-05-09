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

namespace WindowsFormsApp2
{
    public partial class Batchinfo : Form
    {
        public Batchinfo()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            string a = idtextBox.Text;
            string b = nametextBox.Text;
            string c = starttextBox.Text;
            string d = endtextBox.Text;
            string f=trainertextBox.Text;
            string g = locationtextBox.Text;


            l1.Text = a + "   " + b + "    " + c + "   " + d;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            l1.Text = "";
        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Batch b1= new Batch();
                b1.Id = Convert.ToInt32(idtextBox.Text);
                b1.Name = nametextBox.Text;
                b1.Start =starttextBox.Text;
                b1.End = endtextBox.Text;
                b1.Trainer = trainertextBox.Text;
                b1.Location = locationtextBox.Text;
                FileStream fs = new FileStream(@"D:\Employee Info\batchinformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, b1);
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
                Batch b1= new Batch();

                FileStream fs = new FileStream(@"D:\Employee Info\batchinformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                idtextBox.Text = b1.Id.ToString();
                nametextBox.Text = b1.Name;
                starttextBox.Text = b1.Start.ToString();
                endtextBox.Text = b1.End.ToString();
                trainertextBox.Text = b1.Trainer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
