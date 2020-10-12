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
            this.hlecreportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // hlecreportViewer
            // 
            this.hlecreportViewer.ActiveViewIndex = -1;
            this.hlecreportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hlecreportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.hlecreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hlecreportViewer.Location = new System.Drawing.Point(0, 0);
            this.hlecreportViewer.Name = "hlecreportViewer";
            this.hlecreportViewer.Size = new System.Drawing.Size(800, 450);
            this.hlecreportViewer.TabIndex = 0;
            this.hlecreportViewer.Load += new System.EventHandler(this.hlecreportViewer_Load);
            // 
            // Section5_ViewLecTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hlecreportViewer);
            this.Name = "Section5_ViewLecTimetable";
            this.Text = "ViewLecTimetable";
            this.Load += new System.EventHandler(this.Section5_ViewLecTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer hlecreportViewer;
    }
}