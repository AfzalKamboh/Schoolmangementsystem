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
    public partial class homepage : UserControl
    {
        public homepage()
        {
            InitializeComponent();


            totalteacherdata();
            totalstudentlb();
            totalfeepaidd();
            tableforchart();

        }
        int numbers = 0;
        private void tableforchart()
        {


            string don = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection con = new SqlConnection(don);
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select feemonth,totalfee from stdfeetable", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["FeeChart"].XValueMember = "feemonth";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["FeeChart"].YValueMembers = "totalfee";
            chart1.Titles.Add("FeeChart");
            con.Close();

        }

        private void totalfeepaidd()
        {
            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection connection = new SqlConnection(connectionpath);
            SqlCommand command = new SqlCommand();

            connection.Open();
            string queryd = "SELECT sum(totalfee) FROM stdfeetable";
            try
            {
                command = new SqlCommand(queryd, connection);
                Int32 rowscount = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                feelbl.Text = rowscount.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data not Found");
            }
        }

        private void totalstudentlb()
        {
            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection connection = new SqlConnection(connectionpath);
            SqlCommand command = new SqlCommand();

            connection.Open();
            string queryd = "SELECT COUNT(firstname) FROM StudentInformation";
            try
            {
                command = new SqlCommand(queryd, connection);
                Int32 rowscount = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                lbltotalstudentsco.Text = rowscount.ToString();
                lbltotalparentsc.Text = rowscount.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data not Found");
            }
        }

        private void totalteacherdata()
        {

            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection connection = new SqlConnection(connectionpath);
            SqlCommand command = new SqlCommand();

            connection.Open();
            string queryd = "SELECT COUNT(fname) FROM TeacherInformation";
            try
            {
                command = new SqlCommand(queryd, connection);
                Int32 rowscount = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                lbltotalteachersc.Text = rowscount.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Data not Found");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image=imageList1.Images[numbers];
            if(numbers==imageList1.Images.Count)
            {
                numbers=0;
            }
            else
            {
                numbers++;
            }
        }
    }
}
