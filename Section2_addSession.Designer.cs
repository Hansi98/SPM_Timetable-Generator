namespace ABC_Institute___Timetable_Generator
{
    partial class Section2_addSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectorLecs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RS2_searchLec = new System.Windows.Forms.TextBox();
            this.R1S2LecDataGrid = new System.Windows.Forms.DataGridView();
            this.RS2_stdCount = new System.Windows.Forms.TextBox();
            this.RS2_dura = new System.Windows.Forms.ComboBox();
            this.RS2_stdGroup = new System.Windows.Forms.ComboBox();
            this.RS2_subCode = new System.Windows.Forms.ComboBox();
            this.RS2_Tag = new System.Windows.Forms.ComboBox();
            this.buildaddleclabel = new System.Windows.Forms.Label();
            this.centaddleclabel = new System.Windows.Forms.Label();
            this.deptaddleclabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeladdlec34 = new System.Windows.Forms.Label();
            this.loadMain = new System.Windows.Forms.Button();
            this.loadSub = new System.Windows.Forms.Button();
            this.button1deselectlec = new System.Windows.Forms.Button();
            this.button2selectLec = new System.Windows.Forms.Button();
            this.RS1_addLecCancel = new System.Windows.Forms.Button();
            this.RS1_addLecADD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R1S2LecDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.loadMain);
            this.panel1.Controls.Add(this.loadSub);
            this.panel1.Controls.Add(this.button1deselectlec);
            this.panel1.Controls.Add(this.button2selectLec);
            this.panel1.Controls.Add(this.selectorLecs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RS2_searchLec);
            this.panel1.Controls.Add(this.R1S2LecDataGrid);
            this.panel1.Controls.Add(this.RS2_stdCount);
            this.panel1.Controls.Add(this.RS2_dura);
            this.panel1.Controls.Add(this.RS2_stdGroup);
            this.panel1.Controls.Add(this.RS2_subCode);
            this.panel1.Controls.Add(this.RS2_Tag);
            this.panel1.Controls.Add(this.buildaddleclabel);
            this.panel1.Controls.Add(this.centaddleclabel);
            this.panel1.Controls.Add(this.deptaddleclabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RS1_addLecCancel);
            this.panel1.Controls.Add(this.RS1_addLecADD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labeladdlec34);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 741);
            this.panel1.TabIndex = 1;
            // 
            // selectorLecs
            // 
            this.selectorLecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectorLecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectorLecs.FormattingEnabled = true;
            this.selectorLecs.Location = new System.Drawing.Point(35, 296);
            this.selectorLecs.Name = "selectorLecs";
            this.selectorLecs.Size = new System.Drawing.Size(379, 28);
            this.selectorLecs.TabIndex = 45;
            this.selectorLecs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Selected Lectures";
            // 
            // RS2_searchLec
            // 
            this.RS2_searchLec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RS2_searchLec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS2_searchLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_searchLec.Location = new System.Drawing.Point(476, 69);
            this.RS2_searchLec.Name = "RS2_searchLec";
            this.RS2_searchLec.Size = new System.Drawing.Size(376, 29);
            this.RS2_searchLec.TabIndex = 43;
            this.RS2_searchLec.Text = " Search Lecturers...";
            this.RS2_searchLec.Click += new System.EventHandler(this.RS2_searchLec_Click);
            this.RS2_searchLec.TextChanged += new System.EventHandler(this.RS2_searchLec_TextChanged);
            // 
            // R1S2LecDataGrid
            // 
            this.R1S2LecDataGrid.AllowUserToAddRows = false;
            this.R1S2LecDataGrid.AllowUserToDeleteRows = false;
            this.R1S2LecDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R1S2LecDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.R1S2LecDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.R1S2LecDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.R1S2LecDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.R1S2LecDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.R1S2LecDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.R1S2LecDataGrid.Location = new System.Drawing.Point(35, 103);
            this.R1S2LecDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.R1S2LecDataGrid.MultiSelect = false;
            this.R1S2LecDataGrid.Name = "R1S2LecDataGrid";
            this.R1S2LecDataGrid.ReadOnly = true;
            this.R1S2LecDataGrid.RowHeadersWidth = 51;
            this.R1S2LecDataGrid.RowTemplate.Height = 24;
            this.R1S2LecDataGrid.Size = new System.Drawing.Size(817, 136);
            this.R1S2LecDataGrid.TabIndex = 42;
            // 
            // RS2_stdCount
            // 
            this.RS2_stdCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_stdCount.Location = new System.Drawing.Point(27, 611);
            this.RS2_stdCount.MaxLength = 6;
            this.RS2_stdCount.Name = "RS2_stdCount";
            this.RS2_stdCount.Size = new System.Drawing.Size(545, 29);
            this.RS2_stdCount.TabIndex = 41;
            // 
            // RS2_dura
            // 
            this.RS2_dura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS2_dura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_dura.FormattingEnabled = true;
            this.RS2_dura.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RS2_dura.Location = new System.Drawing.Point(27, 554);
            this.RS2_dura.Name = "RS2_dura";
            this.RS2_dura.Size = new System.Drawing.Size(541, 28);
            this.RS2_dura.TabIndex = 40;
            // 
            // RS2_stdGroup
            // 
            this.RS2_stdGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS2_stdGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_stdGroup.FormattingEnabled = true;
            this.RS2_stdGroup.Location = new System.Drawing.Point(27, 501);
            this.RS2_stdGroup.Name = "RS2_stdGroup";
            this.RS2_stdGroup.Size = new System.Drawing.Size(541, 28);
            this.RS2_stdGroup.TabIndex = 39;
            // 
            // RS2_subCode
            // 
            this.RS2_subCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS2_subCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_subCode.FormattingEnabled = true;
            this.RS2_subCode.Location = new System.Drawing.Point(27, 448);
            this.RS2_subCode.Name = "RS2_subCode";
            this.RS2_subCode.Size = new System.Drawing.Size(541, 28);
            this.RS2_subCode.TabIndex = 37;
            // 
            // RS2_Tag
            // 
            this.RS2_Tag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS2_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS2_Tag.FormattingEnabled = true;
            this.RS2_Tag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab",
            "Evaluation"});
            this.RS2_Tag.Location = new System.Drawing.Point(27, 395);
            this.RS2_Tag.Name = "RS2_Tag";
            this.RS2_Tag.Size = new System.Drawing.Size(541, 28);
            this.RS2_Tag.TabIndex = 36;
            // 
            // buildaddleclabel
            // 
            this.buildaddleclabel.AutoSize = true;
            this.buildaddleclabel.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildaddleclabel.Location = new System.Drawing.Point(26, 532);
            this.buildaddleclabel.Name = "buildaddleclabel";
            this.buildaddleclabel.Size = new System.Drawing.Size(119, 19);
            this.buildaddleclabel.TabIndex = 28;
            this.buildaddleclabel.Text = "Duration (hrs)";
            // 
            // centaddleclabel
            // 
            this.centaddleclabel.AutoSize = true;
            this.centaddleclabel.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centaddleclabel.Location = new System.Drawing.Point(26, 478);
            this.centaddleclabel.Name = "centaddleclabel";
            this.centaddleclabel.Size = new System.Drawing.Size(120, 19);
            this.centaddleclabel.TabIndex = 26;
            this.centaddleclabel.Text = "Student Group";
            // 
            // deptaddleclabel
            // 
            this.deptaddleclabel.AutoSize = true;
            this.deptaddleclabel.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptaddleclabel.Location = new System.Drawing.Point(26, 426);
            this.deptaddleclabel.Name = "deptaddleclabel";
            this.deptaddleclabel.Size = new System.Drawing.Size(108, 19);
            this.deptaddleclabel.TabIndex = 24;
            this.deptaddleclabel.Text = "Subject Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Session";
            // 
            // labeladdlec34
            // 
            this.labeladdlec34.AutoSize = true;
            this.labeladdlec34.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdlec34.Location = new System.Drawing.Point(23, 589);
            this.labeladdlec34.Name = "labeladdlec34";
            this.labeladdlec34.Size = new System.Drawing.Size(116, 19);
            this.labeladdlec34.TabIndex = 1;
            this.labeladdlec34.Text = "Student Count";
            // 
            // loadMain
            // 
            this.loadMain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loadMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMain.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadMain.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.refresh_24px;
            this.loadMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadMain.Location = new System.Drawing.Point(602, 501);
            this.loadMain.Name = "loadMain";
            this.loadMain.Size = new System.Drawing.Size(198, 32);
            this.loadMain.TabIndex = 50;
            this.loadMain.Text = "Load Main Groups";
            this.loadMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadMain.UseVisualStyleBackColor = false;
            this.loadMain.Visible = false;
            this.loadMain.Click += new System.EventHandler(this.loadMain_Click);
            // 
            // loadSub
            // 
            this.loadSub.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loadSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSub.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadSub.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.refresh_24px;
            this.loadSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadSub.Location = new System.Drawing.Point(602, 501);
            this.loadSub.Name = "loadSub";
            this.loadSub.Size = new System.Drawing.Size(187, 32);
            this.loadSub.TabIndex = 49;
            this.loadSub.Text = "Load Sub Groups";
            this.loadSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadSub.UseVisualStyleBackColor = false;
            this.loadSub.Click += new System.EventHandler(this.loadSub_Click);
            // 
            // button1deselectlec
            // 
            this.button1deselectlec.BackColor = System.Drawing.Color.Crimson;
            this.button1deselectlec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1deselectlec.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1deselectlec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1deselectlec.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.cancel_26px;
            this.button1deselectlec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1deselectlec.Location = new System.Drawing.Point(627, 284);
            this.button1deselectlec.Name = "button1deselectlec";
            this.button1deselectlec.Size = new System.Drawing.Size(192, 40);
            this.button1deselectlec.TabIndex = 47;
            this.button1deselectlec.Text = "De-Select Lecturer";
            this.button1deselectlec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1deselectlec.UseVisualStyleBackColor = false;
            this.button1deselectlec.Click += new System.EventHandler(this.button1deselectlec_Click);
            // 
            // button2selectLec
            // 
            this.button2selectLec.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2selectLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2selectLec.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2selectLec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2selectLec.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.add_30px;
            this.button2selectLec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2selectLec.Location = new System.Drawing.Point(434, 284);
            this.button2selectLec.Name = "button2selectLec";
            this.button2selectLec.Size = new System.Drawing.Size(167, 40);
            this.button2selectLec.TabIndex = 46;
            this.button2selectLec.Text = "Select Lecturer";
            this.button2selectLec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2selectLec.UseVisualStyleBackColor = false;
            this.button2selectLec.Click += new System.EventHandler(this.button2selectLec_Click);
            // 
            // RS1_addLecCancel
            // 
            this.RS1_addLecCancel.BackColor = System.Drawing.Color.Crimson;
            this.RS1_addLecCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RS1_addLecCancel.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS1_addLecCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS1_addLecCancel.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.cancel_26px;
            this.RS1_addLecCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RS1_addLecCancel.Location = new System.Drawing.Point(764, 673);
            this.RS1_addLecCancel.Name = "RS1_addLecCancel";
            this.RS1_addLecCancel.Size = new System.Drawing.Size(102, 47);
            this.RS1_addLecCancel.TabIndex = 20;
            this.RS1_addLecCancel.Text = "Cancel";
            this.RS1_addLecCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RS1_addLecCancel.UseVisualStyleBackColor = false;
            this.RS1_addLecCancel.Click += new System.EventHandler(this.RS1_addLecCancel_Click);
            // 
            // RS1_addLecADD
            // 
            this.RS1_addLecADD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RS1_addLecADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RS1_addLecADD.Font = new System.Drawing.Font("Tw Cen Classified MT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS1_addLecADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS1_addLecADD.Image = global::ABC_Institute___Timetable_Generator.Properties.Resources.add_30px;
            this.RS1_addLecADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RS1_addLecADD.Location = new System.Drawing.Point(644, 673);
            this.RS1_addLecADD.Name = "RS1_addLecADD";
            this.RS1_addLecADD.Size = new System.Drawing.Size(108, 47);
            this.RS1_addLecADD.TabIndex = 19;
            this.RS1_addLecADD.Text = "Add";
            this.RS1_addLecADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RS1_addLecADD.UseVisualStyleBackColor = false;
            this.RS1_addLecADD.Click += new System.EventHandler(this.RS1_addLecADD_Click);
            // 
            // Section2_addSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 741);
            this.Controls.Add(this.panel1);
            this.Name = "Section2_addSession";
            this.Text = "Add Sessions";
            this.Load += new System.EventHandler(this.Section2_addSession_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R1S2LecDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RS2_stdCount;
        private System.Windows.Forms.ComboBox RS2_dura;
        private System.Windows.Forms.ComboBox RS2_stdGroup;
        private System.Windows.Forms.ComboBox RS2_subCode;
        private System.Windows.Forms.ComboBox RS2_Tag;
        private System.Windows.Forms.Label buildaddleclabel;
        private System.Windows.Forms.Label centaddleclabel;
        private System.Windows.Forms.Label deptaddleclabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RS1_addLecCancel;
        private System.Windows.Forms.Button RS1_addLecADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeladdlec34;
        private System.Windows.Forms.Button button1deselectlec;
        private System.Windows.Forms.Button button2selectLec;
        private System.Windows.Forms.ComboBox selectorLecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RS2_searchLec;
        private System.Windows.Forms.DataGridView R1S2LecDataGrid;
        private System.Windows.Forms.Button loadMain;
        private System.Windows.Forms.Button loadSub;
    }
}