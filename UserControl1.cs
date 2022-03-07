using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalWorkProject
{
    public partial class teacherform : UserControl
    {
        
        public teacherform()
        {
            InitializeComponent();
        }
        string teacherimageaddress = "";
        Image image=null;
        private void teacherimagebuton_Click(object sender, EventArgs e)
        {
            teacherimagedialog = new OpenFileDialog();
            teacherimagedialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            teacherimagedialog.Title = "Select Image";
            
            if (teacherimagedialog.ShowDialog() == DialogResult.OK)
            {
                teacherimageaddress = teacherimagedialog.FileName;
                teacherimagebox.Image = Image.FromFile(teacherimageaddress);
                
            }
        }
        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true, true);

            return image;
        }
        private void btnteachersave_Click(object sender, EventArgs e)
        {
          
            String connectionpath = @"Data Source=DESKTOP-0LQQSL6\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=Managment;";
            SqlConnection connection = new SqlConnection(connectionpath);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string gnderstatu = "";
            if(rbmale.Checked)
            {
                gnderstatu = "Male";

            }
            if(rbfmale.Checked)
            {
                gnderstatu = "Female";
            }

            connection.Open();
            try
            {
                DateTime dobirth = Convert.ToDateTime(birthdatetxt.Text);
                DateTime joiningdate=Convert.ToDateTime(txtteacherjoiningdate.Text);
                 //count = 1;
                
                command.CommandType = CommandType.StoredProcedure;
                command = new SqlCommand("INSERT INTO TeacherInformation (fname,LastName,Surname,dob,jdate,religion,gnder,pnumber,email) " +
                    "VALUES (@fname,@LastName,@Surname,@dob,@jdate,@religion,@gnder,@pnumber,@email)", connection);
                //command.Parameters.Add("@id",NewID());
                command.Parameters.Add("@fname", txtteacherfname.Text);
                command.Parameters.Add("@LastName", txtteacherlname.Text);
                command.Parameters.Add("@Surname", txtteachersurname.Text);
                command.Parameters.Add("@dob", dobirth);
                command.Parameters.Add("@jdate", joiningdate);
                command.Parameters.Add("@religion", txtteacherreligion.Text);
                command.Parameters.Add("@gnder",gnderstatu );
                command.Parameters.Add("@pnumber", txtteacherphone.Text);
                command.Parameters.Add("@email", txtteacheremail.Text);
                //command.Parameters.Add("@image",teacherimageaddress );
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
            //txtteacherdatebirth.Controls.Clear();
            txtteacherfname.Text = String.Empty;
            txtteacherlname.Text = String.Empty;
            txtteacherphone.Text = String.Empty;
            txtteacherreligion.Text = String.Empty;
            txtteachersurname.Text = String.Empty;
            birthdatetxt.Text = String.Empty;
            txtteacherjoiningdate.Text = String.Empty;
            rbfmale.Text = String.Empty;
            rbmale.Text = String.Empty;
            txtteacheremail.Text = String.Empty;


        }


    }
}
