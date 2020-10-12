namespace ABC_Institute___Timetable_Generator
{
    partial class Section5_ViewGrpTimetable
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
            this.hgrpreportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // hgrpreportViewer
            // 
            this.hgrpreportViewer.ActiveViewIndex = -1;
            this.hgrpreportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hgrpreportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.hgrpreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hgrpreportViewer.Location = new System.Drawing.Point(0, 0);
            this.hgrpreportViewer.Name = "hgrpreportViewer";
            this.hgrpreportViewer.Size = new System.Drawing.Size(800, 453);
            this.hgrpreportViewer.TabIndex = 0;
            this.hgrpreportViewer.Load += new System.EventHandler(this.hgrpreportViewer_Load);
            // 
            // Section5_ViewGrpTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.hgrpreportViewer);
            this.Name = "Section5_ViewGrpTimetable";
            this.Text = "Section5_ViewGrpTimetable";
            this.Load += new System.EventHandler(this.Section5_ViewGrpTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer hgrpreportViewer;
    }
}