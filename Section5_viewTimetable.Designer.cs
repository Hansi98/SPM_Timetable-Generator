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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section5_viewTimetable));
            this.btnclose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HansiTimetable_tabcontrol = new System.Windows.Forms.TabControl();
            this.HansiTimetable_lectab = new System.Windows.Forms.TabPage();
            this.hansiwork_daystable = new System.Windows.Forms.DataGridView();
            this.hwrk_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hwrk_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HansiTimetable_Lecdown = new System.Windows.Forms.Button();
            this.HansiTimetable_Addlec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HansiTimetable_grptab = new System.Windows.Forms.TabPage();
            this.HansiTimetable_grp = new System.Windows.Forms.ComboBox();
            this.hansiwork_hourstable = new System.Windows.Forms.DataGridView();
            this.h_update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.h_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.HansiTimetable_roomtab = new System.Windows.Forms.TabPage();
            this.HansiTimetable_lec = new System.Windows.Forms.ComboBox();
            this.HansiTimetable_room = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.HansiTimetable_grpDown = new System.Windows.Forms.Button();
            this.HansiTimetable_Addgrp = new System.Windows.Forms.Button();
            this.HansiTimetable_RoomDown = new System.Windows.Forms.Button();
            this.HansiTimetable_roomadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HansiTimetable_tabcontrol.SuspendLayout();
            this.HansiTimetable_lectab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_daystable)).BeginInit();
            this.HansiTimetable_grptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_hourstable)).BeginInit();
            this.HansiTimetable_roomtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label7.Location = new System.Drawing.Point(103, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Generate Timetable";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_lec);
            this.HansiTimetable_lectab.Controls.Add(this.hansiwork_daystable);
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_Lecdown);
            this.HansiTimetable_lectab.Controls.Add(this.HansiTimetable_Addlec);
            this.HansiTimetable_lectab.Controls.Add(this.label2);
            this.HansiTimetable_lectab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_lectab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_lectab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_lectab.Name = "HansiTimetable_lectab";
            this.HansiTimetable_lectab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_lectab.Size = new System.Drawing.Size(782, 363);
            this.HansiTimetable_lectab.TabIndex = 0;
            this.HansiTimetable_lectab.Text = "Lecturer";
            this.HansiTimetable_lectab.UseVisualStyleBackColor = true;
            // 
            // hansiwork_daystable
            // 
            this.hansiwork_daystable.AllowUserToDeleteRows = false;
            this.hansiwork_daystable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansiwork_daystable.ColumnHeadersHeight = 35;
            this.hansiwork_daystable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hansiwork_daystable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hwrk_Update,
            this.hwrk_delete});
            this.hansiwork_daystable.Location = new System.Drawing.Point(15, 135);
            this.hansiwork_daystable.Name = "hansiwork_daystable";
            this.hansiwork_daystable.ReadOnly = true;
            this.hansiwork_daystable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.hansiwork_daystable.Size = new System.Drawing.Size(762, 213);
            this.hansiwork_daystable.TabIndex = 15;
            // 
            // hwrk_Update
            // 
            this.hwrk_Update.HeaderText = "Update";
            this.hwrk_Update.Name = "hwrk_Update";
            this.hwrk_Update.ReadOnly = true;
            this.hwrk_Update.Text = "Update";
            this.hwrk_Update.UseColumnTextForButtonValue = true;
            this.hwrk_Update.Width = 240;
            // 
            // hwrk_delete
            // 
            this.hwrk_delete.HeaderText = "Delete";
            this.hwrk_delete.Name = "hwrk_delete";
            this.hwrk_delete.ReadOnly = true;
            this.hwrk_delete.Text = "Delete";
            this.hwrk_delete.UseColumnTextForButtonValue = true;
            this.hwrk_delete.Width = 240;
            // 
            // HansiTimetable_Lecdown
            // 
            this.HansiTimetable_Lecdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Lecdown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_Lecdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Lecdown.Location = new System.Drawing.Point(418, 86);
            this.HansiTimetable_Lecdown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Lecdown.Name = "HansiTimetable_Lecdown";
            this.HansiTimetable_Lecdown.Size = new System.Drawing.Size(143, 33);
            this.HansiTimetable_Lecdown.TabIndex = 3;
            this.HansiTimetable_Lecdown.Text = "DOWNLOAD";
            this.HansiTimetable_Lecdown.UseVisualStyleBackColor = false;
            // 
            // HansiTimetable_Addlec
            // 
            this.HansiTimetable_Addlec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Addlec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_Addlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Addlec.Location = new System.Drawing.Point(243, 87);
            this.HansiTimetable_Addlec.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Addlec.Name = "HansiTimetable_Addlec";
            this.HansiTimetable_Addlec.Size = new System.Drawing.Size(145, 32);
            this.HansiTimetable_Addlec.TabIndex = 2;
            this.HansiTimetable_Addlec.Text = "VIEW ";
            this.HansiTimetable_Addlec.UseVisualStyleBackColor = false;
            this.HansiTimetable_Addlec.Click += new System.EventHandler(this.HansiWork_daysbtnadd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a lecturer";
            // 
            // HansiTimetable_grptab
            // 
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_grpDown);
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_Addgrp);
            this.HansiTimetable_grptab.Controls.Add(this.HansiTimetable_grp);
            this.HansiTimetable_grptab.Controls.Add(this.hansiwork_hourstable);
            this.HansiTimetable_grptab.Controls.Add(this.label4);
            this.HansiTimetable_grptab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_grptab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_grptab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grptab.Name = "HansiTimetable_grptab";
            this.HansiTimetable_grptab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grptab.Size = new System.Drawing.Size(782, 375);
            this.HansiTimetable_grptab.TabIndex = 1;
            this.HansiTimetable_grptab.Text = "Student Group";
            this.HansiTimetable_grptab.UseVisualStyleBackColor = true;
            // 
            // HansiTimetable_grp
            // 
            this.HansiTimetable_grp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_grp.FormattingEnabled = true;
            this.HansiTimetable_grp.Items.AddRange(new object[] {
            "1h time slot",
            "30 minutes time slot"});
            this.HansiTimetable_grp.Location = new System.Drawing.Point(405, 46);
            this.HansiTimetable_grp.Name = "HansiTimetable_grp";
            this.HansiTimetable_grp.Size = new System.Drawing.Size(251, 24);
            this.HansiTimetable_grp.TabIndex = 27;
            // 
            // hansiwork_hourstable
            // 
            this.hansiwork_hourstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansiwork_hourstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hansiwork_hourstable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h_update,
            this.h_delete});
            this.hansiwork_hourstable.Location = new System.Drawing.Point(5, 141);
            this.hansiwork_hourstable.Name = "hansiwork_hourstable";
            this.hansiwork_hourstable.Size = new System.Drawing.Size(772, 206);
            this.hansiwork_hourstable.TabIndex = 17;
            // 
            // h_update
            // 
            this.h_update.HeaderText = "Update";
            this.h_update.Name = "h_update";
            this.h_update.Text = "Update";
            this.h_update.UseColumnTextForButtonValue = true;
            this.h_update.Width = 200;
            // 
            // h_delete
            // 
            this.h_delete.HeaderText = "Delete";
            this.h_delete.Name = "h_delete";
            this.h_delete.Text = "Delete";
            this.h_delete.UseColumnTextForButtonValue = true;
            this.h_delete.Width = 200;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select a Student Group";
            // 
            // HansiTimetable_roomtab
            // 
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_RoomDown);
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_roomadd);
            this.HansiTimetable_roomtab.Controls.Add(this.HansiTimetable_room);
            this.HansiTimetable_roomtab.Controls.Add(this.dataGridView1);
            this.HansiTimetable_roomtab.Controls.Add(this.label1);
            this.HansiTimetable_roomtab.Location = new System.Drawing.Point(4, 34);
            this.HansiTimetable_roomtab.Name = "HansiTimetable_roomtab";
            this.HansiTimetable_roomtab.Size = new System.Drawing.Size(782, 375);
            this.HansiTimetable_roomtab.TabIndex = 2;
            this.HansiTimetable_roomtab.Text = "Room";
            this.HansiTimetable_roomtab.UseVisualStyleBackColor = true;
            // 
            // HansiTimetable_lec
            // 
            this.HansiTimetable_lec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_lec.FormattingEnabled = true;
            this.HansiTimetable_lec.Items.AddRange(new object[] {
            "1h time slot",
            "30 minutes time slot"});
            this.HansiTimetable_lec.Location = new System.Drawing.Point(348, 30);
            this.HansiTimetable_lec.Name = "HansiTimetable_lec";
            this.HansiTimetable_lec.Size = new System.Drawing.Size(251, 24);
            this.HansiTimetable_lec.TabIndex = 28;
            // 
            // HansiTimetable_room
            // 
            this.HansiTimetable_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_room.FormattingEnabled = true;
            this.HansiTimetable_room.Items.AddRange(new object[] {
            "1h time slot",
            "30 minutes time slot"});
            this.HansiTimetable_room.Location = new System.Drawing.Point(405, 37);
            this.HansiTimetable_room.Name = "HansiTimetable_room";
            this.HansiTimetable_room.Size = new System.Drawing.Size(251, 25);
            this.HansiTimetable_room.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 221);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Update";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Update";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 200;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 200;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select a Lecture Hall / Lab Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HansiTimetable_grpDown
            // 
            this.HansiTimetable_grpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_grpDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_grpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_grpDown.Location = new System.Drawing.Point(409, 93);
            this.HansiTimetable_grpDown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_grpDown.Name = "HansiTimetable_grpDown";
            this.HansiTimetable_grpDown.Size = new System.Drawing.Size(143, 33);
            this.HansiTimetable_grpDown.TabIndex = 29;
            this.HansiTimetable_grpDown.Text = "DOWNLOAD";
            this.HansiTimetable_grpDown.UseVisualStyleBackColor = false;
            // 
            // HansiTimetable_Addgrp
            // 
            this.HansiTimetable_Addgrp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_Addgrp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_Addgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_Addgrp.Location = new System.Drawing.Point(234, 94);
            this.HansiTimetable_Addgrp.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_Addgrp.Name = "HansiTimetable_Addgrp";
            this.HansiTimetable_Addgrp.Size = new System.Drawing.Size(145, 32);
            this.HansiTimetable_Addgrp.TabIndex = 28;
            this.HansiTimetable_Addgrp.Text = "VIEW";
            this.HansiTimetable_Addgrp.UseVisualStyleBackColor = false;
            // 
            // HansiTimetable_RoomDown
            // 
            this.HansiTimetable_RoomDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_RoomDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_RoomDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_RoomDown.Location = new System.Drawing.Point(405, 79);
            this.HansiTimetable_RoomDown.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_RoomDown.Name = "HansiTimetable_RoomDown";
            this.HansiTimetable_RoomDown.Size = new System.Drawing.Size(143, 33);
            this.HansiTimetable_RoomDown.TabIndex = 34;
            this.HansiTimetable_RoomDown.Text = "DOWNLOAD";
            this.HansiTimetable_RoomDown.UseVisualStyleBackColor = false;
            // 
            // HansiTimetable_roomadd
            // 
            this.HansiTimetable_roomadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiTimetable_roomadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiTimetable_roomadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiTimetable_roomadd.Location = new System.Drawing.Point(245, 80);
            this.HansiTimetable_roomadd.Margin = new System.Windows.Forms.Padding(2);
            this.HansiTimetable_roomadd.Name = "HansiTimetable_roomadd";
            this.HansiTimetable_roomadd.Size = new System.Drawing.Size(145, 32);
            this.HansiTimetable_roomadd.TabIndex = 33;
            this.HansiTimetable_roomadd.Text = "VIEW";
            this.HansiTimetable_roomadd.UseVisualStyleBackColor = false;
            // 
            // Section4_viewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.HansiTimetable_tabcontrol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Name = "Section4_viewTimetable";
            this.Text = "Section4_viewTimetable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HansiTimetable_tabcontrol.ResumeLayout(false);
            this.HansiTimetable_lectab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_daystable)).EndInit();
            this.HansiTimetable_grptab.ResumeLayout(false);
            this.HansiTimetable_grptab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_hourstable)).EndInit();
            this.HansiTimetable_roomtab.ResumeLayout(false);
            this.HansiTimetable_roomtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl HansiTimetable_tabcontrol;
        private System.Windows.Forms.TabPage HansiTimetable_lectab;
        private System.Windows.Forms.DataGridView hansiwork_daystable;
        private System.Windows.Forms.DataGridViewButtonColumn hwrk_Update;
        private System.Windows.Forms.DataGridViewButtonColumn hwrk_delete;
        private System.Windows.Forms.Button HansiTimetable_Lecdown;
        private System.Windows.Forms.Button HansiTimetable_Addlec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage HansiTimetable_grptab;
        private System.Windows.Forms.ComboBox HansiTimetable_grp;
        private System.Windows.Forms.DataGridView hansiwork_hourstable;
        private System.Windows.Forms.DataGridViewButtonColumn h_update;
        private System.Windows.Forms.DataGridViewButtonColumn h_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HansiTimetable_lec;
        private System.Windows.Forms.TabPage HansiTimetable_roomtab;
        private System.Windows.Forms.ComboBox HansiTimetable_room;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HansiTimetable_grpDown;
        private System.Windows.Forms.Button HansiTimetable_Addgrp;
        private System.Windows.Forms.Button HansiTimetable_RoomDown;
        private System.Windows.Forms.Button HansiTimetable_roomadd;
    }
}