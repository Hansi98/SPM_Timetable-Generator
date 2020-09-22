namespace ABC_Institute___Timetable_Generator
{
    partial class Section3_MarkUnavailabily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section3_MarkUnavailabily));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nishikistatimg = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.visalmudataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visalcmbday = new System.Windows.Forms.ComboBox();
            this.visalcmdtimeslot = new System.Windows.Forms.ComboBox();
            this.visalcmbmodulename = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.visalmudataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.visalusdatecmb = new System.Windows.Forms.ComboBox();
            this.visalustimeslotcmb = new System.Windows.Forms.ComboBox();
            this.visalusmodulenamecmb = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.visalcmdmugssubgroup = new System.Windows.Forms.ComboBox();
            this.visalmudataGridView3 = new System.Windows.Forms.DataGridView();
            this.visalbtnmu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.visalcmdmugsdate = new System.Windows.Forms.ComboBox();
            this.visalcmdmugstimeslot = new System.Windows.Forms.ComboBox();
            this.visalcmdmugsgroup = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nishikistatimg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1116, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mark unavailability Sessions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nishikistatimg
            // 
            this.nishikistatimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nishikistatimg.Image = ((System.Drawing.Image)(resources.GetObject("nishikistatimg.Image")));
            this.nishikistatimg.Location = new System.Drawing.Point(12, 12);
            this.nishikistatimg.Name = "nishikistatimg";
            this.nishikistatimg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nishikistatimg.Size = new System.Drawing.Size(77, 69);
            this.nishikistatimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nishikistatimg.TabIndex = 9;
            this.nishikistatimg.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 622);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 12;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.visalmudataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.visalcmbday);
            this.tabPage1.Controls.Add(this.visalcmdtimeslot);
            this.tabPage1.Controls.Add(this.visalcmbmodulename);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lecturers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // visalmudataGridView1
            // 
            this.visalmudataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visalmudataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visalmudataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visalmudataGridView1.Location = new System.Drawing.Point(733, 73);
            this.visalmudataGridView1.Name = "visalmudataGridView1";
            this.visalmudataGridView1.RowHeadersWidth = 51;
            this.visalmudataGridView1.RowTemplate.Height = 24;
            this.visalmudataGridView1.Size = new System.Drawing.Size(380, 481);
            this.visalmudataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(358, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mark Unavailable";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lecturer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // visalcmbday
            // 
            this.visalcmbday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmbday.FormattingEnabled = true;
            this.visalcmbday.ItemHeight = 36;
            this.visalcmbday.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wenesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.visalcmbday.Location = new System.Drawing.Point(358, 264);
            this.visalcmbday.Name = "visalcmbday";
            this.visalcmbday.Size = new System.Drawing.Size(324, 44);
            this.visalcmbday.TabIndex = 2;
            // 
            // visalcmdtimeslot
            // 
            this.visalcmdtimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmdtimeslot.FormattingEnabled = true;
            this.visalcmdtimeslot.ItemHeight = 36;
            this.visalcmdtimeslot.Location = new System.Drawing.Point(358, 165);
            this.visalcmdtimeslot.Name = "visalcmdtimeslot";
            this.visalcmdtimeslot.Size = new System.Drawing.Size(324, 44);
            this.visalcmdtimeslot.TabIndex = 1;
            // 
            // visalcmbmodulename
            // 
            this.visalcmbmodulename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmbmodulename.FormattingEnabled = true;
            this.visalcmbmodulename.ItemHeight = 36;
            this.visalcmbmodulename.Location = new System.Drawing.Point(358, 73);
            this.visalcmbmodulename.Name = "visalcmbmodulename";
            this.visalcmbmodulename.Size = new System.Drawing.Size(324, 44);
            this.visalcmbmodulename.TabIndex = 0;
            this.visalcmbmodulename.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.visalmudataGridView2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.visalusdatecmb);
            this.tabPage2.Controls.Add(this.visalustimeslotcmb);
            this.tabPage2.Controls.Add(this.visalusmodulenamecmb);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sessions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // visalmudataGridView2
            // 
            this.visalmudataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visalmudataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visalmudataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visalmudataGridView2.Location = new System.Drawing.Point(722, 56);
            this.visalmudataGridView2.Name = "visalmudataGridView2";
            this.visalmudataGridView2.RowHeadersWidth = 51;
            this.visalmudataGridView2.RowTemplate.Height = 24;
            this.visalmudataGridView2.Size = new System.Drawing.Size(380, 481);
            this.visalmudataGridView2.TabIndex = 15;
            this.visalmudataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(347, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 49);
            this.button3.TabIndex = 14;
            this.button3.Text = "Mark Unavailable";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time Slot";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Module Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // visalusdatecmb
            // 
            this.visalusdatecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalusdatecmb.FormattingEnabled = true;
            this.visalusdatecmb.ItemHeight = 36;
            this.visalusdatecmb.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wenesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.visalusdatecmb.Location = new System.Drawing.Point(347, 247);
            this.visalusdatecmb.Name = "visalusdatecmb";
            this.visalusdatecmb.Size = new System.Drawing.Size(324, 44);
            this.visalusdatecmb.TabIndex = 10;
            this.visalusdatecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // visalustimeslotcmb
            // 
            this.visalustimeslotcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalustimeslotcmb.FormattingEnabled = true;
            this.visalustimeslotcmb.ItemHeight = 36;
            this.visalustimeslotcmb.Location = new System.Drawing.Point(347, 148);
            this.visalustimeslotcmb.Name = "visalustimeslotcmb";
            this.visalustimeslotcmb.Size = new System.Drawing.Size(324, 44);
            this.visalustimeslotcmb.TabIndex = 9;
            this.visalustimeslotcmb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // visalusmodulenamecmb
            // 
            this.visalusmodulenamecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalusmodulenamecmb.FormattingEnabled = true;
            this.visalusmodulenamecmb.ItemHeight = 36;
            this.visalusmodulenamecmb.Location = new System.Drawing.Point(347, 56);
            this.visalusmodulenamecmb.Name = "visalusmodulenamecmb";
            this.visalusmodulenamecmb.Size = new System.Drawing.Size(324, 44);
            this.visalusmodulenamecmb.TabIndex = 8;
            this.visalusmodulenamecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.visalcmdmugssubgroup);
            this.tabPage3.Controls.Add(this.visalmudataGridView3);
            this.tabPage3.Controls.Add(this.visalbtnmu);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.visalcmdmugsdate);
            this.tabPage3.Controls.Add(this.visalcmdmugstimeslot);
            this.tabPage3.Controls.Add(this.visalcmdmugsgroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups & Subgroups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "Sub-group";
            // 
            // visalcmdmugssubgroup
            // 
            this.visalcmdmugssubgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmdmugssubgroup.FormattingEnabled = true;
            this.visalcmdmugssubgroup.ItemHeight = 36;
            this.visalcmdmugssubgroup.Location = new System.Drawing.Point(347, 143);
            this.visalcmdmugssubgroup.Name = "visalcmdmugssubgroup";
            this.visalcmdmugssubgroup.Size = new System.Drawing.Size(324, 44);
            this.visalcmdmugssubgroup.TabIndex = 24;
            // 
            // visalmudataGridView3
            // 
            this.visalmudataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visalmudataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visalmudataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visalmudataGridView3.Location = new System.Drawing.Point(722, 56);
            this.visalmudataGridView3.Name = "visalmudataGridView3";
            this.visalmudataGridView3.RowHeadersWidth = 51;
            this.visalmudataGridView3.RowTemplate.Height = 24;
            this.visalmudataGridView3.Size = new System.Drawing.Size(380, 481);
            this.visalmudataGridView3.TabIndex = 23;
            // 
            // visalbtnmu
            // 
            this.visalbtnmu.BackColor = System.Drawing.Color.Orange;
            this.visalbtnmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalbtnmu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.visalbtnmu.Location = new System.Drawing.Point(347, 456);
            this.visalbtnmu.Name = "visalbtnmu";
            this.visalbtnmu.Size = new System.Drawing.Size(324, 49);
            this.visalbtnmu.TabIndex = 22;
            this.visalbtnmu.Text = "Mark Unavailable";
            this.visalbtnmu.UseVisualStyleBackColor = false;
            this.visalbtnmu.Click += new System.EventHandler(this.visalbtnmu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "Time Slot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Group";
            // 
            // visalcmdmugsdate
            // 
            this.visalcmdmugsdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmdmugsdate.FormattingEnabled = true;
            this.visalcmdmugsdate.ItemHeight = 36;
            this.visalcmdmugsdate.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wenesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.visalcmdmugsdate.Location = new System.Drawing.Point(347, 334);
            this.visalcmdmugsdate.Name = "visalcmdmugsdate";
            this.visalcmdmugsdate.Size = new System.Drawing.Size(324, 44);
            this.visalcmdmugsdate.TabIndex = 18;
            // 
            // visalcmdmugstimeslot
            // 
            this.visalcmdmugstimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmdmugstimeslot.FormattingEnabled = true;
            this.visalcmdmugstimeslot.ItemHeight = 36;
            this.visalcmdmugstimeslot.Location = new System.Drawing.Point(347, 235);
            this.visalcmdmugstimeslot.Name = "visalcmdmugstimeslot";
            this.visalcmdmugstimeslot.Size = new System.Drawing.Size(324, 44);
            this.visalcmdmugstimeslot.TabIndex = 17;
            // 
            // visalcmdmugsgroup
            // 
            this.visalcmdmugsgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visalcmdmugsgroup.FormattingEnabled = true;
            this.visalcmdmugsgroup.ItemHeight = 36;
            this.visalcmdmugsgroup.Location = new System.Drawing.Point(347, 56);
            this.visalcmdmugsgroup.Name = "visalcmdmugsgroup";
            this.visalcmdmugsgroup.Size = new System.Drawing.Size(324, 44);
            this.visalcmdmugsgroup.TabIndex = 16;
            // 
            // Section3_MarkUnavailabily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1191, 774);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nishikistatimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section3_MarkUnavailabily";
            this.Text = "Session3_MarkUnavailabily";
            this.Load += new System.EventHandler(this.Session3_MarkUnavailabily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nishikistatimg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visalmudataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nishikistatimg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox visalcmbmodulename;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox visalcmbday;
        private System.Windows.Forms.ComboBox visalcmdtimeslot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView visalmudataGridView1;
        private System.Windows.Forms.DataGridView visalmudataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox visalusdatecmb;
        private System.Windows.Forms.ComboBox visalustimeslotcmb;
        private System.Windows.Forms.ComboBox visalusmodulenamecmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox visalcmdmugssubgroup;
        private System.Windows.Forms.DataGridView visalmudataGridView3;
        private System.Windows.Forms.Button visalbtnmu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox visalcmdmugsdate;
        private System.Windows.Forms.ComboBox visalcmdmugstimeslot;
        private System.Windows.Forms.ComboBox visalcmdmugsgroup;
    }
}