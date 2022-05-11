using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAdo
{
    public partial class Empdetail : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Empdetail()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con=new SqlConnection(constr);
        }
        public DataSet GetEmps()
        {
            da = new SqlDataAdapter("select * from Empdetail1", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "emp");
            return ds;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            DataRow row = ds.Tables["emp"].NewRow();
            row["Name"] = nametextBox.Text;
            row["Salary"] = salarytextBox.Text;
            ds.Tables["emp"].Rows.Add(row);
            int res = da.Update(ds.Tables["emp"]);
            if (res == 1)
                MessageBox.Show("Record saved");
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(idtextBox.Text));
            if (row != null)
            {
                nametextBox.Text = row["Name"].ToString();
                salarytextBox.Text = row["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            double sal = Convert.ToDouble(salarytextBox.Text);
            if (string.IsNullOrEmpty(nametextBox.Text) && sal > 0)
            {
                MessageBox.Show("Enter name or salary should be greater than 0");
            }
            else
            {
                ds = GetEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(idtextBox.Text));
                if (row != null)
                {
                    row["Name"] = nametextBox.Text;
                    row["Salary"] = salarytextBox.Text;
                    int res = da.Update(ds.Tables["emp"]);
                    if (res == 1)
                        MessageBox.Show("Record updated");
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(idtextBox.Text));
            if (row != null)
            {
                row.Delete();
                int res = da.Update(ds.Tables["emp"]);
                if (res == 1)
                    MessageBox.Show("Record deleted");
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}

