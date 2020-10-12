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
            this.hroomreportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // hroomreportViewer
            // 
            this.hroomreportViewer.ActiveViewIndex = -1;
            this.hroomreportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hroomreportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.hroomreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hroomreportViewer.Location = new System.Drawing.Point(0, 0);
            this.hroomreportViewer.Name = "hroomreportViewer";
            this.hroomreportViewer.Size = new System.Drawing.Size(800, 450);
            this.hroomreportViewer.TabIndex = 0;
            this.hroomreportViewer.Load += new System.EventHandler(this.hroomreportViewer_Load);
            // 
            // Section5_ViewRoomTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hroomreportViewer);
            this.Name = "Section5_ViewRoomTimetable";
            this.Text = "Section5_ViewRoomTimetable";
            this.Load += new System.EventHandler(this.Section5_ViewRoomTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer hroomreportViewer;
    }
}