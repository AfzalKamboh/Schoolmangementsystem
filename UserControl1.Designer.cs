namespace FinalWorkProject
{
    partial class teacherform
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
            this.btnteachersave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacherimagedialog = new System.Windows.Forms.OpenFileDialog();
            this.txtteacheremail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtteacherphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherimagebuton = new System.Windows.Forms.Button();
            this.txtteacherjoiningdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.birthdatetxt = new System.Windows.Forms.DateTimePicker();
            this.txtteacherdatebirth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtteacherlname = new System.Windows.Forms.TextBox();
            this.txtteacherfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbfmale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtteacherreligion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teachergender = new System.Windows.Forms.GroupBox();
            this.txtteachersurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherimagebox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.teachergender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherimagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnteachersave
            // 
            this.btnteachersave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteachersave.Location = new System.Drawing.Point(958, 625);
            this.btnteachersave.Name = "btnteachersave";
            this.btnteachersave.Size = new System.Drawing.Size(183, 46);
            this.btnteachersave.TabIndex = 96;
            this.btnteachersave.Text = "Save";
            this.btnteachersave.UseVisualStyleBackColor = true;
            this.btnteachersave.Click += new System.EventHandler(this.btnteachersave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(127)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 81);
            this.panel1.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Registeration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(5, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 70);
            this.panel2.TabIndex = 95;
            // 
            // teacherimagedialog
            // 
            this.teacherimagedialog.FileName = "openFileDialog1";
            // 
            // txtteacheremail
            // 
            this.txtteacheremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacheremail.Location = new System.Drawing.Point(472, 653);
            this.txtteacheremail.Name = "txtteacheremail";
            this.txtteacheremail.Size = new System.Drawing.Size(317, 32);
            this.txtteacheremail.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 92;
            this.label2.Text = "Email :";
            // 
            // txtteacherphone
            // 
            this.txtteacherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherphone.Location = new System.Drawing.Point(33, 653);
            this.txtteacherphone.Name = "txtteacherphone";
            this.txtteacherphone.Size = new System.Drawing.Size(317, 32);
            this.txtteacherphone.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 90;
            this.label1.Text = "Phone :";
            // 
            // teacherimagebuton
            // 
            this.teacherimagebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherimagebuton.Location = new System.Drawing.Point(958, 494);
            this.teacherimagebuton.Name = "teacherimagebuton";
            this.teacherimagebuton.Size = new System.Drawing.Size(183, 46);
            this.teacherimagebuton.TabIndex = 89;
            this.teacherimagebuton.Text = "Select Photo";
            this.teacherimagebuton.UseVisualStyleBackColor = true;
            this.teacherimagebuton.Click += new System.EventHandler(this.teacherimagebuton_Click);
            // 
            // txtteacherjoiningdate
            // 
            this.txtteacherjoiningdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherjoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtteacherjoiningdate.Location = new System.Drawing.Point(474, 420);
            this.txtteacherjoiningdate.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.txtteacherjoiningdate.Name = "txtteacherjoiningdate";
            this.txtteacherjoiningdate.Size = new System.Drawing.Size(164, 32);
            this.txtteacherjoiningdate.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 26);
            this.label8.TabIndex = 83;
            this.label8.Text = "Joining Date :";
            // 
            // birthdatetxt
            // 
            this.birthdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatetxt.Location = new System.Drawing.Point(20, 420);
            this.birthdatetxt.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.birthdatetxt.Name = "birthdatetxt";
            this.birthdatetxt.Size = new System.Drawing.Size(158, 32);
            this.birthdatetxt.TabIndex = 82;
            // 
            // txtteacherdatebirth
            // 
            this.txtteacherdatebirth.AutoSize = true;
            this.txtteacherdatebirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherdatebirth.Location = new System.Drawing.Point(15, 382);
            this.txtteacherdatebirth.Name = "txtteacherdatebirth";
            this.txtteacherdatebirth.Size = new System.Drawing.Size(126, 26);
            this.txtteacherdatebirth.TabIndex = 81;
            this.txtteacherdatebirth.Text = "BirthDate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 79;
            this.label6.Text = "Surname :";
            // 
            // txtteacherlname
            // 
            this.txtteacherlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherlname.Location = new System.Drawing.Point(470, 229);
            this.txtteacherlname.Name = "txtteacherlname";
            this.txtteacherlname.Size = new System.Drawing.Size(312, 32);
            this.txtteacherlname.TabIndex = 78;
            // 
            // txtteacherfname
            // 
            this.txtteacherfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherfname.Location = new System.Drawing.Point(20, 227);
            this.txtteacherfname.Name = "txtteacherfname";
            this.txtteacherfname.Size = new System.Drawing.Size(317, 32);
            this.txtteacherfname.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 75;
            this.label4.Text = "First Name :";
            // 
            // rbfmale
            // 
            this.rbfmale.AutoSize = true;
            this.rbfmale.Location = new System.Drawing.Point(164, 41);
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
            this.rbmale.Location = new System.Drawing.Point(27, 41);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(84, 30);
            this.rbmale.TabIndex = 0;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtteacherreligion
            // 
            this.txtteacherreligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherreligion.Location = new System.Drawing.Point(29, 544);
            this.txtteacherreligion.Name = "txtteacherreligion";
            this.txtteacherreligion.Size = new System.Drawing.Size(317, 32);
            this.txtteacherreligion.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 86;
            this.label9.Text = "Religion :";
            // 
            // teachergender
            // 
            this.teachergender.Controls.Add(this.rbfmale);
            this.teachergender.Controls.Add(this.rbmale);
            this.teachergender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachergender.Location = new System.Drawing.Point(474, 494);
            this.teachergender.Name = "teachergender";
            this.teachergender.Size = new System.Drawing.Size(304, 82);
            this.teachergender.TabIndex = 85;
            this.teachergender.TabStop = false;
            this.teachergender.Text = "Gender :";
            // 
            // txtteachersurname
            // 
            this.txtteachersurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteachersurname.Location = new System.Drawing.Point(20, 322);
            this.txtteachersurname.Name = "txtteachersurname";
            this.txtteachersurname.Size = new System.Drawing.Size(317, 32);
            this.txtteachersurname.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "Last Name :";
            // 
            // teacherimagebox
            // 
            this.teacherimagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherimagebox.Location = new System.Drawing.Point(900, 198);
            this.teacherimagebox.Name = "teacherimagebox";
            this.teacherimagebox.Size = new System.Drawing.Size(295, 280);
            this.teacherimagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherimagebox.TabIndex = 88;
            this.teacherimagebox.TabStop = false;
            // 
            // teacherform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnteachersave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtteacheremail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtteacherphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherimagebuton);
            this.Controls.Add(this.txtteacherjoiningdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.birthdatetxt);
            this.Controls.Add(this.txtteacherdatebirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtteacherlname);
            this.Controls.Add(this.txtteacherfname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherimagebox);
            this.Controls.Add(this.txtteacherreligion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teachergender);
            this.Controls.Add(this.txtteachersurname);
            this.Controls.Add(this.label5);
            this.Name = "teacherform";
            this.Size = new System.Drawing.Size(1217, 740);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.teachergender.ResumeLayout(false);
            this.teachergender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherimagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnteachersave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog teacherimagedialog;
        private System.Windows.Forms.TextBox txtteacheremail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtteacherphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacherimagebuton;
        private System.Windows.Forms.DateTimePicker txtteacherjoiningdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthdatetxt;
        private System.Windows.Forms.Label txtteacherdatebirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtteacherlname;
        private System.Windows.Forms.TextBox txtteacherfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbfmale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.PictureBox teacherimagebox;
        private System.Windows.Forms.TextBox txtteacherreligion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox teachergender;
        private System.Windows.Forms.TextBox txtteachersurname;
        private System.Windows.Forms.Label label5;
    }
}
