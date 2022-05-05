using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Studentinfo : Form
    {
        public Studentinfo()
        {
            InitializeComponent();
        }

        private void createfolderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Student Info";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ceatefilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Student Info\Information";
                if(File.Exists(path))
                {
                    MessageBox.Show("File already exist");
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
                int rollno=Convert.ToInt32(rollnotextBox.Text);
                string name=nametextBox.Text;
                float percentage=Convert.ToSingle(percentagetextBox.Text);
                string stream=streamtextBox.Text;
                string city=citytextBox.Text;
                FileStream fs=new FileStream(@"D:\Student Info\Information.txt",FileMode.Create,FileAccess.Write);
                BinaryWriter bw=new BinaryWriter(fs);
                bw.Write(rollno);
                bw.Write(name);
                bw.Write(percentage);
                bw.Write(stream);
                bw.Write(city);
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
                FileStream fs = new FileStream(@"D:\Student Info\Information.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br=new BinaryReader(fs);
                rollnotextBox.Text=br.ReadInt32().ToString();
                nametextBox.Text=br.ReadString();
                percentagetextBox.Text=br.ReadSingle().ToString();
                streamtextBox.Text=br.ReadString();
                citytextBox.Text=br.ReadString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
