namespace ABC_Institute___Timetable_Generator
{
    partial class Section1_WorkingDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section1_WorkingDays));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HansiWork_tabcontrol = new System.Windows.Forms.TabControl();
            this.HansiWork_daystab = new System.Windows.Forms.TabPage();
            this.HansiWork_tabledays = new System.Windows.Forms.TableLayoutPanel();
            this.HansiWork_dayslist = new System.Windows.Forms.CheckedListBox();
            this.HansiWork_daysno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HansiWork_daysbtnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HansiWork_hourstab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.HansiWork_minutes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.HansiWork_timeslots = new System.Windows.Forms.ComboBox();
            this.HansiWork_hourstable = new System.Windows.Forms.TableLayoutPanel();
            this.HansiWork_hours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.HansiWork_hoursaddbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HansiWork_tabcontrol.SuspendLayout();
            this.HansiWork_daystab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_daysno)).BeginInit();
            this.HansiWork_hourstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_hours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.HansiWork_tabcontrol);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 509);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Working Days and Hours";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // HansiWork_tabcontrol
            // 
            this.HansiWork_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HansiWork_tabcontrol.Controls.Add(this.HansiWork_daystab);
            this.HansiWork_tabcontrol.Controls.Add(this.HansiWork_hourstab);
            this.HansiWork_tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_tabcontrol.Location = new System.Drawing.Point(9, 82);
            this.HansiWork_tabcontrol.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_tabcontrol.Name = "HansiWork_tabcontrol";
            this.HansiWork_tabcontrol.Padding = new System.Drawing.Point(50, 7);
            this.HansiWork_tabcontrol.SelectedIndex = 0;
            this.HansiWork_tabcontrol.Size = new System.Drawing.Size(754, 404);
            this.HansiWork_tabcontrol.TabIndex = 8;
            // 
            // HansiWork_daystab
            // 
            this.HansiWork_daystab.Controls.Add(this.HansiWork_tabledays);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_dayslist);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_daysno);
            this.HansiWork_daystab.Controls.Add(this.label1);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_daysbtnadd);
            this.HansiWork_daystab.Controls.Add(this.label2);
            this.HansiWork_daystab.Location = new System.Drawing.Point(4, 34);
            this.HansiWork_daystab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_daystab.Name = "HansiWork_daystab";
            this.HansiWork_daystab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiWork_daystab.Size = new System.Drawing.Size(746, 366);
            this.HansiWork_daystab.TabIndex = 0;
            this.HansiWork_daystab.Text = "Working Days";
            this.HansiWork_daystab.UseVisualStyleBackColor = true;
            // 
            // HansiWork_tabledays
            // 
            this.HansiWork_tabledays.BackColor = System.Drawing.Color.DarkGray;
            this.HansiWork_tabledays.ColumnCount = 5;
            this.HansiWork_tabledays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.851F));
            this.HansiWork_tabledays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.149F));
            this.HansiWork_tabledays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.HansiWork_tabledays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.HansiWork_tabledays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.HansiWork_tabledays.Location = new System.Drawing.Point(55, 212);
            this.HansiWork_tabledays.Name = "HansiWork_tabledays";
            this.HansiWork_tabledays.RowCount = 2;
            this.HansiWork_tabledays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HansiWork_tabledays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HansiWork_tabledays.Size = new System.Drawing.Size(676, 100);
            this.HansiWork_tabledays.TabIndex = 6;
            this.HansiWork_tabledays.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // HansiWork_dayslist
            // 
            this.HansiWork_dayslist.FormattingEnabled = true;
            this.HansiWork_dayslist.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.HansiWork_dayslist.Location = new System.Drawing.Point(390, 71);
            this.HansiWork_dayslist.Name = "HansiWork_dayslist";
            this.HansiWork_dayslist.Size = new System.Drawing.Size(160, 58);
            this.HansiWork_dayslist.TabIndex = 5;
            // 
            // HansiWork_daysno
            // 
            this.HansiWork_daysno.Location = new System.Drawing.Point(390, 30);
            this.HansiWork_daysno.Name = "HansiWork_daysno";
            this.HansiWork_daysno.Size = new System.Drawing.Size(120, 23);
            this.HansiWork_daysno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Working Days:";
            // 
            // HansiWork_daysbtnadd
            // 
            this.HansiWork_daysbtnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_daysbtnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiWork_daysbtnadd.Location = new System.Drawing.Point(341, 152);
            this.HansiWork_daysbtnadd.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_daysbtnadd.Name = "HansiWork_daysbtnadd";
            this.HansiWork_daysbtnadd.Size = new System.Drawing.Size(74, 32);
            this.HansiWork_daysbtnadd.TabIndex = 2;
            this.HansiWork_daysbtnadd.Text = "ADD";
            this.HansiWork_daysbtnadd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of working days per week:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HansiWork_hourstab
            // 
            this.HansiWork_hourstab.Controls.Add(this.label6);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_minutes);
            this.HansiWork_hourstab.Controls.Add(this.label5);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_timeslots);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_hourstable);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_hours);
            this.HansiWork_hourstab.Controls.Add(this.label3);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_hoursaddbtn);
            this.HansiWork_hourstab.Controls.Add(this.label4);
            this.HansiWork_hourstab.Location = new System.Drawing.Point(4, 34);
            this.HansiWork_hourstab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_hourstab.Name = "HansiWork_hourstab";
            this.HansiWork_hourstab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiWork_hourstab.Size = new System.Drawing.Size(746, 366);
            this.HansiWork_hourstab.TabIndex = 1;
            this.HansiWork_hourstab.Text = "Working Hours";
            this.HansiWork_hourstab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "mins";
            // 
            // HansiWork_minutes
            // 
            this.HansiWork_minutes.Location = new System.Drawing.Point(472, 42);
            this.HansiWork_minutes.Name = "HansiWork_minutes";
            this.HansiWork_minutes.Size = new System.Drawing.Size(57, 23);
            this.HansiWork_minutes.TabIndex = 14;
            this.HansiWork_minutes.ValueChanged += new System.EventHandler(this.HansiWork_minutes_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "h";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HansiWork_timeslots
            // 
            this.HansiWork_timeslots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_timeslots.FormattingEnabled = true;
            this.HansiWork_timeslots.Items.AddRange(new object[] {
            "1h time slot",
            "30 mins time slot"});
            this.HansiWork_timeslots.Location = new System.Drawing.Point(370, 91);
            this.HansiWork_timeslots.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_timeslots.Name = "HansiWork_timeslots";
            this.HansiWork_timeslots.Size = new System.Drawing.Size(226, 25);
            this.HansiWork_timeslots.TabIndex = 12;
            this.HansiWork_timeslots.SelectedIndexChanged += new System.EventHandler(this.HansiWork_timeslots_SelectedIndexChanged);
            // 
            // HansiWork_hourstable
            // 
            this.HansiWork_hourstable.BackColor = System.Drawing.Color.DarkGray;
            this.HansiWork_hourstable.ColumnCount = 4;
            this.HansiWork_hourstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.851F));
            this.HansiWork_hourstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.149F));
            this.HansiWork_hourstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.HansiWork_hourstable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.HansiWork_hourstable.Location = new System.Drawing.Point(51, 206);
            this.HansiWork_hourstable.Name = "HansiWork_hourstable";
            this.HansiWork_hourstable.RowCount = 2;
            this.HansiWork_hourstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HansiWork_hourstable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HansiWork_hourstable.Size = new System.Drawing.Size(676, 100);
            this.HansiWork_hourstable.TabIndex = 11;
            // 
            // HansiWork_hours
            // 
            this.HansiWork_hours.Location = new System.Drawing.Point(388, 43);
            this.HansiWork_hours.Name = "HansiWork_hours";
            this.HansiWork_hours.Size = new System.Drawing.Size(57, 23);
            this.HansiWork_hours.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time Slots:";
            // 
            // HansiWork_hoursaddbtn
            // 
            this.HansiWork_hoursaddbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_hoursaddbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiWork_hoursaddbtn.Location = new System.Drawing.Point(323, 146);
            this.HansiWork_hoursaddbtn.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_hoursaddbtn.Name = "HansiWork_hoursaddbtn";
            this.HansiWork_hoursaddbtn.Size = new System.Drawing.Size(74, 32);
            this.HansiWork_hoursaddbtn.TabIndex = 8;
            this.HansiWork_hoursaddbtn.Text = "ADD";
            this.HansiWork_hoursaddbtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Working time per day(Include lunch time):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(734, 10);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 29);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Section1_WorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section1_WorkingDays";
            this.Text = "Section1_WorkingDays";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HansiWork_tabcontrol.ResumeLayout(false);
            this.HansiWork_daystab.ResumeLayout(false);
            this.HansiWork_daystab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_daysno)).EndInit();
            this.HansiWork_hourstab.ResumeLayout(false);
            this.HansiWork_hourstab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TabControl HansiWork_tabcontrol;
        private System.Windows.Forms.TabPage HansiWork_daystab;
        private System.Windows.Forms.Button HansiWork_daysbtnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage HansiWork_hourstab;
        private System.Windows.Forms.CheckedListBox HansiWork_dayslist;
        private System.Windows.Forms.NumericUpDown HansiWork_daysno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel HansiWork_tabledays;
        private System.Windows.Forms.TableLayoutPanel HansiWork_hourstable;
        private System.Windows.Forms.NumericUpDown HansiWork_hours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HansiWork_hoursaddbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HansiWork_timeslots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown HansiWork_minutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}