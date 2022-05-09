using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseAdo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=LAPTOP-JDUH5VP0\SQLEXPRESS06;database=FirstDatabase;Integrated Security=True");

        }
        public void ClearAll()
        {
            idtextBox.Clear();
            nametextBox.Clear();
            pricetextBox.Clear();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into Product values(@id,@name,@price)";
                cmd=new SqlCommand(qry,con);    
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(idtextBox.Text));
                cmd.Parameters.AddWithValue("@name",nametextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetextBox.Text));
                con.Open();
                int res=cmd.ExecuteNonQuery();
                if(res == 1)
                {
                    MessageBox.Show("Record Inserted");
                    idtextBox.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();    
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Product where Id=@id";
                cmd= new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idtextBox.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        nametextBox.Text = dr["Name"].ToString();
                        pricetextBox.Text=dr["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set Name=@name,Price=@price where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idtextBox.Text));
                cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetextBox.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Updated");
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idtextBox.Text));
                cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetextBox.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(Id) from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj=cmd.ExecuteScalar();
                if(obj==DBNull.Value)
                {
                    idtextBox.Text = "1";
                }
                else
                {
                    int id=Convert.ToInt32(obj);
                    id++;
                    idtextBox.Text = id.ToString();
                }
                idtextBox.Enabled = false;
                nametextBox.Clear();
                pricetextBox.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Product";
                cmd = new SqlCommand(qry, con);
                
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            idtextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nametextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            pricetextBox.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }
    }
}
