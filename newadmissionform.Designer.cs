using System.Windows.Forms;

namespace FinalWorkProject
{
    partial class newadmissionform
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rbfmale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtfatherphone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfatherocup = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtreligion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadmissiondate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.birthdatetxt = new System.Windows.Forms.DateTimePicker();
            this.txtdatebirth = new System.Windows.Forms.Label();
            this.txtgrnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdimagebox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdimagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "\"\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1014, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 75;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Registeration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parents Information";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 77;
            this.button2.Text = "Select Photo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbfmale
            // 
            this.rbfmale.AutoSize = true;
            this.rbfmale.Location = new System.Drawing.Point(133, 41);
            this.rbfmale.Name = "rbfmale";
            this.rbfmale.Size = new System.Drawing.Size(112, 30);
            this.rbfmale.TabIndex = 1;
            this.rbfmale.TabStop = true;
            this.rbfmale.Text = "Female";
            this.rbfmale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(18, 41);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(84, 30);
            this.rbmale.TabIndex = 0;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtfatherphone
            // 
            this.txtfatherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfatherphone.Location = new System.Drawing.Point(684, 393);
            this.txtfatherphone.Name = "txtfatherphone";
            this.txtfatherphone.Size = new System.Drawing.Size(295, 32);
            this.txtfatherphone.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(681, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 26);
            this.label11.TabIndex = 73;
            this.label11.Text = "Phone Number :";
            // 
            // txtfatherocup
            // 
            this.txtfatherocup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfatherocup.Location = new System.Drawing.Point(686, 302);
            this.txtfatherocup.Name = "txtfatherocup";
            this.txtfatherocup.Size = new System.Drawing.Size(290, 32);
            this.txtfatherocup.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(683, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 26);
            this.label12.TabIndex = 71;
            this.label12.Text = "Father Occupation :";
            // 
            // txtfathername
            // 
            this.txtfathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfathername.Location = new System.Drawing.Point(686, 209);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(295, 32);
            this.txtfathername.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(683, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 26);
            this.label13.TabIndex = 69;
            this.label13.Text = "Father Name :";
            // 
            // txtreligion
            // 
            this.txtreligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreligion.Location = new System.Drawing.Point(16, 592);
            this.txtreligion.Name = "txtreligion";
            this.txtreligion.Size = new System.Drawing.Size(295, 32);
            this.txtreligion.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 67;
            this.label9.Text = "Religion :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbfmale);
            this.groupBox1.Controls.Add(this.rbmale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 644);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 82);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender :";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmissiondate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtadmissiondate.Location = new System.Drawing.Point(16, 501);
            this.txtadmissiondate.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(328, 32);
            this.txtadmissiondate.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 26);
            this.label8.TabIndex = 64;
            this.label8.Text = "Admission Date :";
            // 
            // birthdatetxt
            // 
            this.birthdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatetxt.Location = new System.Drawing.Point(16, 403);
            this.birthdatetxt.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.birthdatetxt.Name = "birthdatetxt";
            this.birthdatetxt.Size = new System.Drawing.Size(328, 32);
            this.birthdatetxt.TabIndex = 63;
            // 
            // txtdatebirth
            // 
            this.txtdatebirth.AutoSize = true;
            this.txtdatebirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatebirth.Location = new System.Drawing.Point(9, 362);
            this.txtdatebirth.Name = "txtdatebirth";
            this.txtdatebirth.Size = new System.Drawing.Size(126, 26);
            this.txtdatebirth.TabIndex = 62;
            this.txtdatebirth.Text = "BirthDate :";
            // 
            // txtgrnumber
            // 
            this.txtgrnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrnumber.Location = new System.Drawing.Point(364, 302);
            this.txtgrnumber.Name = "txtgrnumber";
            this.txtgrnumber.Size = new System.Drawing.Size(295, 32);
            this.txtgrnumber.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Gr Number :";
            // 
            // txtsurname
            // 
            this.txtsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurname.Location = new System.Drawing.Point(14, 302);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(295, 32);
            this.txtsurname.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 58;
            this.label6.Text = "Surname :";
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(364, 209);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(295, 32);
            this.txtlname.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 26);
            this.label5.TabIndex = 56;
            this.label5.Text = "Last Name :";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(14, 207);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(295, 32);
            this.txtfname.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "First Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(665, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 70);
            this.panel3.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 70);
            this.panel2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 81);
            this.panel1.TabIndex = 51;
            // 
            // stdimagebox
            // 
            this.stdimagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stdimagebox.Location = new System.Drawing.Point(386, 382);
            this.stdimagebox.Name = "stdimagebox";
            this.stdimagebox.Size = new System.Drawing.Size(273, 280);
            this.stdimagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stdimagebox.TabIndex = 76;
            this.stdimagebox.TabStop = false;
            // 
            // newadmissionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stdimagebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfatherphone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtfatherocup);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtreligion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtadmissiondate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.birthdatetxt);
            this.Controls.Add(this.txtdatebirth);
            this.Controls.Add(this.txtgrnumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "newadmissionform";
            this.Size = new System.Drawing.Size(1217, 740);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdimagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox stdimagebox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbfmale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.TextBox txtfatherphone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfatherocup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtreligion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtadmissiondate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthdatetxt;
        private System.Windows.Forms.Label txtdatebirth;
        private System.Windows.Forms.TextBox txtgrnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

        public Button Button2 { get => button2; set => button2 = value; }
    }
}
