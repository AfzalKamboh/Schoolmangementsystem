using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWorkProject
{
    public partial class resultform : UserControl
    {
        string[] arraydata;
        SqlConnection connection;
        public resultform()
        {
            InitializeComponent();
            string[] combolist = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            foreach(string co in combolist)
            {
                comboBox1.Items.Add(co);
            }
            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            connection = new SqlConnection(connectionpath);
            connection.Open();
            DataTable schema = connection.GetSchema("Tables");
            
            foreach (DataRow row in schema.Rows)
            {
                listBox1.Items.Add(row[2].ToString());


            }
            connection.Close();
        }
        bool flag = false;
        private void btnresultinsert_Click(object sender, EventArgs e)
        {
            string seletedvalue = comboBox1.SelectedItem.ToString();
            var valued = txtyear.Text;
            string finalname = "db_" + seletedvalue + valued;
            if (listBox1.Items.Contains(finalname))
            {
                //MessageBox.Show("TAble is available");
                
                int k = 0;
                for (int a = 0; a < dataGridView1.Rows.Count - 1; a++)
                {
                    SqlCommand commandd = new SqlCommand("INSERT INTO " + finalname + "(firstname,lastname,TotalMarks,ObtainedMarks) Values ('" + dataGridView1.Rows[a].Cells[0].Value + "','" + dataGridView1.Rows[a].Cells[1].Value + "','" + dataGridView1.Rows[a].Cells[2].Value + "','" + dataGridView1.Rows[a].Cells[3].Value + "')", connection);
                    connection.Open();
                    k = commandd.ExecuteNonQuery();
                    connection.Close();
                    
                    if (k != 0)
                    {
                        MessageBox.Show("Data is inserted");
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed");
                    }

                }
            }
            else
            {
                listBox1.Items.Add(finalname);
                SqlCommand command1 = new SqlCommand("CREATE TABLE " + finalname + "" +
                                  "(firstname CHAR(50), lastname CHAR(50), TotalMarks INT, ObtainedMarks FLOAT)", connection);
                connection.Open();
                int i = command1.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    int zzz = 0;
                    MessageBox.Show("Table is Created");
                    for(int kk=0;kk<dataGridView1.Rows.Count;kk++)
                    {
                        SqlCommand commandd = new SqlCommand("INSERT INTO " + finalname + "(firstname,lastname,TotalMarks,ObtainedMarks) Values ('" + dataGridView1.Rows[kk].Cells[0].Value + "','" + dataGridView1.Rows[kk].Cells[1].Value + "','" + dataGridView1.Rows[kk].Cells[2].Value + "','" + dataGridView1.Rows[kk].Cells[3].Value + "')", connection);
                        connection.Open();
                        zzz = commandd.ExecuteNonQuery();
                        connection.Close();
                        
                    }
                    connection.Close();
                    if (zzz != 0)
                    {
                        MessageBox.Show("Data is inserted");
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Table Failed");
                }
               

            }
          
        }

        private void btnfortable_Click(object sender, EventArgs e)
        {

        }
    }
}
