﻿namespace ABC_Institute___Timetable_Generator
{
    partial class Section1_Statistics
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
<<<<<<< Updated upstream
            this.button1 = new System.Windows.Forms.Button();
=======
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section1_Statistics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nishikiDStat_tabcontrol = new System.Windows.Forms.TabControl();
            this.nishikiDStat_lecturertab = new System.Windows.Forms.TabPage();
            this.nishikiDStat_lecturerchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nishikiDStat_lecturerbtnsubmit = new System.Windows.Forms.Button();
            this.nishikiDStat_lecturercmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nishikiDStat_studenttab = new System.Windows.Forms.TabPage();
            this.nishikiDStat_studnetschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nishikiDStat_studentsbtnsubmit = new System.Windows.Forms.Button();
            this.nishikiDStat_studentcmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nishikiDStat_subjectstab = new System.Windows.Forms.TabPage();
            this.nishikiDStat_subjectschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nishikiDStat_subjectsbtnsubmit = new System.Windows.Forms.Button();
            this.nishikiDStat_subjectscmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.nishikiDStat_tabcontrol.SuspendLayout();
            this.nishikiDStat_lecturertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nishikiDStat_lecturerchart)).BeginInit();
            this.nishikiDStat_studenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nishikiDStat_studnetschart)).BeginInit();
            this.nishikiDStat_subjectstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nishikiDStat_subjectschart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // button1
            // 
<<<<<<< Updated upstream
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(971, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
=======
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.nishikiDStat_tabcontrol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nishikiDStat_tabcontrol
            // 
            this.nishikiDStat_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikiDStat_tabcontrol.Controls.Add(this.nishikiDStat_lecturertab);
            this.nishikiDStat_tabcontrol.Controls.Add(this.nishikiDStat_studenttab);
            this.nishikiDStat_tabcontrol.Controls.Add(this.nishikiDStat_subjectstab);
            this.nishikiDStat_tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nishikiDStat_tabcontrol.Location = new System.Drawing.Point(15, 84);
            this.nishikiDStat_tabcontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_tabcontrol.Name = "nishikiDStat_tabcontrol";
            this.nishikiDStat_tabcontrol.Padding = new System.Drawing.Point(50, 7);
            this.nishikiDStat_tabcontrol.SelectedIndex = 0;
            this.nishikiDStat_tabcontrol.Size = new System.Drawing.Size(790, 413);
            this.nishikiDStat_tabcontrol.TabIndex = 7;
            // 
            // nishikiDStat_lecturertab
            // 
            this.nishikiDStat_lecturertab.Controls.Add(this.nishikiDStat_lecturerchart);
            this.nishikiDStat_lecturertab.Controls.Add(this.nishikiDStat_lecturerbtnsubmit);
            this.nishikiDStat_lecturertab.Controls.Add(this.nishikiDStat_lecturercmb);
            this.nishikiDStat_lecturertab.Controls.Add(this.label2);
            this.nishikiDStat_lecturertab.Location = new System.Drawing.Point(4, 34);
            this.nishikiDStat_lecturertab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_lecturertab.Name = "nishikiDStat_lecturertab";
            this.nishikiDStat_lecturertab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_lecturertab.Size = new System.Drawing.Size(782, 375);
            this.nishikiDStat_lecturertab.TabIndex = 0;
            this.nishikiDStat_lecturertab.Text = "Lecturers";
            this.nishikiDStat_lecturertab.UseVisualStyleBackColor = true;
            // 
            // nishikiDStat_lecturerchart
            // 
            this.nishikiDStat_lecturerchart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.nishikiDStat_lecturerchart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.nishikiDStat_lecturerchart.Legends.Add(legend4);
            this.nishikiDStat_lecturerchart.Location = new System.Drawing.Point(132, 92);
            this.nishikiDStat_lecturerchart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_lecturerchart.Name = "nishikiDStat_lecturerchart";
            this.nishikiDStat_lecturerchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.nishikiDStat_lecturerchart.Series.Add(series4);
            this.nishikiDStat_lecturerchart.Size = new System.Drawing.Size(535, 232);
            this.nishikiDStat_lecturerchart.TabIndex = 3;
            this.nishikiDStat_lecturerchart.Text = "chart1";
            // 
            // nishikiDStat_lecturerbtnsubmit
            // 
            this.nishikiDStat_lecturerbtnsubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_lecturerbtnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nishikiDStat_lecturerbtnsubmit.Location = new System.Drawing.Point(529, 18);
            this.nishikiDStat_lecturerbtnsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_lecturerbtnsubmit.Name = "nishikiDStat_lecturerbtnsubmit";
            this.nishikiDStat_lecturerbtnsubmit.Size = new System.Drawing.Size(74, 32);
            this.nishikiDStat_lecturerbtnsubmit.TabIndex = 2;
            this.nishikiDStat_lecturerbtnsubmit.Text = "SUBMIT";
            this.nishikiDStat_lecturerbtnsubmit.UseVisualStyleBackColor = false;
            // 
            // nishikiDStat_lecturercmb
            // 
            this.nishikiDStat_lecturercmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_lecturercmb.FormattingEnabled = true;
            this.nishikiDStat_lecturercmb.Location = new System.Drawing.Point(290, 24);
            this.nishikiDStat_lecturercmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_lecturercmb.Name = "nishikiDStat_lecturercmb";
            this.nishikiDStat_lecturercmb.Size = new System.Drawing.Size(226, 25);
            this.nishikiDStat_lecturercmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturers by:";
            // 
            // nishikiDStat_studenttab
            // 
            this.nishikiDStat_studenttab.Controls.Add(this.nishikiDStat_studnetschart);
            this.nishikiDStat_studenttab.Controls.Add(this.nishikiDStat_studentsbtnsubmit);
            this.nishikiDStat_studenttab.Controls.Add(this.nishikiDStat_studentcmb);
            this.nishikiDStat_studenttab.Controls.Add(this.label3);
            this.nishikiDStat_studenttab.Location = new System.Drawing.Point(4, 34);
            this.nishikiDStat_studenttab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_studenttab.Name = "nishikiDStat_studenttab";
            this.nishikiDStat_studenttab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_studenttab.Size = new System.Drawing.Size(782, 375);
            this.nishikiDStat_studenttab.TabIndex = 1;
            this.nishikiDStat_studenttab.Text = "Students";
            this.nishikiDStat_studenttab.UseVisualStyleBackColor = true;
            // 
            // nishikiDStat_studnetschart
            // 
            this.nishikiDStat_studnetschart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.nishikiDStat_studnetschart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.nishikiDStat_studnetschart.Legends.Add(legend5);
            this.nishikiDStat_studnetschart.Location = new System.Drawing.Point(128, 96);
            this.nishikiDStat_studnetschart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_studnetschart.Name = "nishikiDStat_studnetschart";
            this.nishikiDStat_studnetschart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.nishikiDStat_studnetschart.Series.Add(series5);
            this.nishikiDStat_studnetschart.Size = new System.Drawing.Size(530, 232);
            this.nishikiDStat_studnetschart.TabIndex = 7;
            this.nishikiDStat_studnetschart.Text = "chart2";
            // 
            // nishikiDStat_studentsbtnsubmit
            // 
            this.nishikiDStat_studentsbtnsubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_studentsbtnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nishikiDStat_studentsbtnsubmit.Location = new System.Drawing.Point(524, 22);
            this.nishikiDStat_studentsbtnsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_studentsbtnsubmit.Name = "nishikiDStat_studentsbtnsubmit";
            this.nishikiDStat_studentsbtnsubmit.Size = new System.Drawing.Size(74, 32);
            this.nishikiDStat_studentsbtnsubmit.TabIndex = 6;
            this.nishikiDStat_studentsbtnsubmit.Text = "SUBMIT";
            this.nishikiDStat_studentsbtnsubmit.UseVisualStyleBackColor = false;
            // 
            // nishikiDStat_studentcmb
            // 
            this.nishikiDStat_studentcmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_studentcmb.FormattingEnabled = true;
            this.nishikiDStat_studentcmb.Location = new System.Drawing.Point(286, 28);
            this.nishikiDStat_studentcmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_studentcmb.Name = "nishikiDStat_studentcmb";
            this.nishikiDStat_studentcmb.Size = new System.Drawing.Size(226, 25);
            this.nishikiDStat_studentcmb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lecturers by:";
            // 
            // nishikiDStat_subjectstab
            // 
            this.nishikiDStat_subjectstab.Controls.Add(this.nishikiDStat_subjectschart);
            this.nishikiDStat_subjectstab.Controls.Add(this.nishikiDStat_subjectsbtnsubmit);
            this.nishikiDStat_subjectstab.Controls.Add(this.nishikiDStat_subjectscmb);
            this.nishikiDStat_subjectstab.Controls.Add(this.label4);
            this.nishikiDStat_subjectstab.Location = new System.Drawing.Point(4, 34);
            this.nishikiDStat_subjectstab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_subjectstab.Name = "nishikiDStat_subjectstab";
            this.nishikiDStat_subjectstab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_subjectstab.Size = new System.Drawing.Size(782, 375);
            this.nishikiDStat_subjectstab.TabIndex = 2;
            this.nishikiDStat_subjectstab.Text = "Subjects";
            this.nishikiDStat_subjectstab.UseVisualStyleBackColor = true;
            // 
            // nishikiDStat_subjectschart
            // 
            this.nishikiDStat_subjectschart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.nishikiDStat_subjectschart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.nishikiDStat_subjectschart.Legends.Add(legend6);
            this.nishikiDStat_subjectschart.Location = new System.Drawing.Point(130, 98);
            this.nishikiDStat_subjectschart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_subjectschart.Name = "nishikiDStat_subjectschart";
            this.nishikiDStat_subjectschart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.nishikiDStat_subjectschart.Series.Add(series6);
            this.nishikiDStat_subjectschart.Size = new System.Drawing.Size(530, 232);
            this.nishikiDStat_subjectschart.TabIndex = 7;
            this.nishikiDStat_subjectschart.Text = "chart3";
            // 
            // nishikiDStat_subjectsbtnsubmit
            // 
            this.nishikiDStat_subjectsbtnsubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_subjectsbtnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nishikiDStat_subjectsbtnsubmit.Location = new System.Drawing.Point(526, 24);
            this.nishikiDStat_subjectsbtnsubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_subjectsbtnsubmit.Name = "nishikiDStat_subjectsbtnsubmit";
            this.nishikiDStat_subjectsbtnsubmit.Size = new System.Drawing.Size(74, 32);
            this.nishikiDStat_subjectsbtnsubmit.TabIndex = 6;
            this.nishikiDStat_subjectsbtnsubmit.Text = "SUBMIT";
            this.nishikiDStat_subjectsbtnsubmit.UseVisualStyleBackColor = false;
            // 
            // nishikiDStat_subjectscmb
            // 
            this.nishikiDStat_subjectscmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDStat_subjectscmb.FormattingEnabled = true;
            this.nishikiDStat_subjectscmb.Location = new System.Drawing.Point(288, 30);
            this.nishikiDStat_subjectscmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nishikiDStat_subjectscmb.Name = "nishikiDStat_subjectscmb";
            this.nishikiDStat_subjectscmb.Size = new System.Drawing.Size(226, 25);
            this.nishikiDStat_subjectscmb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lecturers by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(50, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(767, 17);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 29);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
>>>>>>> Stashed changes
            // 
            // Section1_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.button1);
=======
            this.ClientSize = new System.Drawing.Size(821, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.Name = "Section1_Statistics";
            this.Text = "Section1_Statistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}