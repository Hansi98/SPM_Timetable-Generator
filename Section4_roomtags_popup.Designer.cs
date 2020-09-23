namespace ABC_Institute___Timetable_Generator
{
    partial class Section4_roomtags_popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section4_roomtags_popup));
            this.roomtags_popup = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nishikibtnaddtagsrooms = new System.Windows.Forms.Button();
            this.nishikicmbbuildingstagsroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nishikicmbtagsrooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnishikitagsroomname = new System.Windows.Forms.ComboBox();
            this.roomtags_popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomtags_popup
            // 
            this.roomtags_popup.BackColor = System.Drawing.Color.AliceBlue;
            this.roomtags_popup.Controls.Add(this.txtnishikitagsroomname);
            this.roomtags_popup.Controls.Add(this.pictureBox1);
            this.roomtags_popup.Controls.Add(this.label4);
            this.roomtags_popup.Controls.Add(this.nishikibtnaddtagsrooms);
            this.roomtags_popup.Controls.Add(this.nishikicmbbuildingstagsroom);
            this.roomtags_popup.Controls.Add(this.label3);
            this.roomtags_popup.Controls.Add(this.label2);
            this.roomtags_popup.Controls.Add(this.nishikicmbtagsrooms);
            this.roomtags_popup.Controls.Add(this.label1);
            this.roomtags_popup.Controls.Add(this.button1);
            this.roomtags_popup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomtags_popup.Location = new System.Drawing.Point(0, 0);
            this.roomtags_popup.Name = "roomtags_popup";
            this.roomtags_popup.Size = new System.Drawing.Size(1217, 749);
            this.roomtags_popup.TabIndex = 0;
            this.roomtags_popup.Paint += new System.Windows.Forms.PaintEventHandler(this.Roomtags_popup_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add room information for a particular tag here";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // nishikibtnaddtagsrooms
            // 
            this.nishikibtnaddtagsrooms.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nishikibtnaddtagsrooms.BackColor = System.Drawing.Color.Turquoise;
            this.nishikibtnaddtagsrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nishikibtnaddtagsrooms.Location = new System.Drawing.Point(508, 522);
            this.nishikibtnaddtagsrooms.Name = "nishikibtnaddtagsrooms";
            this.nishikibtnaddtagsrooms.Size = new System.Drawing.Size(271, 81);
            this.nishikibtnaddtagsrooms.TabIndex = 7;
            this.nishikibtnaddtagsrooms.Text = "ADD";
            this.nishikibtnaddtagsrooms.UseVisualStyleBackColor = false;
            this.nishikibtnaddtagsrooms.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nishikicmbbuildingstagsroom
            // 
            this.nishikicmbbuildingstagsroom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikicmbbuildingstagsroom.FormattingEnabled = true;
            this.nishikicmbbuildingstagsroom.Items.AddRange(new object[] {
            "Faculty of Computing",
            "Faculty of Engineering",
            "Faculty of Humanity and sciences",
            "Faculty of Business"});
            this.nishikicmbbuildingstagsroom.Location = new System.Drawing.Point(523, 311);
            this.nishikicmbbuildingstagsroom.Name = "nishikicmbbuildingstagsroom";
            this.nishikicmbbuildingstagsroom.Size = new System.Drawing.Size(381, 24);
            this.nishikicmbbuildingstagsroom.TabIndex = 5;
            this.nishikicmbbuildingstagsroom.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Building";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // nishikicmbtagsrooms
            // 
            this.nishikicmbtagsrooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikicmbtagsrooms.FormattingEnabled = true;
            this.nishikicmbtagsrooms.Location = new System.Drawing.Point(523, 225);
            this.nishikicmbtagsrooms.Name = "nishikicmbtagsrooms";
            this.nishikicmbtagsrooms.Size = new System.Drawing.Size(381, 24);
            this.nishikicmbtagsrooms.TabIndex = 2;
            this.nishikicmbtagsrooms.SelectedIndexChanged += new System.EventHandler(this.Nishikicmbtagsrooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tags";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1158, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtnishikitagsroomname
            // 
            this.txtnishikitagsroomname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnishikitagsroomname.FormattingEnabled = true;
            this.txtnishikitagsroomname.Location = new System.Drawing.Point(523, 411);
            this.txtnishikitagsroomname.Name = "txtnishikitagsroomname";
            this.txtnishikitagsroomname.Size = new System.Drawing.Size(381, 24);
            this.txtnishikitagsroomname.TabIndex = 10;
            // 
            // Section4_roomtags_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 749);
            this.Controls.Add(this.roomtags_popup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section4_roomtags_popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section4_roomtags_popup";
            this.roomtags_popup.ResumeLayout(false);
            this.roomtags_popup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomtags_popup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nishikicmbbuildingstagsroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nishikicmbtagsrooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nishikibtnaddtagsrooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtnishikitagsroomname;
    }
}