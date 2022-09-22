namespace Hotel
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.AboutPictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.ClosePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 600);
            this.MainPanel.TabIndex = 2;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.ForeColor = System.Drawing.Color.Black;
            this.TextLabel.Location = new System.Drawing.Point(3, 0);
            this.TextLabel.MaximumSize = new System.Drawing.Size(900, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextLabel.Size = new System.Drawing.Size(175, 22);
            this.TextLabel.TabIndex = 20;
            this.TextLabel.Text = "Текст сообщения";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(290, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(168, 38);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "%Name%";
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.White;
            this.ClosePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClosePanel.Controls.Add(this.HotelPictureBox);
            this.ClosePanel.Controls.Add(this.CloseLabel);
            this.ClosePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClosePanel.Location = new System.Drawing.Point(0, 0);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(998, 30);
            this.ClosePanel.TabIndex = 0;
            this.ClosePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseDown);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseMove);
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.Image = global::Hotel.Properties.Resources.bed;
            this.HotelPictureBox.Location = new System.Drawing.Point(0, 0);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(30, 30);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HotelPictureBox.TabIndex = 16;
            this.HotelPictureBox.TabStop = false;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.White;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.Location = new System.Drawing.Point(974, -2);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // AboutPictureBox
            // 
            this.AboutPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutPictureBox.Location = new System.Drawing.Point(184, 3);
            this.AboutPictureBox.Name = "AboutPictureBox";
            this.AboutPictureBox.Size = new System.Drawing.Size(950, 160);
            this.AboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AboutPictureBox.TabIndex = 21;
            this.AboutPictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.TextLabel);
            this.flowLayoutPanel1.Controls.Add(this.AboutPictureBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 525);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox AboutPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}