namespace ABC_Institute___Timetable_Generator
{
    partial class Section1_Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section1_Location));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nishikiDLocations_buildiing_comboBox = new System.Windows.Forms.ComboBox();
            this.nishikiDLocations_roomtype_comboBox = new System.Windows.Forms.ComboBox();
            this.nishikiDLocations_room_textBox = new System.Windows.Forms.TextBox();
            this.nishikiDLocation_dataGridView = new System.Windows.Forms.DataGridView();
            this.nishikiDLocation_btnadd = new System.Windows.Forms.Button();
            this.nishikiDLocation_btnupdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nishikiDLocation_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.nishikiDLocation_btnupdate);
            this.panel1.Controls.Add(this.nishikiDLocation_btnadd);
            this.panel1.Controls.Add(this.nishikiDLocation_dataGridView);
            this.panel1.Controls.Add(this.nishikiDLocations_room_textBox);
            this.panel1.Controls.Add(this.nishikiDLocations_roomtype_comboBox);
            this.panel1.Controls.Add(this.nishikiDLocations_buildiing_comboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 627);
            this.panel1.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(939, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 36);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Type";
            // 
            // nishikiDLocations_buildiing_comboBox
            // 
            this.nishikiDLocations_buildiing_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikiDLocations_buildiing_comboBox.FormattingEnabled = true;
            this.nishikiDLocations_buildiing_comboBox.Location = new System.Drawing.Point(461, 73);
            this.nishikiDLocations_buildiing_comboBox.Name = "nishikiDLocations_buildiing_comboBox";
            this.nishikiDLocations_buildiing_comboBox.Size = new System.Drawing.Size(272, 24);
            this.nishikiDLocations_buildiing_comboBox.TabIndex = 7;
            // 
            // nishikiDLocations_roomtype_comboBox
            // 
            this.nishikiDLocations_roomtype_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikiDLocations_roomtype_comboBox.FormattingEnabled = true;
            this.nishikiDLocations_roomtype_comboBox.Location = new System.Drawing.Point(461, 144);
            this.nishikiDLocations_roomtype_comboBox.Name = "nishikiDLocations_roomtype_comboBox";
            this.nishikiDLocations_roomtype_comboBox.Size = new System.Drawing.Size(272, 24);
            this.nishikiDLocations_roomtype_comboBox.TabIndex = 8;
            // 
            // nishikiDLocations_room_textBox
            // 
            this.nishikiDLocations_room_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikiDLocations_room_textBox.Location = new System.Drawing.Point(461, 110);
            this.nishikiDLocations_room_textBox.Name = "nishikiDLocations_room_textBox";
            this.nishikiDLocations_room_textBox.Size = new System.Drawing.Size(272, 22);
            this.nishikiDLocations_room_textBox.TabIndex = 9;
            // 
            // nishikiDLocation_dataGridView
            // 
            this.nishikiDLocation_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nishikiDLocation_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nishikiDLocation_dataGridView.Location = new System.Drawing.Point(12, 256);
            this.nishikiDLocation_dataGridView.Name = "nishikiDLocation_dataGridView";
            this.nishikiDLocation_dataGridView.RowHeadersWidth = 51;
            this.nishikiDLocation_dataGridView.RowTemplate.Height = 24;
            this.nishikiDLocation_dataGridView.Size = new System.Drawing.Size(977, 359);
            this.nishikiDLocation_dataGridView.TabIndex = 13;
            // 
            // nishikiDLocation_btnadd
            // 
            this.nishikiDLocation_btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDLocation_btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nishikiDLocation_btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nishikiDLocation_btnadd.Location = new System.Drawing.Point(361, 197);
            this.nishikiDLocation_btnadd.Name = "nishikiDLocation_btnadd";
            this.nishikiDLocation_btnadd.Size = new System.Drawing.Size(158, 42);
            this.nishikiDLocation_btnadd.TabIndex = 14;
            this.nishikiDLocation_btnadd.Text = "ADD";
            this.nishikiDLocation_btnadd.UseVisualStyleBackColor = false;
            // 
            // nishikiDLocation_btnupdate
            // 
            this.nishikiDLocation_btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nishikiDLocation_btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nishikiDLocation_btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nishikiDLocation_btnupdate.Location = new System.Drawing.Point(525, 197);
            this.nishikiDLocation_btnupdate.Name = "nishikiDLocation_btnupdate";
            this.nishikiDLocation_btnupdate.Size = new System.Drawing.Size(158, 42);
            this.nishikiDLocation_btnupdate.TabIndex = 15;
            this.nishikiDLocation_btnupdate.Text = "UPDATE";
            this.nishikiDLocation_btnupdate.UseVisualStyleBackColor = false;
            // 
            // Section1_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 627);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section1_Location";
            this.Text = "Section1_Location";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nishikiDLocation_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nishikiDLocations_room_textBox;
        private System.Windows.Forms.ComboBox nishikiDLocations_roomtype_comboBox;
        private System.Windows.Forms.ComboBox nishikiDLocations_buildiing_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView nishikiDLocation_dataGridView;
        private System.Windows.Forms.Button nishikiDLocation_btnupdate;
        private System.Windows.Forms.Button nishikiDLocation_btnadd;
    }
}