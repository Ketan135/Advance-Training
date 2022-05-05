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

    public partial class FileIo : Form
    {
        FileStream fs;
        public FileIo()
        {
            InitializeComponent();
        }

        private void createfolderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\NewFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder already exist");
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

        private void createfilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\NewFolder\FirstFile";
                if (File.Exists(path))
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
                int id = Convert.ToInt32(depttextBox.Text);
                string name = nametextBox.Text;
                string location = locationtextBox.Text;
                FileStream fs = new FileStream(@"D:\NewFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
             fs.Close();
            }

        }

        private void readfromfilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\NewFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                depttextBox.Text = br.ReadInt32().ToString();
                nametextBox.Text = br.ReadString();
                locationtextBox.Text = br.ReadString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                fs.Close();
            }
        }
    }
}

