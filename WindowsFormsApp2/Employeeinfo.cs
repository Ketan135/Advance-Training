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
    public partial class Employeeinfo : Form
    {
        public Employeeinfo()
        {
            InitializeComponent();
        }

        private void createfolderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Employee Info";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder already Present");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createfilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Employee Info\Information";
                if(File.Exists(path))
                {
                    MessageBox.Show("File already Present");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writetofilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idtextBox.Text);
                string name=nametextBox.Text;
                string designation=desitextBox.Text;
                double salary=Convert.ToDouble(salarytextBox.Text);
                string department = depttextBox.Text;
                FileStream fs=new FileStream(@"D:\Employee Info\Information.txt",FileMode.Create,FileAccess.Write);
                BinaryWriter bw=new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(designation);
                bw.Write(salary);
                bw.Write(department);
                bw.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void readfromfilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Employee Info\Information.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br=new BinaryReader(fs);
                idtextBox.Text = br.ReadInt32().ToString();
                nametextBox.Text = br.ReadString();
                desitextBox.Text = br.ReadString();
                salarytextBox.Text = br.ReadDouble().ToString();
                depttextBox.Text = br.ReadString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
