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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section1_WorkingDays));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HansiWork_tabcontrol = new System.Windows.Forms.TabControl();
            this.HansiWork_daystab = new System.Windows.Forms.TabPage();
            this.hansiwork_daystable = new System.Windows.Forms.DataGridView();
            this.HansiWork_daysbtnupdate = new System.Windows.Forms.Button();
            this.hansisuncheckBox = new System.Windows.Forms.CheckBox();
            this.hansisatcheckBox = new System.Windows.Forms.CheckBox();
            this.hansifricheckBox = new System.Windows.Forms.CheckBox();
            this.hansithurscheckBox = new System.Windows.Forms.CheckBox();
            this.hansiwedcheckBox = new System.Windows.Forms.CheckBox();
            this.hansituesdaycheckBox = new System.Windows.Forms.CheckBox();
            this.hansimondaycheckBox = new System.Windows.Forms.CheckBox();
            this.HansiWork_daysno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HansiWork_daysbtnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HansiWork_hourstab = new System.Windows.Forms.TabPage();
            this.hansiwork_hourupdate = new System.Windows.Forms.Button();
            this.hansiwork_hourstable = new System.Windows.Forms.DataGridView();
            this.h_update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.h_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hansiwork_hourslots = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HansiWork_minutes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.HansiWork_hours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.HansiWork_hoursaddbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hwrk_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hwrk_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfWrkDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hansiworkdaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfWrkHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingSlotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hansiworkhoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HansiWork_tabcontrol.SuspendLayout();
            this.HansiWork_daystab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_daystable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_daysno)).BeginInit();
            this.HansiWork_hourstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_hourstable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansiworkdaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansiworkhoursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.HansiWork_tabcontrol);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 518);
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
            this.HansiWork_tabcontrol.Size = new System.Drawing.Size(790, 413);
            this.HansiWork_tabcontrol.TabIndex = 8;
            // 
            // HansiWork_daystab
            // 
            this.HansiWork_daystab.Controls.Add(this.hansiwork_daystable);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_daysbtnupdate);
            this.HansiWork_daystab.Controls.Add(this.hansisuncheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansisatcheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansifricheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansithurscheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansiwedcheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansituesdaycheckBox);
            this.HansiWork_daystab.Controls.Add(this.hansimondaycheckBox);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_daysno);
            this.HansiWork_daystab.Controls.Add(this.label1);
            this.HansiWork_daystab.Controls.Add(this.HansiWork_daysbtnadd);
            this.HansiWork_daystab.Controls.Add(this.label2);
            this.HansiWork_daystab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_daystab.Location = new System.Drawing.Point(4, 34);
            this.HansiWork_daystab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_daystab.Name = "HansiWork_daystab";
            this.HansiWork_daystab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiWork_daystab.Size = new System.Drawing.Size(782, 375);
            this.HansiWork_daystab.TabIndex = 0;
            this.HansiWork_daystab.Text = "Working Days";
            this.HansiWork_daystab.UseVisualStyleBackColor = true;
            // 
            // hansiwork_daystable
            // 
            this.hansiwork_daystable.AllowUserToDeleteRows = false;
            this.hansiwork_daystable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansiwork_daystable.AutoGenerateColumns = false;
            this.hansiwork_daystable.ColumnHeadersHeight = 35;
            this.hansiwork_daystable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hansiwork_daystable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wdIDDataGridViewTextBoxColumn,
            this.noOfWrkDaysDataGridViewTextBoxColumn,
            this.workingDaysDataGridViewTextBoxColumn,
            this.hwrk_Update,
            this.hwrk_delete});
            this.hansiwork_daystable.DataSource = this.hansiworkdaysBindingSource;
            this.hansiwork_daystable.Location = new System.Drawing.Point(15, 201);
            this.hansiwork_daystable.Name = "hansiwork_daystable";
            this.hansiwork_daystable.ReadOnly = true;
            this.hansiwork_daystable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.hansiwork_daystable.Size = new System.Drawing.Size(762, 159);
            this.hansiwork_daystable.TabIndex = 15;
            this.hansiwork_daystable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hansiwork_daystable_CellContentClick);
            // 
            // HansiWork_daysbtnupdate
            // 
            this.HansiWork_daysbtnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_daysbtnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HansiWork_daysbtnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_daysbtnupdate.Location = new System.Drawing.Point(441, 153);
            this.HansiWork_daysbtnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_daysbtnupdate.Name = "HansiWork_daysbtnupdate";
            this.HansiWork_daysbtnupdate.Size = new System.Drawing.Size(109, 32);
            this.HansiWork_daysbtnupdate.TabIndex = 3;
            this.HansiWork_daysbtnupdate.Text = "UPDATE";
            this.HansiWork_daysbtnupdate.UseVisualStyleBackColor = false;
            this.HansiWork_daysbtnupdate.Click += new System.EventHandler(this.HansiWork_daysbtnupdate_Click);
            // 
            // hansisuncheckBox
            // 
            this.hansisuncheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansisuncheckBox.AutoSize = true;
            this.hansisuncheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansisuncheckBox.Location = new System.Drawing.Point(610, 59);
            this.hansisuncheckBox.Name = "hansisuncheckBox";
            this.hansisuncheckBox.Size = new System.Drawing.Size(76, 22);
            this.hansisuncheckBox.TabIndex = 14;
            this.hansisuncheckBox.Text = "Sunday";
            this.hansisuncheckBox.UseVisualStyleBackColor = true;
            // 
            // hansisatcheckBox
            // 
            this.hansisatcheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansisatcheckBox.AutoSize = true;
            this.hansisatcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansisatcheckBox.Location = new System.Drawing.Point(493, 108);
            this.hansisatcheckBox.Name = "hansisatcheckBox";
            this.hansisatcheckBox.Size = new System.Drawing.Size(85, 22);
            this.hansisatcheckBox.TabIndex = 13;
            this.hansisatcheckBox.Text = "Saturday";
            this.hansisatcheckBox.UseVisualStyleBackColor = true;
            // 
            // hansifricheckBox
            // 
            this.hansifricheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansifricheckBox.AutoSize = true;
            this.hansifricheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansifricheckBox.Location = new System.Drawing.Point(493, 81);
            this.hansifricheckBox.Name = "hansifricheckBox";
            this.hansifricheckBox.Size = new System.Drawing.Size(67, 22);
            this.hansifricheckBox.TabIndex = 12;
            this.hansifricheckBox.Text = "Friday";
            this.hansifricheckBox.UseVisualStyleBackColor = true;
            // 
            // hansithurscheckBox
            // 
            this.hansithurscheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansithurscheckBox.AutoSize = true;
            this.hansithurscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansithurscheckBox.Location = new System.Drawing.Point(493, 59);
            this.hansithurscheckBox.Name = "hansithurscheckBox";
            this.hansithurscheckBox.Size = new System.Drawing.Size(88, 22);
            this.hansithurscheckBox.TabIndex = 11;
            this.hansithurscheckBox.Text = "Thursday";
            this.hansithurscheckBox.UseVisualStyleBackColor = true;
            // 
            // hansiwedcheckBox
            // 
            this.hansiwedcheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansiwedcheckBox.AutoSize = true;
            this.hansiwedcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansiwedcheckBox.Location = new System.Drawing.Point(372, 110);
            this.hansiwedcheckBox.Name = "hansiwedcheckBox";
            this.hansiwedcheckBox.Size = new System.Drawing.Size(97, 22);
            this.hansiwedcheckBox.TabIndex = 10;
            this.hansiwedcheckBox.Text = "Wednsday";
            this.hansiwedcheckBox.UseVisualStyleBackColor = true;
            // 
            // hansituesdaycheckBox
            // 
            this.hansituesdaycheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansituesdaycheckBox.AutoSize = true;
            this.hansituesdaycheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansituesdaycheckBox.Location = new System.Drawing.Point(372, 83);
            this.hansituesdaycheckBox.Name = "hansituesdaycheckBox";
            this.hansituesdaycheckBox.Size = new System.Drawing.Size(83, 22);
            this.hansituesdaycheckBox.TabIndex = 9;
            this.hansituesdaycheckBox.Text = "Tuesday";
            this.hansituesdaycheckBox.UseVisualStyleBackColor = true;
            // 
            // hansimondaycheckBox
            // 
            this.hansimondaycheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansimondaycheckBox.AutoSize = true;
            this.hansimondaycheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansimondaycheckBox.Location = new System.Drawing.Point(372, 59);
            this.hansimondaycheckBox.Name = "hansimondaycheckBox";
            this.hansimondaycheckBox.Size = new System.Drawing.Size(80, 22);
            this.hansimondaycheckBox.TabIndex = 8;
            this.hansimondaycheckBox.Text = "Monday";
            this.hansimondaycheckBox.UseVisualStyleBackColor = true;
            // 
            // HansiWork_daysno
            // 
            this.HansiWork_daysno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_daysno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_daysno.Location = new System.Drawing.Point(372, 29);
            this.HansiWork_daysno.Name = "HansiWork_daysno";
            this.HansiWork_daysno.Size = new System.Drawing.Size(303, 24);
            this.HansiWork_daysno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 83);
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
            this.HansiWork_daysbtnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_daysbtnadd.Location = new System.Drawing.Point(307, 153);
            this.HansiWork_daysbtnadd.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_daysbtnadd.Name = "HansiWork_daysbtnadd";
            this.HansiWork_daysbtnadd.Size = new System.Drawing.Size(113, 32);
            this.HansiWork_daysbtnadd.TabIndex = 2;
            this.HansiWork_daysbtnadd.Text = "ADD";
            this.HansiWork_daysbtnadd.UseVisualStyleBackColor = false;
            this.HansiWork_daysbtnadd.Click += new System.EventHandler(this.HansiWork_daysbtnadd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of working days per week:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HansiWork_hourstab
            // 
            this.HansiWork_hourstab.Controls.Add(this.hansiwork_hourupdate);
            this.HansiWork_hourstab.Controls.Add(this.hansiwork_hourstable);
            this.HansiWork_hourstab.Controls.Add(this.hansiwork_hourslots);
            this.HansiWork_hourstab.Controls.Add(this.label6);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_minutes);
            this.HansiWork_hourstab.Controls.Add(this.label5);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_hours);
            this.HansiWork_hourstab.Controls.Add(this.label3);
            this.HansiWork_hourstab.Controls.Add(this.HansiWork_hoursaddbtn);
            this.HansiWork_hourstab.Controls.Add(this.label4);
            this.HansiWork_hourstab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_hourstab.Location = new System.Drawing.Point(4, 34);
            this.HansiWork_hourstab.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_hourstab.Name = "HansiWork_hourstab";
            this.HansiWork_hourstab.Padding = new System.Windows.Forms.Padding(2);
            this.HansiWork_hourstab.Size = new System.Drawing.Size(782, 375);
            this.HansiWork_hourstab.TabIndex = 1;
            this.HansiWork_hourstab.Text = "Working Hours";
            this.HansiWork_hourstab.UseVisualStyleBackColor = true;
            // 
            // hansiwork_hourupdate
            // 
            this.hansiwork_hourupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansiwork_hourupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hansiwork_hourupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hansiwork_hourupdate.Location = new System.Drawing.Point(443, 142);
            this.hansiwork_hourupdate.Margin = new System.Windows.Forms.Padding(2);
            this.hansiwork_hourupdate.Name = "hansiwork_hourupdate";
            this.hansiwork_hourupdate.Size = new System.Drawing.Size(119, 32);
            this.hansiwork_hourupdate.TabIndex = 18;
            this.hansiwork_hourupdate.Text = "UPDATE";
            this.hansiwork_hourupdate.UseVisualStyleBackColor = false;
            this.hansiwork_hourupdate.Click += new System.EventHandler(this.hansiwork_hourupdate_Click);
            // 
            // hansiwork_hourstable
            // 
            this.hansiwork_hourstable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hansiwork_hourstable.AutoGenerateColumns = false;
            this.hansiwork_hourstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hansiwork_hourstable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.whIDDataGridViewTextBoxColumn,
            this.noOfWrkHoursDataGridViewTextBoxColumn,
            this.workingSlotsDataGridViewTextBoxColumn,
            this.h_update,
            this.h_delete});
            this.hansiwork_hourstable.DataSource = this.hansiworkhoursBindingSource;
            this.hansiwork_hourstable.Location = new System.Drawing.Point(5, 188);
            this.hansiwork_hourstable.Name = "hansiwork_hourstable";
            this.hansiwork_hourstable.Size = new System.Drawing.Size(772, 159);
            this.hansiwork_hourstable.TabIndex = 17;
            this.hansiwork_hourstable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hansiwork_hourstable_CellContentClick);
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
            // hansiwork_hourslots
            // 
            this.hansiwork_hourslots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hansiwork_hourslots.Location = new System.Drawing.Point(404, 93);
            this.hansiwork_hourslots.Name = "hansiwork_hourslots";
            this.hansiwork_hourslots.Size = new System.Drawing.Size(266, 22);
            this.hansiwork_hourslots.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "mins";
            // 
            // HansiWork_minutes
            // 
            this.HansiWork_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_minutes.Location = new System.Drawing.Point(528, 45);
            this.HansiWork_minutes.Name = "HansiWork_minutes";
            this.HansiWork_minutes.Size = new System.Drawing.Size(97, 22);
            this.HansiWork_minutes.TabIndex = 14;
            this.HansiWork_minutes.ValueChanged += new System.EventHandler(this.HansiWork_minutes_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "h";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HansiWork_hours
            // 
            this.HansiWork_hours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HansiWork_hours.Location = new System.Drawing.Point(405, 44);
            this.HansiWork_hours.Name = "HansiWork_hours";
            this.HansiWork_hours.Size = new System.Drawing.Size(96, 22);
            this.HansiWork_hours.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 97);
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
            this.HansiWork_hoursaddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HansiWork_hoursaddbtn.Location = new System.Drawing.Point(299, 142);
            this.HansiWork_hoursaddbtn.Margin = new System.Windows.Forms.Padding(2);
            this.HansiWork_hoursaddbtn.Name = "HansiWork_hoursaddbtn";
            this.HansiWork_hoursaddbtn.Size = new System.Drawing.Size(119, 32);
            this.HansiWork_hoursaddbtn.TabIndex = 8;
            this.HansiWork_hoursaddbtn.Text = "ADD";
            this.HansiWork_hoursaddbtn.UseVisualStyleBackColor = false;
            this.HansiWork_hoursaddbtn.Click += new System.EventHandler(this.HansiWork_hoursaddbtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 46);
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
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(770, 10);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 29);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            // wdIDDataGridViewTextBoxColumn
            // 
            this.wdIDDataGridViewTextBoxColumn.DataPropertyName = "wdID";
            this.wdIDDataGridViewTextBoxColumn.HeaderText = "wdID";
            this.wdIDDataGridViewTextBoxColumn.Name = "wdIDDataGridViewTextBoxColumn";
            this.wdIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wdIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // noOfWrkDaysDataGridViewTextBoxColumn
            // 
            this.noOfWrkDaysDataGridViewTextBoxColumn.DataPropertyName = "noOfWrkDays";
            this.noOfWrkDaysDataGridViewTextBoxColumn.HeaderText = "noOfWrkDays";
            this.noOfWrkDaysDataGridViewTextBoxColumn.Name = "noOfWrkDaysDataGridViewTextBoxColumn";
            this.noOfWrkDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfWrkDaysDataGridViewTextBoxColumn.Width = 150;
            // 
            // workingDaysDataGridViewTextBoxColumn
            // 
            this.workingDaysDataGridViewTextBoxColumn.DataPropertyName = "WorkingDays";
            this.workingDaysDataGridViewTextBoxColumn.HeaderText = "WorkingDays";
            this.workingDaysDataGridViewTextBoxColumn.Name = "workingDaysDataGridViewTextBoxColumn";
            this.workingDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingDaysDataGridViewTextBoxColumn.Width = 480;
            // 
            // hansiworkdaysBindingSource
            // 
            this.hansiworkdaysBindingSource.DataSource = typeof(ABC_Institute___Timetable_Generator.hansiworkdays);
            // 
            // whIDDataGridViewTextBoxColumn
            // 
            this.whIDDataGridViewTextBoxColumn.DataPropertyName = "whID";
            this.whIDDataGridViewTextBoxColumn.HeaderText = "whID";
            this.whIDDataGridViewTextBoxColumn.Name = "whIDDataGridViewTextBoxColumn";
            this.whIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // noOfWrkHoursDataGridViewTextBoxColumn
            // 
            this.noOfWrkHoursDataGridViewTextBoxColumn.DataPropertyName = "noOfWrkHours";
            this.noOfWrkHoursDataGridViewTextBoxColumn.HeaderText = "noOfWrkHours";
            this.noOfWrkHoursDataGridViewTextBoxColumn.Name = "noOfWrkHoursDataGridViewTextBoxColumn";
            this.noOfWrkHoursDataGridViewTextBoxColumn.Width = 250;
            // 
            // workingSlotsDataGridViewTextBoxColumn
            // 
            this.workingSlotsDataGridViewTextBoxColumn.DataPropertyName = "WorkingSlots";
            this.workingSlotsDataGridViewTextBoxColumn.HeaderText = "WorkingSlots";
            this.workingSlotsDataGridViewTextBoxColumn.Name = "workingSlotsDataGridViewTextBoxColumn";
            this.workingSlotsDataGridViewTextBoxColumn.Width = 430;
            // 
            // hansiworkhoursBindingSource
            // 
            this.hansiworkhoursBindingSource.DataSource = typeof(ABC_Institute___Timetable_Generator.hansiworkhours);
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
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_daystable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_daysno)).EndInit();
            this.HansiWork_hourstab.ResumeLayout(false);
            this.HansiWork_hourstab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hansiwork_hourstable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HansiWork_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansiworkdaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansiworkhoursBindingSource)).EndInit();
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
        private System.Windows.Forms.NumericUpDown HansiWork_daysno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HansiWork_hours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HansiWork_hoursaddbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown HansiWork_minutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox hansisuncheckBox;
        private System.Windows.Forms.CheckBox hansisatcheckBox;
        private System.Windows.Forms.CheckBox hansifricheckBox;
        private System.Windows.Forms.CheckBox hansithurscheckBox;
        private System.Windows.Forms.CheckBox hansiwedcheckBox;
        private System.Windows.Forms.CheckBox hansituesdaycheckBox;
        private System.Windows.Forms.CheckBox hansimondaycheckBox;
        private System.Windows.Forms.Button HansiWork_daysbtnupdate;
        private System.Windows.Forms.DataGridView hansiwork_daystable;
        private System.Windows.Forms.TextBox hansiwork_hourslots;
        private System.Windows.Forms.DataGridView hansiwork_hourstable;
        private System.Windows.Forms.BindingSource hansiworkdaysBindingSource;
        private System.Windows.Forms.BindingSource hansiworkhoursBindingSource;
        private System.Windows.Forms.Button hansiwork_hourupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn whIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfWrkHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingSlotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn h_update;
        private System.Windows.Forms.DataGridViewButtonColumn h_delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfWrkDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn hwrk_Update;
        private System.Windows.Forms.DataGridViewButtonColumn hwrk_delete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}