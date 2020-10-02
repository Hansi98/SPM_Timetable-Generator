namespace ABC_Institute___Timetable_Generator
{
    partial class Section5_AddDayTimeslot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section5_AddDayTimeslot));
            this.hansi_daytimeAdd = new System.Windows.Forms.Button();
            this.hansi_timetableday = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hansi_timetableslot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hansi_adddaytimetablegrid = new System.Windows.Forms.DataGridView();
            this.hansi_daytimeslotname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_adddaytimetablegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hansi_daytimeAdd
            // 
            this.hansi_daytimeAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hansi_daytimeAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.hansi_daytimeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansi_daytimeAdd.Location = new System.Drawing.Point(405, 475);
            this.hansi_daytimeAdd.Margin = new System.Windows.Forms.Padding(2);
            this.hansi_daytimeAdd.Name = "hansi_daytimeAdd";
            this.hansi_daytimeAdd.Size = new System.Drawing.Size(194, 50);
            this.hansi_daytimeAdd.TabIndex = 17;
            this.hansi_daytimeAdd.Text = "ADD";
            this.hansi_daytimeAdd.UseVisualStyleBackColor = false;
            this.hansi_daytimeAdd.Click += new System.EventHandler(this.hansi_daytimeAdd_Click);
            // 
            // hansi_timetableday
            // 
            this.hansi_timetableday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_timetableday.FormattingEnabled = true;
            this.hansi_timetableday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.hansi_timetableday.Location = new System.Drawing.Point(428, 440);
            this.hansi_timetableday.Margin = new System.Windows.Forms.Padding(2);
            this.hansi_timetableday.Name = "hansi_timetableday";
            this.hansi_timetableday.Size = new System.Drawing.Size(323, 21);
            this.hansi_timetableday.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Day";
            // 
            // hansi_timetableslot
            // 
            this.hansi_timetableslot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_timetableslot.FormattingEnabled = true;
            this.hansi_timetableslot.Items.AddRange(new object[] {
            "8.30 : 9.30",
            "9.30 :10.30",
            "10.30 : 11.30",
            "11.30 : 12.30",
            "12.30 : 13.30",
            "14.30 : 15.30",
            "15.30 : 16.30",
            "16.30 : 17.30",
            "17.30 : 18.30"});
            this.hansi_timetableslot.Location = new System.Drawing.Point(428, 387);
            this.hansi_timetableslot.Margin = new System.Windows.Forms.Padding(2);
            this.hansi_timetableslot.Name = "hansi_timetableslot";
            this.hansi_timetableslot.Size = new System.Drawing.Size(323, 21);
            this.hansi_timetableslot.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "TimeSlot";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1086, -11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(977, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add Timeslot and Day for Sessions";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Timeslot and Day for ";
            // 
            // hansi_adddaytimetablegrid
            // 
            this.hansi_adddaytimetablegrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_adddaytimetablegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hansi_adddaytimetablegrid.BackgroundColor = System.Drawing.Color.Beige;
            this.hansi_adddaytimetablegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hansi_adddaytimetablegrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.hansi_adddaytimetablegrid.Location = new System.Drawing.Point(11, 72);
            this.hansi_adddaytimetablegrid.Margin = new System.Windows.Forms.Padding(2);
            this.hansi_adddaytimetablegrid.Name = "hansi_adddaytimetablegrid";
            this.hansi_adddaytimetablegrid.RowHeadersWidth = 51;
            this.hansi_adddaytimetablegrid.RowTemplate.Height = 24;
            this.hansi_adddaytimetablegrid.Size = new System.Drawing.Size(1001, 247);
            this.hansi_adddaytimetablegrid.TabIndex = 60;
            this.hansi_adddaytimetablegrid.DoubleClick += new System.EventHandler(this.hansi_adddaytimetablegrid_DoubleClick);
            // 
            // hansi_daytimeslotname
            // 
            this.hansi_daytimeslotname.Location = new System.Drawing.Point(428, 342);
            this.hansi_daytimeslotname.Name = "hansi_daytimeslotname";
            this.hansi_daytimeslotname.Size = new System.Drawing.Size(327, 20);
            this.hansi_daytimeslotname.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Section5_AddDayTimeslot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1023, 547);
            this.ControlBox = false;
            this.Controls.Add(this.hansi_daytimeslotname);
            this.Controls.Add(this.hansi_adddaytimetablegrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hansi_daytimeAdd);
            this.Controls.Add(this.hansi_timetableday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hansi_timetableslot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Section5_AddDayTimeslot";
            this.Text = "Section5_AddDayTimeslot";
            ((System.ComponentModel.ISupportInitialize)(this.hansi_adddaytimetablegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hansi_daytimeAdd;
        private System.Windows.Forms.ComboBox hansi_timetableday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hansi_timetableslot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView hansi_adddaytimetablegrid;
        private System.Windows.Forms.TextBox hansi_daytimeslotname;
    }
}