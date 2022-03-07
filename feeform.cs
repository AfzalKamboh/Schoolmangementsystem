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
    public partial class feeform : UserControl
    {
        public feeform()
        {
            InitializeComponent();
        }

        private void btnaddfee_Click(object sender, EventArgs e)
        {
            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection connection = new SqlConnection(connectionpath);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            try
            {
                DateTime payingdate = Convert.ToDateTime(feepayingdate.Text);
                //DateTime joiningdate = Convert.ToDateTime(txtteacherjoiningdate.Text);
                //count = 1;

                command.CommandType = CommandType.StoredProcedure;
                command = new SqlCommand("INSERT INTO stdfeetable (stdname,stdsurname,paiddate,class,feemonth,totalfee,phnumber,fname,grnumber) " +
                    "VALUES (@stdname,@stdsurname,@paiddate,@class,@feemonth,@totalfee,@phnumber,@fname,@grnumber)", connection);
                //command.Parameters.Add("@id",NewID());
                command.Parameters.Add("@stdname", txtstdnamefee.Text);
                command.Parameters.Add("@stdsurname", stdsrnfee.Text);
                command.Parameters.Add("@class", classfee.Text);
                command.Parameters.Add("@feemonth", feepayingmonthtxt.Text);
                command.Parameters.Add("@paiddate", payingdate);
                command.Parameters.Add("@fname", fnamefee.Text);
                command.Parameters.Add("@totalfee", totalfeepaid.Text);
                command.Parameters.Add("@phnumber", fphonef.Text);
                command.Parameters.Add("@grnumber", txtstdidnumberfee.Text);
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i != 0)
                {
                    MessageBox.Show("Sucessfully Added");
                    DataClearing();

                }
                else
                {
                    MessageBox.Show("Data insertion failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataClearing()
        {
            stdsrnfee.Text = String.Empty;
            classfee.Text = String.Empty;
            feepayingdate.Text = String.Empty;
            feepayingdate.Text=String.Empty;
            fnamefee.Text = String.Empty;
            totalfeepaid.Text = String.Empty;
            fphonef.Text = String.Empty;
            txtstdidnumberfee.Text = String.Empty;
            txtstdnamefee.Text = String.Empty;
        }
    }
}
