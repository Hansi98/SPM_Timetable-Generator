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
            this.homenavbtndetails = new System.Windows.Forms.Button();
            this.homenavbtnsessions = new System.Windows.Forms.Button();
            this.homenavbtntimetables = new System.Windows.Forms.Button();
            this.homenavbtnlocations = new System.Windows.Forms.Button();
            this.panelnav = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SessionsDropDownBar = new System.Windows.Forms.Panel();
            this.btnVSessionunavailability = new System.Windows.Forms.Button();
            this.btnVSessionconcecutive = new System.Windows.Forms.Button();
            this.btnVSessionparallel = new System.Windows.Forms.Button();
            this.btnVSessionnotoverlapping = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.homebtnstatistics = new System.Windows.Forms.Button();
            this.homebtnlocations = new System.Windows.Forms.Button();
            this.homebtntags = new System.Windows.Forms.Button();
            this.homebtnstudents = new System.Windows.Forms.Button();
            this.homebtnsubjects = new System.Windows.Forms.Button();
            this.homebtnlecturers = new System.Windows.Forms.Button();
            this.homebtnworkingdnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelchildform.SuspendLayout();
            this.panelslidebar.SuspendLayout();
            this.panelnav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SessionsDropDownBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panelchildform);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1409, 783);
            this.panel2.TabIndex = 1;
            // 
            // panelchildform
            // 
            this.panelchildform.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelchildform.Controls.Add(this.panelslidebar);
            this.panelchildform.Controls.Add(this.SessionsDropDownBar);
            this.panelchildform.Controls.Add(this.pictureBox1);
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(0, 0);
            this.panelchildform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(1409, 783);
            this.panelchildform.TabIndex = 1;
            this.panelchildform.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelchildform_Paint);
            // 
            // panelslidebar
            // 
            this.panelslidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelslidebar.BackColor = System.Drawing.Color.LightCyan;
            this.panelslidebar.Controls.Add(this.button9);
            this.panelslidebar.Controls.Add(this.button8);
            this.panelslidebar.Controls.Add(this.homebtnstatistics);
            this.panelslidebar.Controls.Add(this.homebtnlocations);
            this.panelslidebar.Controls.Add(this.homebtntags);
            this.panelslidebar.Controls.Add(this.homebtnstudents);
            this.panelslidebar.Controls.Add(this.homebtnsubjects);
            this.panelslidebar.Controls.Add(this.homebtnlecturers);
            this.panelslidebar.Controls.Add(this.homebtnworkingdnh);
            this.panelslidebar.Location = new System.Drawing.Point(0, 0);
            this.panelslidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelslidebar.Name = "panelslidebar";
            this.panelslidebar.Size = new System.Drawing.Size(349, 783);
            this.panelslidebar.TabIndex = 0;
            // 
            // homenavbtndetails
            // 
            this.homenavbtndetails.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homenavbtndetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homenavbtndetails.FlatAppearance.BorderSize = 0;
            this.homenavbtndetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homenavbtndetails.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtndetails.Location = new System.Drawing.Point(3, 2);
            this.homenavbtndetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homenavbtndetails.Name = "homenavbtndetails";
            this.homenavbtndetails.Size = new System.Drawing.Size(342, 53);
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
            this.homenavbtnsessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homenavbtnsessions.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtnsessions.Location = new System.Drawing.Point(351, 2);
            this.homenavbtnsessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homenavbtnsessions.Name = "homenavbtnsessions";
            this.homenavbtnsessions.Size = new System.Drawing.Size(350, 53);
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
            this.homenavbtntimetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homenavbtntimetables.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtntimetables.Location = new System.Drawing.Point(1059, 2);
            this.homenavbtntimetables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homenavbtntimetables.Name = "homenavbtntimetables";
            this.homenavbtntimetables.Size = new System.Drawing.Size(347, 53);
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
            this.homenavbtnlocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homenavbtnlocations.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homenavbtnlocations.Location = new System.Drawing.Point(707, 2);
            this.homenavbtnlocations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homenavbtnlocations.Name = "homenavbtnlocations";
            this.homenavbtnlocations.Size = new System.Drawing.Size(346, 53);
            this.homenavbtnlocations.TabIndex = 2;
            this.homenavbtnlocations.Text = "Locations";
            this.homenavbtnlocations.UseVisualStyleBackColor = false;
            this.homenavbtnlocations.Click += new System.EventHandler(this.Homebtnlocations_Click);
            // 
            // panelnav
            // 
            this.panelnav.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelnav.Controls.Add(this.tableLayoutPanel1);
            this.panelnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelnav.Location = new System.Drawing.Point(0, 0);
            this.panelnav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelnav.Name = "panelnav";
            this.panelnav.Size = new System.Drawing.Size(1409, 59);
            this.panelnav.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.homenavbtnsessions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtntimetables, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtndetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homenavbtnlocations, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1409, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SessionsDropDownBar
            // 
            this.SessionsDropDownBar.BackColor = System.Drawing.Color.LightCyan;
            this.SessionsDropDownBar.Controls.Add(this.btnVSessionnotoverlapping);
            this.SessionsDropDownBar.Controls.Add(this.btnVSessionparallel);
            this.SessionsDropDownBar.Controls.Add(this.btnVSessionconcecutive);
            this.SessionsDropDownBar.Controls.Add(this.btnVSessionunavailability);
            this.SessionsDropDownBar.Location = new System.Drawing.Point(351, 0);
            this.SessionsDropDownBar.Name = "SessionsDropDownBar";
            this.SessionsDropDownBar.Size = new System.Drawing.Size(350, 448);
            this.SessionsDropDownBar.TabIndex = 1;
            // 
            // btnVSessionunavailability
            // 
            this.btnVSessionunavailability.BackColor = System.Drawing.Color.LightCyan;
            this.btnVSessionunavailability.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVSessionunavailability.FlatAppearance.BorderSize = 0;
            this.btnVSessionunavailability.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionunavailability.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionunavailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSessionunavailability.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVSessionunavailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVSessionunavailability.Location = new System.Drawing.Point(0, 0);
            this.btnVSessionunavailability.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnVSessionunavailability.Name = "btnVSessionunavailability";
            this.btnVSessionunavailability.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnVSessionunavailability.Size = new System.Drawing.Size(350, 112);
            this.btnVSessionunavailability.TabIndex = 0;
            this.btnVSessionunavailability.Text = "Mark Unavailability";
            this.btnVSessionunavailability.UseVisualStyleBackColor = true;
            this.btnVSessionunavailability.Click += new System.EventHandler(this.BtnVSessionunavailability_Click);
            // 
            // btnVSessionconcecutive
            // 
            this.btnVSessionconcecutive.BackColor = System.Drawing.Color.LightCyan;
            this.btnVSessionconcecutive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVSessionconcecutive.FlatAppearance.BorderSize = 0;
            this.btnVSessionconcecutive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionconcecutive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionconcecutive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSessionconcecutive.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVSessionconcecutive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVSessionconcecutive.Location = new System.Drawing.Point(0, 112);
            this.btnVSessionconcecutive.Name = "btnVSessionconcecutive";
            this.btnVSessionconcecutive.Size = new System.Drawing.Size(350, 112);
            this.btnVSessionconcecutive.TabIndex = 1;
            this.btnVSessionconcecutive.Text = "Consecutive Sessions";
            this.btnVSessionconcecutive.UseVisualStyleBackColor = true;
            this.btnVSessionconcecutive.Click += new System.EventHandler(this.BtnVSessionconcecutive_Click);
            // 
            // btnVSessionparallel
            // 
            this.btnVSessionparallel.BackColor = System.Drawing.Color.LightCyan;
            this.btnVSessionparallel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVSessionparallel.FlatAppearance.BorderSize = 0;
            this.btnVSessionparallel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionparallel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionparallel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSessionparallel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVSessionparallel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVSessionparallel.Location = new System.Drawing.Point(0, 224);
            this.btnVSessionparallel.Name = "btnVSessionparallel";
            this.btnVSessionparallel.Size = new System.Drawing.Size(350, 112);
            this.btnVSessionparallel.TabIndex = 2;
            this.btnVSessionparallel.Text = "Parallel Sessions";
            this.btnVSessionparallel.UseVisualStyleBackColor = true;
            this.btnVSessionparallel.Click += new System.EventHandler(this.BtnVSessionparallel_Click);
            // 
            // btnVSessionnotoverlapping
            // 
            this.btnVSessionnotoverlapping.BackColor = System.Drawing.Color.LightCyan;
            this.btnVSessionnotoverlapping.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVSessionnotoverlapping.FlatAppearance.BorderSize = 0;
            this.btnVSessionnotoverlapping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionnotoverlapping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnVSessionnotoverlapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVSessionnotoverlapping.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVSessionnotoverlapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVSessionnotoverlapping.Location = new System.Drawing.Point(0, 336);
            this.btnVSessionnotoverlapping.Name = "btnVSessionnotoverlapping";
            this.btnVSessionnotoverlapping.Size = new System.Drawing.Size(350, 112);
            this.btnVSessionnotoverlapping.TabIndex = 3;
            this.btnVSessionnotoverlapping.Text = "Not Overlapping Sessions";
            this.btnVSessionnotoverlapping.UseVisualStyleBackColor = true;
            this.btnVSessionnotoverlapping.Click += new System.EventHandler(this.BtnVSessionnotoverlapping_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.timetable_30px;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 896);
            this.button9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.button9.Size = new System.Drawing.Size(349, 112);
            this.button9.TabIndex = 8;
            this.button9.Text = "Working Days and Hours";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.timetable_30px;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 784);
            this.button8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.button8.Size = new System.Drawing.Size(349, 112);
            this.button8.TabIndex = 7;
            this.button8.Text = "Working Days and Hours";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // homebtnstatistics
            // 
            this.homebtnstatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtnstatistics.FlatAppearance.BorderSize = 0;
            this.homebtnstatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.homebtnstatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtnstatistics.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtnstatistics.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.graph_30px;
            this.homebtnstatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnstatistics.Location = new System.Drawing.Point(0, 672);
            this.homebtnstatistics.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnstatistics.Name = "homebtnstatistics";
            this.homebtnstatistics.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnstatistics.Size = new System.Drawing.Size(349, 112);
            this.homebtnstatistics.TabIndex = 6;
            this.homebtnstatistics.Text = "Statistics";
            this.homebtnstatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnstatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtnlocations.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.location_24px;
            this.homebtnlocations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnlocations.Location = new System.Drawing.Point(0, 560);
            this.homebtnlocations.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnlocations.Name = "homebtnlocations";
            this.homebtnlocations.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnlocations.Size = new System.Drawing.Size(349, 112);
            this.homebtnlocations.TabIndex = 5;
            this.homebtnlocations.Text = "Locations";
            this.homebtnlocations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnlocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtntags.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.tags_24px;
            this.homebtntags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtntags.Location = new System.Drawing.Point(0, 448);
            this.homebtntags.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtntags.Name = "homebtntags";
            this.homebtntags.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtntags.Size = new System.Drawing.Size(349, 112);
            this.homebtntags.TabIndex = 4;
            this.homebtntags.Text = "Tags";
            this.homebtntags.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtntags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtnstudents.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.student_male_32px;
            this.homebtnstudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnstudents.Location = new System.Drawing.Point(0, 336);
            this.homebtnstudents.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnstudents.Name = "homebtnstudents";
            this.homebtnstudents.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnstudents.Size = new System.Drawing.Size(349, 112);
            this.homebtnstudents.TabIndex = 3;
            this.homebtnstudents.Text = "Students";
            this.homebtnstudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnstudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtnsubjects.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.elective_32pxdark;
            this.homebtnsubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnsubjects.Location = new System.Drawing.Point(0, 224);
            this.homebtnsubjects.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnsubjects.Name = "homebtnsubjects";
            this.homebtnsubjects.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnsubjects.Size = new System.Drawing.Size(349, 112);
            this.homebtnsubjects.TabIndex = 2;
            this.homebtnsubjects.Text = "Subjects";
            this.homebtnsubjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnsubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtnlecturers.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.lecturer_32px;
            this.homebtnlecturers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnlecturers.Location = new System.Drawing.Point(0, 112);
            this.homebtnlecturers.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnlecturers.Name = "homebtnlecturers";
            this.homebtnlecturers.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnlecturers.Size = new System.Drawing.Size(349, 112);
            this.homebtnlecturers.TabIndex = 1;
            this.homebtnlecturers.Text = "Lecturers";
            this.homebtnlecturers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnlecturers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.homebtnworkingdnh.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.timetable_30px;
            this.homebtnworkingdnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtnworkingdnh.Location = new System.Drawing.Point(0, 0);
            this.homebtnworkingdnh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.homebtnworkingdnh.Name = "homebtnworkingdnh";
            this.homebtnworkingdnh.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.homebtnworkingdnh.Size = new System.Drawing.Size(349, 112);
            this.homebtnworkingdnh.TabIndex = 0;
            this.homebtnworkingdnh.Text = "Working Days and Hours";
            this.homebtnworkingdnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homebtnworkingdnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtnworkingdnh.UseVisualStyleBackColor = true;
            this.homebtnworkingdnh.Click += new System.EventHandler(this.Homebtnworkingdnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1409, 783);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 842);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelnav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "ABC Institute - Timetable Generator";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panelchildform.ResumeLayout(false);
            this.panelslidebar.ResumeLayout(false);
            this.panelnav.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SessionsDropDownBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelnav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homenavbtndetails;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel SessionsDropDownBar;
        private System.Windows.Forms.Button btnVSessionnotoverlapping;
        private System.Windows.Forms.Button btnVSessionparallel;
        private System.Windows.Forms.Button btnVSessionconcecutive;
        private System.Windows.Forms.Button btnVSessionunavailability;

        // private MetroFramework.Controls.MetroTabControl metroTabControl1;

        //  private MetroFramework.Controls.MetroTabControl metroTabControl1;

    }
}
