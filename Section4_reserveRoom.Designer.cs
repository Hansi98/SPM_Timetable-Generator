namespace ABC_Institute___Timetable_Generator
{
    partial class Section4_reserveRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section4_reserveRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nishikistatimg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvnishikireserverooms = new System.Windows.Forms.DataGridView();
            this.btnnishikiaddreserverooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nishikistatimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnishikireserverooms)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1116, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reserve a room";
            // 
            // nishikistatimg
            // 
            this.nishikistatimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nishikistatimg.Image = ((System.Drawing.Image)(resources.GetObject("nishikistatimg.Image")));
            this.nishikistatimg.Location = new System.Drawing.Point(12, 12);
            this.nishikistatimg.Name = "nishikistatimg";
            this.nishikistatimg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nishikistatimg.Size = new System.Drawing.Size(77, 69);
            this.nishikistatimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nishikistatimg.TabIndex = 9;
            this.nishikistatimg.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(994, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Refresh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1082, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // dgvnishikireserverooms
            // 
            this.dgvnishikireserverooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvnishikireserverooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnishikireserverooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnishikireserverooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnishikireserverooms.Location = new System.Drawing.Point(29, 225);
            this.dgvnishikireserverooms.Name = "dgvnishikireserverooms";
            this.dgvnishikireserverooms.RowHeadersWidth = 51;
            this.dgvnishikireserverooms.RowTemplate.Height = 24;
            this.dgvnishikireserverooms.Size = new System.Drawing.Size(1124, 524);
            this.dgvnishikireserverooms.TabIndex = 26;
            // 
            // btnnishikiaddreserverooms
            // 
            this.btnnishikiaddreserverooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnnishikiaddreserverooms.BackColor = System.Drawing.Color.LightBlue;
            this.btnnishikiaddreserverooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnishikiaddreserverooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnishikiaddreserverooms.Location = new System.Drawing.Point(406, 111);
            this.btnnishikiaddreserverooms.Name = "btnnishikiaddreserverooms";
            this.btnnishikiaddreserverooms.Size = new System.Drawing.Size(398, 60);
            this.btnnishikiaddreserverooms.TabIndex = 25;
            this.btnnishikiaddreserverooms.Text = "Add room";
            this.btnnishikiaddreserverooms.UseVisualStyleBackColor = false;
            this.btnnishikiaddreserverooms.Click += new System.EventHandler(this.Btnnishikiaddreserverooms_Click);
            // 
            // Section4_reserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1191, 774);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvnishikireserverooms);
            this.Controls.Add(this.btnnishikiaddreserverooms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nishikistatimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section4_reserveRoom";
            this.Text = "Section4_reserveRoom";
            ((System.ComponentModel.ISupportInitialize)(this.nishikistatimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnishikireserverooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nishikistatimg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvnishikireserverooms;
        private System.Windows.Forms.Button btnnishikiaddreserverooms;
    }
}