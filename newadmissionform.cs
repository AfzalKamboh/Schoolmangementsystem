using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWorkProject
{
    public partial class newadmissionform : login
    {
        public newadmissionform()
        {
            InitializeComponent();
        }
        string imageaddress = "";
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog1.Title = "Select Image";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageaddress = openFileDialog1.FileName;
                stdimagebox.Image = Image.FromFile(imageaddress);
            }
        }
        //studentinfoDataContext stdcontext = new studentinfoDataContext();
        stdinfoDataContext stdd=new stdinfoDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            string tfname = txtfname.Text, tlname = txtlname.Text, tsname = txtsurname.Text,
                treligion = txtreligion.Text, fathern = txtfathername.Text, fatherocp = txtfatherocup.Text;
            long fatherphone=Int32.Parse(txtfatherphone.Text);
            int grnumberstd = Int32.Parse(txtgrnumber.Text);
            DateTime stddob = birthdatetxt.Value;
            DateTime tjoiningdate = txtadmissiondate.Value;
            Random rnd = new Random();
            int idnumber = rnd.Next(1000);
            string gender = "";
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            try
            {
                var tdata = new StudentInformation
                {

                    firstname = tfname,
                    lastname = tlname,
                    birthdate = stddob,
                    admissiondate = tjoiningdate,
                    religion = treligion,
                    studentid = grnumberstd,
                    //studentid = idnumber,   
                    gender = gender,
                    surname = tsname,
                    image =imageaddress,
                    fathername=fathern,
                    fatheroccup=fatherocp,
                    fphone=fatherphone,
                };
                stdd.StudentInformations.InsertOnSubmit(tdata);
                stdd.SubmitChanges();
                MessageBox.Show("Successfully Inserted ");
                DataClearing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }
        private void DataClearing()
        {
            //txtteacherdatebirth.Controls.Clear();
            txtfname.Text = String.Empty;
            txtlname.Text = String.Empty;
            txtgrnumber.Text = String.Empty;
            txtreligion.Text = String.Empty;
            txtsurname.Text = String.Empty;
            birthdatetxt.Text = String.Empty;
            txtadmissiondate.Text = String.Empty;
            rbfmale.Text = String.Empty;
            rbmale.Text = String.Empty;
            txtfathername.Text = String.Empty;
            txtfatherocup.Text = String.Empty;  
            txtfatherphone.Text = String.Empty;
            stdimagebox.Image = null;
            
        }
    }
}
