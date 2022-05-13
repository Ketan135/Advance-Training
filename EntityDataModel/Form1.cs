using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDataModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ApplicationEntities dbcontext = new ApplicationEntities();
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Emp emp = new Emp();
                emp.Name = nametextBox.Text;
                emp.Salary = Convert.ToDecimal(salarytextBox.Text);
                dbcontext.Emps.Add(emp);
                dbcontext.SaveChanges();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Emp1 emp = dbcontext.Emp1.Find(Convert.ToInt32(idtextBox.Text));
                if (emp != null)
                {
                    nametextBox.Text = emp.Name;
                    salarytextBox.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Emp1 emp = dbcontext.Emp1.Find(Convert.ToInt32(idtextBox.Text));
                if (emp != null)
                {
                    emp.Name=nametextBox.Text;
                    emp.Salary=Convert.ToDecimal(salarytextBox.Text);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {   
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Emp1 emp = dbcontext.Emp1.Find(Convert.ToInt32(idtextBox.Text));
                if (emp != null)
                {
                    emp.Name = nametextBox.Text;
                    emp.Salary = Convert.ToDecimal(salarytextBox.Text);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Emp1.ToList();
        }
    }
}

