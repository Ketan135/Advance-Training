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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult result = fontDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if( result == DialogResult.OK )
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = ".txt";
                sd.Filter = "Text Doc(*.txt)|*.txt|Word(*.docx)|*.docx";
                DialogResult result = sd.ShowDialog();
                if( (result == DialogResult.OK) )
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "Text Doc(*.txt)|*.txt|Word(*.docx)|*.docx";
                DialogResult result = od.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.message");
            }

        }
    }
}
