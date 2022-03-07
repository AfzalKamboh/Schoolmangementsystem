namespace FinalWorkProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.formpanels = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnparents = new System.Windows.Forms.Button();
            this.panelstudntmenu = new System.Windows.Forms.Panel();
            this.btnfee = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnadmission = new System.Windows.Forms.Button();
            this.btnteachers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homepage1 = new FinalWorkProject.homepage();
            this.panel1.SuspendLayout();
            this.formpanels.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelstudntmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(82)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.formpanels);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 869);
            this.panel1.TabIndex = 1;
            // 
            // formpanels
            // 
            this.formpanels.Controls.Add(this.homepage1);
            this.formpanels.Location = new System.Drawing.Point(266, 67);
            this.formpanels.Name = "formpanels";
            this.formpanels.Size = new System.Drawing.Size(1217, 740);
            this.formpanels.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(117)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.btndashboard);
            this.panel3.Controls.Add(this.btnstudent);
            this.panel3.Controls.Add(this.btnparents);
            this.panel3.Controls.Add(this.panelstudntmenu);
            this.panel3.Controls.Add(this.btnteachers);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 861);
            this.panel3.TabIndex = 9;
            // 
            // btndashboard
            // 
            this.btndashboard.AutoSize = true;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.Location = new System.Drawing.Point(3, 262);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(255, 46);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.AllowDrop = true;
            this.btnstudent.AutoSize = true;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Location = new System.Drawing.Point(3, 418);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(255, 46);
            this.btnstudent.TabIndex = 2;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnparents
            // 
            this.btnparents.AutoSize = true;
            this.btnparents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparents.Location = new System.Drawing.Point(3, 366);
            this.btnparents.Name = "btnparents";
            this.btnparents.Size = new System.Drawing.Size(255, 46);
            this.btnparents.TabIndex = 5;
            this.btnparents.Text = "SchoolExpenses";
            this.btnparents.UseVisualStyleBackColor = true;
            // 
            // panelstudntmenu
            // 
            this.panelstudntmenu.Controls.Add(this.btnfee);
            this.panelstudntmenu.Controls.Add(this.btnresult);
            this.panelstudntmenu.Controls.Add(this.btnadmission);
            this.panelstudntmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelstudntmenu.Location = new System.Drawing.Point(31, 470);
            this.panelstudntmenu.Name = "panelstudntmenu";
            this.panelstudntmenu.Size = new System.Drawing.Size(227, 141);
            this.panelstudntmenu.TabIndex = 3;
            // 
            // btnfee
            // 
            this.btnfee.AutoSize = true;
            this.btnfee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.btnfee.Location = new System.Drawing.Point(3, 95);
            this.btnfee.Name = "btnfee";
            this.btnfee.Size = new System.Drawing.Size(221, 42);
            this.btnfee.TabIndex = 6;
            this.btnfee.Text = "Fee";
            this.btnfee.UseVisualStyleBackColor = false;
            this.btnfee.Click += new System.EventHandler(this.btnfee_Click);
            // 
            // btnresult
            // 
            this.btnresult.AutoSize = true;
            this.btnresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.btnresult.Location = new System.Drawing.Point(3, 49);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(221, 42);
            this.btnresult.TabIndex = 5;
            this.btnresult.Text = "Result";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnadmission
            // 
            this.btnadmission.AutoSize = true;
            this.btnadmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.btnadmission.Location = new System.Drawing.Point(3, 3);
            this.btnadmission.Name = "btnadmission";
            this.btnadmission.Size = new System.Drawing.Size(221, 42);
            this.btnadmission.TabIndex = 4;
            this.btnadmission.Text = "NewAdmission";
            this.btnadmission.UseVisualStyleBackColor = false;
            this.btnadmission.Click += new System.EventHandler(this.btnadmission_Click);
            // 
            // btnteachers
            // 
            this.btnteachers.AutoSize = true;
            this.btnteachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteachers.Location = new System.Drawing.Point(3, 314);
            this.btnteachers.Name = "btnteachers";
            this.btnteachers.Size = new System.Drawing.Size(255, 46);
            this.btnteachers.TabIndex = 4;
            this.btnteachers.Text = "Teachers";
            this.btnteachers.UseVisualStyleBackColor = true;
            this.btnteachers.Click += new System.EventHandler(this.btnteachers_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(269, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 60);
            this.panel2.TabIndex = 1;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtsearch.Location = new System.Drawing.Point(758, 11);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(377, 38);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FinalWorkProject.Properties.Resources.PngItem_771663;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1413, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 63);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.BackgroundImage = global::FinalWorkProject.Properties.Resources.icons8_search_24;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.Location = new System.Drawing.Point(1093, 14);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(40, 33);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalWorkProject.Properties.Resources.school_icon_transparent_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // homepage1
            // 
            this.homepage1.Location = new System.Drawing.Point(0, 0);
            this.homepage1.Name = "homepage1";
            this.homepage1.Size = new System.Drawing.Size(1217, 740);
            this.homepage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 811);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "School Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.formpanels.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelstudntmenu.ResumeLayout(false);
            this.panelstudntmenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnparents;
        private System.Windows.Forms.Panel panelstudntmenu;
        private System.Windows.Forms.Button btnfee;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnadmission;
        private System.Windows.Forms.Button btnteachers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel formpanels;
        private resultform resultform1;
        private feeform feeform1;
        private newadmissionform newadmissionform1;
        private teacherform teacherform1;
        private homepage homepage1;
    }
}

