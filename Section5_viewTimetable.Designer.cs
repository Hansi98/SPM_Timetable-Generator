namespace ABC_Institute___Timetable_Generator
{
    partial class Section5_viewTimetable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section5_viewTimetable));
            this.btnclose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HansiTimetable_tabcontrol = new System.Windows.Forms.TabControl();
            this.HansiTimetable_lectab = new System.Windows.Forms.TabPage();
            this.HansiTimetable_Addlec = new System.Windows.Forms.Button();
            this.hansi_timelectable = new System.Windows.Forms.DataGridView();
            this.HansiTimetable_lec = new System.Windows.Forms.ComboBox();
            this.HansiTimetable_Lecdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HansiTimetable_grptab = new System.Windows.Forms.TabPage();
            this.hansi_timegrptable = new System.Windows.Forms.DataGridView();
            this.HansiTimetable_grpDown = new System.Windows.Forms.Button();
            this.HansiTimetable_Addgrp = new System.Windows.Forms.Button();
            this.HansiTimetable_grp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HansiTimetable_roomtab = new System.Windows.Forms.TabPage();
            this.hansi_timeRoomtable = new System.Windows.Forms.DataGridView();
            this.HansiTimetable_RoomDown = new System.Windows.Forms.Button();
            this.HansiTimetable_roomadd = new System.Windows.Forms.Button();
            this.HansiTimetable_room = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timetableLecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timetableGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timetableSessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableLecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HansiTimetable_tabcontrol.SuspendLayout();
            this.HansiTimetable_lectab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timelectable)).BeginInit();
            this.HansiTimetable_grptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timegrptable)).BeginInit();
            this.HansiTimetable_roomtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timeRoomtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableLecturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableSessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableLecturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(756, 11);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 29);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(103, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Generate Timetable";
            // 
            // HansiTimetable_tabcontrol
            // 
            this.HansiTimetable_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HansiTimetable_tabcontrol.Controls.Add(this.HansiTimetable_lectab);
            this.HansiTimetable_tabcontrol.Controls.Add(this.HansiTimetable_grptab);
            this.HansiTimetable_tabcontrol.Controls.Add(this.HansiTimetable_roomtab);
            this.HansiTimetable_tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_tabcontrol.Location = new System.Drawing.Point(12, 81);
            this.HansiTimetable_tabcontrol.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_tabcontrol.Name = "HansiTimetable_tabcontrol";
            this.HansiTimetable_tabcontrol.Padding = new System.Drawing.Point(50, 7);
            this.HansiTimetable_tabcontrol.SelectedIndex = 0;
            this.HansiTimetable_tabcontrol.Size = new System.Drawing.Size(790, 401);
            this.HansiTimetable_tabcontrol.TabIndex = 13;
            // 
            // HansiTimetable_lectab
            // 
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_Addlec);
            this.HansiTimetable_lectab.Controls.Add(this.hansi_timelectable);
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_lec);
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_Lecdown);
            this.HansiTimetable_lectab.Controls.Add(this.label2);
            this.HansiTimetable_lectab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_lectab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HansiTimetable_lectab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_lectab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_lectab.Name = "HansiTimetable_lectab";
            this.HansiTimetable_lectab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_lectab.Size = new System.Drawing.Size(782, 363);
            this.HansiTimetable_lectab.TabIndex = 0;
            this.HansiTimetable_lectab.Text = "Lecturer";
            this.HansiTimetable_lectab.UseVisualStyleBackColor = true;
            // 
            // HansiTimetable_Addlec
            // 
            this.HansiTimetable_Addlec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Addlec.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.HansiTimetable_Addlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Addlec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HansiTimetable_Addlec.Location = new System.Drawing.Point(260, 77);
            this.HansiTimetable_Addlec.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Addlec.Name = "HansiTimetable_Addlec";
            this.HansiTimetable_Addlec.Size = new System.Drawing.Size(145, 42);
            this.HansiTimetable_Addlec.TabIndex = 46;
            this.HansiTimetable_Addlec.Text = "VIEW";
            this.HansiTimetable_Addlec.UseVisualStyleBackColor = false;
            this.HansiTimetable_Addlec.Click += new System.EventHandler(this.HansiTimetable_Addlec_Click_1);
            // 
            // hansi_timelectable
            // 
            this.hansi_timelectable.AllowUserToDeleteRows = false;
            this.hansi_timelectable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_timelectable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hansi_timelectable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hansi_timelectable.ColumnHeadersHeight = 35;
            this.hansi_timelectable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hansi_timelectable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hansi_timelectable.Location = new System.Drawing.Point(3, 130);
            this.hansi_timelectable.Name = "hansi_timelectable";
            this.hansi_timelectable.ReadOnly = true;
            this.hansi_timelectable.RowHeadersWidth = 45;
            this.hansi_timelectable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hansi_timelectable.Size = new System.Drawing.Size(772, 213);
            this.hansi_timelectable.TabIndex = 100;
            // 
            // HansiTimetable_lec
            // 
            this.HansiTimetable_lec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_lec.DisplayMember = "fname";
            this.HansiTimetable_lec.FormattingEnabled = true;
            this.HansiTimetable_lec.Location = new System.Drawing.Point(348, 30);
            this.HansiTimetable_lec.Name = "HansiTimetable_lec";
            this.HansiTimetable_lec.Size = new System.Drawing.Size(251, 24);
            this.HansiTimetable_lec.TabIndex = 28;
            this.HansiTimetable_lec.ValueMember = "fname";
            // 
            // HansiTimetable_Lecdown
            // 
            this.HansiTimetable_Lecdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Lecdown.BackColor = System.Drawing.SystemColors.Highlight;
            this.HansiTimetable_Lecdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Lecdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HansiTimetable_Lecdown.Location = new System.Drawing.Point(418, 77);
            this.HansiTimetable_Lecdown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Lecdown.Name = "HansiTimetable_Lecdown";
            this.HansiTimetable_Lecdown.Size = new System.Drawing.Size(143, 42);
            this.HansiTimetable_Lecdown.TabIndex = 3;
            this.HansiTimetable_Lecdown.Text = "DOWNLOAD";
            this.HansiTimetable_Lecdown.UseVisualStyleBackColor = false;
            this.HansiTimetable_Lecdown.Click += new System.EventHandler(this.HansiTimetable_Lecdown_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(222, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a lecturer";
            // 
            // HansiTimetable_grptab
            // 
            this.HansiTimetable_grptab.Controls.Add(this.hansi_timegrptable);
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_grpDown);
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_Addgrp);
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_grp);
            this.HansiTimetable_grptab.Controls.Add(this.label4);
            this.HansiTimetable_grptab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_grptab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HansiTimetable_grptab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_grptab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grptab.Name = "HansiTimetable_grptab";
            this.HansiTimetable_grptab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grptab.Size = new System.Drawing.Size(782, 363);
            this.HansiTimetable_grptab.TabIndex = 1;
            this.HansiTimetable_grptab.Text = "Student Group";
            this.HansiTimetable_grptab.UseVisualStyleBackColor = true;
            // 
            // hansi_timegrptable
            // 
            this.hansi_timegrptable.AllowUserToDeleteRows = false;
            this.hansi_timegrptable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_timegrptable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hansi_timegrptable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hansi_timegrptable.ColumnHeadersHeight = 35;
            this.hansi_timegrptable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hansi_timegrptable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hansi_timegrptable.Location = new System.Drawing.Point(5, 140);
            this.hansi_timegrptable.Name = "hansi_timegrptable";
            this.hansi_timegrptable.ReadOnly = true;
            this.hansi_timegrptable.RowHeadersWidth = 45;
            this.hansi_timegrptable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hansi_timegrptable.Size = new System.Drawing.Size(772, 213);
            this.hansi_timegrptable.TabIndex = 45;
            this.hansi_timegrptable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hansi_timegrptable_CellContentClick);
            // 
            // HansiTimetable_grpDown
            // 
            this.HansiTimetable_grpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_grpDown.BackColor = System.Drawing.SystemColors.Highlight;
            this.HansiTimetable_grpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_grpDown.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HansiTimetable_grpDown.Location = new System.Drawing.Point(414, 81);
            this.HansiTimetable_grpDown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grpDown.Name = "HansiTimetable_grpDown";
            this.HansiTimetable_grpDown.Size = new System.Drawing.Size(143, 43);
            this.HansiTimetable_grpDown.TabIndex = 29;
            this.HansiTimetable_grpDown.Text = "DOWNLOAD";
            this.HansiTimetable_grpDown.UseVisualStyleBackColor = false;
            this.HansiTimetable_grpDown.Click += new System.EventHandler(this.HansiTimetable_grpDown_Click);
            // 
            // HansiTimetable_Addgrp
            // 
            this.HansiTimetable_Addgrp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Addgrp.BackColor = System.Drawing.Color.DarkCyan;
            this.HansiTimetable_Addgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Addgrp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HansiTimetable_Addgrp.Location = new System.Drawing.Point(252, 81);
            this.HansiTimetable_Addgrp.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Addgrp.Name = "HansiTimetable_Addgrp";
            this.HansiTimetable_Addgrp.Size = new System.Drawing.Size(145, 43);
            this.HansiTimetable_Addgrp.TabIndex = 28;
            this.HansiTimetable_Addgrp.Text = "VIEW";
            this.HansiTimetable_Addgrp.UseVisualStyleBackColor = false;
            this.HansiTimetable_Addgrp.Click += new System.EventHandler(this.HansiTimetable_Addgrp_Click_1);
            // 
            // HansiTimetable_grp
            // 
            this.HansiTimetable_grp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_grp.FormattingEnabled = true;
            this.HansiTimetable_grp.Location = new System.Drawing.Point(374, 36);
            this.HansiTimetable_grp.Name = "HansiTimetable_grp";
            this.HansiTimetable_grp.Size = new System.Drawing.Size(251, 24);
            this.HansiTimetable_grp.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(207, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select a Student Group";
            // 
            // HansiTimetable_roomtab
            // 
            this.HansiTimetable_roomtab.Controls.Add(this.hansi_timeRoomtable);
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_RoomDown);
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_roomadd);
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_room);
            this.HansiTimetable_roomtab.Controls.Add(this.label1);
            this.HansiTimetable_roomtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_roomtab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HansiTimetable_roomtab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_roomtab.Name = "HansiTimetable_roomtab";
            this.HansiTimetable_roomtab.Size = new System.Drawing.Size(782, 363);
            this.HansiTimetable_roomtab.TabIndex = 2;
            this.HansiTimetable_roomtab.Text = "Room";
            this.HansiTimetable_roomtab.UseVisualStyleBackColor = true;
            // 
            // hansi_timeRoomtable
            // 
            this.hansi_timeRoomtable.AllowUserToDeleteRows = false;
            this.hansi_timeRoomtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansi_timeRoomtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hansi_timeRoomtable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hansi_timeRoomtable.ColumnHeadersHeight = 35;
            this.hansi_timeRoomtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hansi_timeRoomtable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hansi_timeRoomtable.Location = new System.Drawing.Point(5, 135);
            this.hansi_timeRoomtable.Name = "hansi_timeRoomtable";
            this.hansi_timeRoomtable.ReadOnly = true;
            this.hansi_timeRoomtable.RowHeadersWidth = 45;
            this.hansi_timeRoomtable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hansi_timeRoomtable.Size = new System.Drawing.Size(772, 217);
            this.hansi_timeRoomtable.TabIndex = 45;
            // 
            // HansiTimetable_RoomDown
            // 
            this.HansiTimetable_RoomDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_RoomDown.BackColor = System.Drawing.SystemColors.Highlight;
            this.HansiTimetable_RoomDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_RoomDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HansiTimetable_RoomDown.Location = new System.Drawing.Point(405, 78);
            this.HansiTimetable_RoomDown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_RoomDown.Name = "HansiTimetable_RoomDown";
            this.HansiTimetable_RoomDown.Size = new System.Drawing.Size(143, 41);
            this.HansiTimetable_RoomDown.TabIndex = 34;
            this.HansiTimetable_RoomDown.Text = "DOWNLOAD";
            this.HansiTimetable_RoomDown.UseVisualStyleBackColor = false;
            this.HansiTimetable_RoomDown.Click += new System.EventHandler(this.HansiTimetable_RoomDown_Click);
            // 
            // HansiTimetable_roomadd
            // 
            this.HansiTimetable_roomadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_roomadd.BackColor = System.Drawing.Color.DarkViolet;
            this.HansiTimetable_roomadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_roomadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HansiTimetable_roomadd.Location = new System.Drawing.Point(245, 78);
            this.HansiTimetable_roomadd.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_roomadd.Name = "HansiTimetable_roomadd";
            this.HansiTimetable_roomadd.Size = new System.Drawing.Size(145, 42);
            this.HansiTimetable_roomadd.TabIndex = 33;
            this.HansiTimetable_roomadd.Text = "VIEW";
            this.HansiTimetable_roomadd.UseVisualStyleBackColor = false;
            this.HansiTimetable_roomadd.Click += new System.EventHandler(this.HansiTimetable_roomadd_Click_1);
            // 
            // HansiTimetable_room
            // 
            this.HansiTimetable_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_room.FormattingEnabled = true;
            this.HansiTimetable_room.Location = new System.Drawing.Point(405, 37);
            this.HansiTimetable_room.Name = "HansiTimetable_room";
            this.HansiTimetable_room.Size = new System.Drawing.Size(251, 24);
            this.HansiTimetable_room.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(177, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select a Lecture Hall / Lab Room";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Section5_viewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.HansiTimetable_tabcontrol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Section5_viewTimetable";
            this.Text = "Section4_viewTimetable";
            this.HansiTimetable_tabcontrol.ResumeLayout(false);
            this.HansiTimetable_lectab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timelectable)).EndInit();
            this.HansiTimetable_grptab.ResumeLayout(false);
            this.HansiTimetable_grptab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timegrptable)).EndInit();
            this.HansiTimetable_roomtab.ResumeLayout(false);
            this.HansiTimetable_roomtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansi_timeRoomtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableLecturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableSessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableLecturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl HansiTimetable_tabcontrol;
        private System.Windows.Forms.TabPage HansiTimetable_lectab;
        private System.Windows.Forms.Button HansiTimetable_Lecdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage HansiTimetable_grptab;
        private System.Windows.Forms.ComboBox HansiTimetable_grp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HansiTimetable_lec;
        private System.Windows.Forms.TabPage HansiTimetable_roomtab;
        private System.Windows.Forms.ComboBox HansiTimetable_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HansiTimetable_grpDown;
        private System.Windows.Forms.Button HansiTimetable_Addgrp;
        private System.Windows.Forms.Button HansiTimetable_RoomDown;
        private System.Windows.Forms.Button HansiTimetable_roomadd;
        private System.Windows.Forms.BindingSource timetableLecturerBindingSource1;
        private System.Windows.Forms.BindingSource timetableLecturerBindingSource;
        private System.Windows.Forms.BindingSource timetableGroupBindingSource;
        private System.Windows.Forms.BindingSource timetableRoomBindingSource;
        private System.Windows.Forms.BindingSource timetableSessionsBindingSource;
        private System.Windows.Forms.DataGridView hansi_timegrptable;
        private System.Windows.Forms.DataGridView hansi_timeRoomtable;
        private System.Windows.Forms.Button HansiTimetable_Addlec;
        private System.Windows.Forms.DataGridView hansi_timelectable;
    }
}