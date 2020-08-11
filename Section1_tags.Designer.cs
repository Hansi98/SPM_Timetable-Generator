namespace ABC_Institute___Timetable_Generator
{
    partial class Section1_tags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section1_tags));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vdataGridTags = new System.Windows.Forms.DataGridView();
            this.vbtnUpdateTag = new System.Windows.Forms.Button();
            this.vbtnAddTag = new System.Windows.Forms.Button();
            this.vtxtBoxTagName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.vdataGridTags);
            this.panel1.Controls.Add(this.vbtnUpdateTag);
            this.panel1.Controls.Add(this.vbtnAddTag);
            this.panel1.Controls.Add(this.vtxtBoxTagName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 532);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vdataGridTags
            // 
            this.vdataGridTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vdataGridTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vdataGridTags.Location = new System.Drawing.Point(22, 207);
            this.vdataGridTags.Name = "vdataGridTags";
            this.vdataGridTags.RowHeadersWidth = 51;
            this.vdataGridTags.RowTemplate.Height = 24;
            this.vdataGridTags.Size = new System.Drawing.Size(919, 284);
            this.vdataGridTags.TabIndex = 15;
            // 
            // vbtnUpdateTag
            // 
            this.vbtnUpdateTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vbtnUpdateTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vbtnUpdateTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vbtnUpdateTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnUpdateTag.Location = new System.Drawing.Point(510, 144);
            this.vbtnUpdateTag.Name = "vbtnUpdateTag";
            this.vbtnUpdateTag.Size = new System.Drawing.Size(226, 44);
            this.vbtnUpdateTag.TabIndex = 14;
            this.vbtnUpdateTag.Text = "Update Details";
            this.vbtnUpdateTag.UseVisualStyleBackColor = false;
            this.vbtnUpdateTag.Click += new System.EventHandler(this.button3_Click);
            // 
            // vbtnAddTag
            // 
            this.vbtnAddTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vbtnAddTag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vbtnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vbtnAddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnAddTag.Location = new System.Drawing.Point(278, 144);
            this.vbtnAddTag.Name = "vbtnAddTag";
            this.vbtnAddTag.Size = new System.Drawing.Size(226, 44);
            this.vbtnAddTag.TabIndex = 13;
            this.vbtnAddTag.Text = "Add details";
            this.vbtnAddTag.UseVisualStyleBackColor = false;
            this.vbtnAddTag.Click += new System.EventHandler(this.button2_Click);
            // 
            // vtxtBoxTagName
            // 
            this.vtxtBoxTagName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vtxtBoxTagName.Location = new System.Drawing.Point(346, 101);
            this.vtxtBoxTagName.Name = "vtxtBoxTagName";
            this.vtxtBoxTagName.Size = new System.Drawing.Size(374, 22);
            this.vtxtBoxTagName.TabIndex = 4;
            this.vtxtBoxTagName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(908, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tags";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Section1_tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Section1_tags";
            this.Text = "Section1_tags";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vtxtBoxTagName;
        private System.Windows.Forms.Button vbtnUpdateTag;
        private System.Windows.Forms.Button vbtnAddTag;
        private System.Windows.Forms.DataGridView vdataGridTags;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}