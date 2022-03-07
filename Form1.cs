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

namespace FinalWorkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        } 
       private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CustomizeDesign()
        {
            panelstudntmenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelstudntmenu.Visible == true)
            {
                panelstudntmenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            homepage1.BringToFront();
            HideSubMenu();
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            teacherform1.BringToFront();
            HideSubMenu();
        }

        private void btnadmission_Click(object sender, EventArgs e)
        {
            newadmissionform1.BringToFront();
            HideSubMenu();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            resultform1.BringToFront();
            HideSubMenu();
        }

        private void btnfee_Click(object sender, EventArgs e)
        {
            feeform1.BringToFront();
            HideSubMenu();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelstudntmenu);
        }
    }
}
