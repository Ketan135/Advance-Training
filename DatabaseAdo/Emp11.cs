using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.DAL;

namespace DatabaseAdo
{
    public partial class Emp11 : Form
    {
        EmpDal empdal=new EmpDal();
        public Emp11()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Name =nametextBox.Text;
            emp.Salary=Convert.ToDouble(salarytextBox.Text);
            int res = empdal.Save(emp);
            if(res == 1)
                MessageBox.Show("Inserted the record");
        }

        private void showallbutton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable(); 
            dataGridView1.DataSource= table;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
           //Emp emp=empdal.GetEmpById(Convert.ToInt32(idtextBox.Text));
        }

    }
}
