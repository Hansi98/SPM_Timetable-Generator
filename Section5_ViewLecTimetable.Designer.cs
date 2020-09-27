namespace ABC_Institute___Timetable_Generator
{
    partial class Section5_ViewLecTimetable
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
            this.hlecTimetableView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Section5_LecTimetable1 = new ABC_Institute___Timetable_Generator.Section5_LecTimetable();
            this.SuspendLayout();
            // 
            // hlecTimetableView
            // 
            this.hlecTimetableView.ActiveViewIndex = 0;
            this.hlecTimetableView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hlecTimetableView.Cursor = System.Windows.Forms.Cursors.Default;
            this.hlecTimetableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hlecTimetableView.Location = new System.Drawing.Point(0, 0);
            this.hlecTimetableView.Name = "hlecTimetableView";
            this.hlecTimetableView.ReportSource = this.Section5_LecTimetable1;
            this.hlecTimetableView.Size = new System.Drawing.Size(800, 450);
            this.hlecTimetableView.TabIndex = 0;
            this.hlecTimetableView.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Section5_ViewLecTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hlecTimetableView);
            this.Name = "Section5_ViewLecTimetable";
            this.Text = "Section5_ViewLecTimetable";
            this.Load += new System.EventHandler(this.Section5_ViewLecTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer hlecTimetableView;
        private Section5_LecTimetable Section5_LecTimetable1;
    }
}