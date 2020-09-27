namespace ABC_Institute___Timetable_Generator
{
    partial class Section5_ViewRoomTimetable
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
            this.hroomReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Section5_RoomTimetable1 = new ABC_Institute___Timetable_Generator.Section5_RoomTimetable();
            this.SuspendLayout();
            // 
            // hroomReportViewer
            // 
            this.hroomReportViewer.ActiveViewIndex = 0;
            this.hroomReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hroomReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.hroomReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hroomReportViewer.Location = new System.Drawing.Point(0, 0);
            this.hroomReportViewer.Name = "hroomReportViewer";
            this.hroomReportViewer.ReportSource = this.Section5_RoomTimetable1;
            this.hroomReportViewer.Size = new System.Drawing.Size(800, 450);
            this.hroomReportViewer.TabIndex = 0;
            this.hroomReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Section5_ViewRoomTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hroomReportViewer);
            this.Name = "Section5_ViewRoomTimetable";
            this.Text = "Section5_ViewRoomTimetable";
            this.Load += new System.EventHandler(this.Section5_ViewRoomTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer hroomReportViewer;
        private Section5_RoomTimetable Section5_RoomTimetable1;
    }
}