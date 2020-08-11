namespace ABC_Institute___Timetable_Generator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.panelslidebar = new System.Windows.Forms.Panel();
            this.homebtnstatistics = new System.Windows.Forms.Button();
            this.homebtnlocations = new System.Windows.Forms.Button();
            this.homebtntags = new System.Windows.Forms.Button();
            this.homebtnstudents = new System.Windows.Forms.Button();
            this.homebtnsubjects = new System.Windows.Forms.Button();
            this.homebtnlecturers = new System.Windows.Forms.Button();
            this.homebtnworkingdnh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homenavbtndetails = new System.Windows.Forms.Button();
            this.homenavbtnsessions = new System.Windows.Forms.Button();
            this.homenavbtntimetables = new System.Windows.Forms.Button();
            this.homenavbtnlocations = new System.Windows.Forms.Button();
            this.panelnav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

       //     this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();

           // this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();

            this.panel2.SuspendLayout();
            this.panelchildform.SuspendLayout();
            this.panelslidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelnav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panelchildform);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 497);
            this.panel2.TabIndex = 1;
            // 
            // panelchildform
            // 
            this.panelchildform.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelchildform.Controls.Add(this.panelslidebar);
            this.panelchildform.Controls.Add(this.textBox1);
            this.panelchildform.Controls.Add(this.pictureBox1);
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(0, 0);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(1051, 497);
            this.panelchildform.TabIndex = 1;

            this.panelchildform.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelchildform_Paint);

            // 
            // panelslidebar
            // 
            this.panelslidebar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelslidebar.Controls.Add(this.homebtnstatistics);
            this.panelslidebar.Controls.Add(this.homebtnlocations);
            this.panelslidebar.Controls.Add(this.homebtntags);
            this.panelslidebar.Controls.Add(this.homebtnstudents);
            this.panelslidebar.Controls.Add(this.homebtnsubjects);
            this.panelslidebar.Controls.Add(this.homebtnlecturers);
            this.panelslidebar.Controls.Add(this.homebtnworkingdnh);
            this.panelslidebar.Location = new System.Drawing.Point(0, 0);
            this.panelslidebar.Name = "panelslidebar";
            this.panelslidebar.Size = new System.Drawing.Size(259, 485);
            this.panelslidebar.TabIndex = 0;
            // 
            // homebtnstatistics
            // 
            this.homebtnstatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnstatistics.FlatAppearance.BorderSize = 0;
            this.homebtnstatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnstatistics.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnstatistics.Location = new System.Drawing.Point(0, 414);
            this.homebtnstatistics.Name = "homebtnstatistics";
            this.homebtnstatistics.Size = new System.Drawing.Size(259, 69);
            this.homebtnstatistics.TabIndex = 6;
            this.homebtnstatistics.Text = "Statistics";
            this.homebtnstatistics.UseVisualStyleBackColor = true;
            this.homebtnstatistics.Click += new System.EventHandler(this.Homebtnstatistics_Click);
            // 
            // homebtnlocations
            // 
            this.homebtnlocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnlocations.FlatAppearance.BorderSize = 0;
            this.homebtnlocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnlocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnlocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnlocations.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnlocations.Location = new System.Drawing.Point(0, 345);
            this.homebtnlocations.Name = "homebtnlocations";
            this.homebtnlocations.Size = new System.Drawing.Size(259, 69);
            this.homebtnlocations.TabIndex = 5;
            this.homebtnlocations.Text = "Locations";
            this.homebtnlocations.UseVisualStyleBackColor = true;
            this.homebtnlocations.Click += new System.EventHandler(this.Homebtnlocations_Click_1);
            // 
            // homebtntags
            // 
            this.homebtntags.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtntags.FlatAppearance.BorderSize = 0;
            this.homebtntags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtntags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtntags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtntags.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtntags.Location = new System.Drawing.Point(0, 276);
            this.homebtntags.Name = "homebtntags";
            this.homebtntags.Size = new System.Drawing.Size(259, 69);
            this.homebtntags.TabIndex = 4;
            this.homebtntags.Text = "Tags";
            this.homebtntags.UseVisualStyleBackColor = true;
            this.homebtntags.Click += new System.EventHandler(this.Homebtntags_Click);
            // 
            // homebtnstudents
            // 
            this.homebtnstudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnstudents.FlatAppearance.BorderSize = 0;
            this.homebtnstudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnstudents.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnstudents.Location = new System.Drawing.Point(0, 207);
            this.homebtnstudents.Name = "homebtnstudents";
            this.homebtnstudents.Size = new System.Drawing.Size(259, 69);
            this.homebtnstudents.TabIndex = 3;
            this.homebtnstudents.Text = "Students";
            this.homebtnstudents.UseVisualStyleBackColor = true;
            this.homebtnstudents.Click += new System.EventHandler(this.Homebtnstudents_Click);
            // 
            // homebtnsubjects
            // 
            this.homebtnsubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnsubjects.FlatAppearance.BorderSize = 0;
            this.homebtnsubjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnsubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnsubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnsubjects.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnsubjects.Location = new System.Drawing.Point(0, 138);
            this.homebtnsubjects.Name = "homebtnsubjects";
            this.homebtnsubjects.Size = new System.Drawing.Size(259, 69);
            this.homebtnsubjects.TabIndex = 2;
            this.homebtnsubjects.Text = "Subjects";
            this.homebtnsubjects.UseVisualStyleBackColor = true;
            this.homebtnsubjects.Click += new System.EventHandler(this.Homebtnsubjects_Click);
            // 
            // homebtnlecturers
            // 
            this.homebtnlecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnlecturers.FlatAppearance.BorderSize = 0;
            this.homebtnlecturers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnlecturers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnlecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnlecturers.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnlecturers.Location = new System.Drawing.Point(0, 69);
            this.homebtnlecturers.Name = "homebtnlecturers";
            this.homebtnlecturers.Size = new System.Drawing.Size(259, 69);
            this.homebtnlecturers.TabIndex = 1;
            this.homebtnlecturers.Text = "Lecturers";
            this.homebtnlecturers.UseVisualStyleBackColor = true;
            this.homebtnlecturers.Click += new System.EventHandler(this.Homebtnlecturers_Click);
            // 
            // homebtnworkingdnh
            // 
            this.homebtnworkingdnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnworkingdnh.FlatAppearance.BorderSize = 0;
            this.homebtnworkingdnh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnworkingdnh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnworkingdnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnworkingdnh.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnworkingdnh.Location = new System.Drawing.Point(0, 0);
            this.homebtnworkingdnh.Name = "homebtnworkingdnh";
            this.homebtnworkingdnh.Size = new System.Drawing.Size(259, 69);
            this.homebtnworkingdnh.TabIndex = 0;
            this.homebtnworkingdnh.Text = "Working days and hours";
            this.homebtnworkingdnh.UseVisualStyleBackColor = true;
            this.homebtnworkingdnh.Click += new System.EventHandler(this.Homebtnworkingdnh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(539, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homenavbtndetails
            // 
            this.homenavbtndetails.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homenavbtndetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homenavbtndetails.FlatAppearance.BorderSize = 0;
            this.homenavbtndetails.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtndetails.Location = new System.Drawing.Point(3, 3);
            this.homenavbtndetails.Name = "homenavbtndetails";
            this.homenavbtndetails.Size = new System.Drawing.Size(256, 51);
            this.homenavbtndetails.TabIndex = 4;
            this.homenavbtndetails.Text = "Details";
            this.homenavbtndetails.UseVisualStyleBackColor = false;
            this.homenavbtndetails.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // homenavbtnsessions
            // 
            this.homenavbtnsessions.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homenavbtnsessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homenavbtnsessions.FlatAppearance.BorderSize = 0;
            this.homenavbtnsessions.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtnsessions.Location = new System.Drawing.Point(265, 3);
            this.homenavbtnsessions.Name = "homenavbtnsessions";
            this.homenavbtnsessions.Size = new System.Drawing.Size(256, 51);
            this.homenavbtnsessions.TabIndex = 1;
            this.homenavbtnsessions.Text = "Sessions";
            this.homenavbtnsessions.UseVisualStyleBackColor = false;
            this.homenavbtnsessions.Click += new System.EventHandler(this.Homebtnsessions_Click);
            // 
            // homenavbtntimetables
            // 
            this.homenavbtntimetables.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homenavbtntimetables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homenavbtntimetables.FlatAppearance.BorderSize = 0;
            this.homenavbtntimetables.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtntimetables.Location = new System.Drawing.Point(789, 3);
            this.homenavbtntimetables.Name = "homenavbtntimetables";
            this.homenavbtntimetables.Size = new System.Drawing.Size(259, 51);
            this.homenavbtntimetables.TabIndex = 3;
            this.homenavbtntimetables.Text = "Timetables";
            this.homenavbtntimetables.UseVisualStyleBackColor = false;
            this.homenavbtntimetables.Click += new System.EventHandler(this.Homebtntimetables_Click);
            // 
            // homenavbtnlocations
            // 
            this.homenavbtnlocations.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homenavbtnlocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homenavbtnlocations.FlatAppearance.BorderSize = 0;
            this.homenavbtnlocations.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtnlocations.Location = new System.Drawing.Point(527, 3);
            this.homenavbtnlocations.Name = "homenavbtnlocations";
            this.homenavbtnlocations.Size = new System.Drawing.Size(256, 51);
            this.homenavbtnlocations.TabIndex = 2;
            this.homenavbtnlocations.Text = "Locations";
            this.homenavbtnlocations.UseVisualStyleBackColor = false;
            this.homenavbtnlocations.Click += new System.EventHandler(this.Homebtnlocations_Click);
            // 
            // panelnav
            // 
            this.panelnav.BackColor = System.Drawing.SystemColors.Control;
            this.panelnav.Controls.Add(this.tableLayoutPanel1);
            this.panelnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelnav.Location = new System.Drawing.Point(0, 0);
            this.panelnav.Name = "panelnav";
            this.panelnav.Size = new System.Drawing.Size(1051, 59);
            this.panelnav.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.homenavbtnsessions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtntimetables, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtndetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtnlocations, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroTabControl1
            // 

           // this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
           // this.metroTabControl1.Name = "metroTabControl1";
          // // this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
          //  this.metroTabControl1.TabIndex = 0;
          //  this.metroTabControl1.UseSelectable = true;
            // 

        /*    this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
        */    // 

            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelnav);
            this.Name = "Home";
            this.Text = "ABC Institute - Timetable Generator";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panelchildform.ResumeLayout(false);
            this.panelchildform.PerformLayout();
            this.panelslidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelnav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homenavbtntimetables;
        private System.Windows.Forms.Button homenavbtnlocations;
        private System.Windows.Forms.Button homenavbtnsessions;
        private System.Windows.Forms.Panel panelslidebar;
        private System.Windows.Forms.Button homebtnstatistics;
        private System.Windows.Forms.Button homebtnlocations;
        private System.Windows.Forms.Button homebtntags;
        private System.Windows.Forms.Button homebtnstudents;
        private System.Windows.Forms.Button homebtnsubjects;
        private System.Windows.Forms.Button homebtnlecturers;
        private System.Windows.Forms.Button homebtnworkingdnh;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelnav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homenavbtndetails;

       // private MetroFramework.Controls.MetroTabControl metroTabControl1;

      //  private MetroFramework.Controls.MetroTabControl metroTabControl1;

    }
}
