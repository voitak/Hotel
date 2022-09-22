namespace Hotel
{
    partial class LeftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftForm));
            this.LeftLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftLabel.Location = new System.Drawing.Point(33, 33);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(326, 66);
            this.LeftLabel.TabIndex = 0;
            this.LeftLabel.Text = "Вы уверены, что хотите \r\n   выйти из аккаунта?";
            // 
            // YesButton
            // 
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.FlatAppearance.BorderSize = 2;
            this.YesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.YesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.ForeColor = System.Drawing.Color.Black;
            this.YesButton.Location = new System.Drawing.Point(80, 143);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(110, 45);
            this.YesButton.TabIndex = 7;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            this.YesButton.MouseEnter += new System.EventHandler(this.YesButton_MouseEnter);
            this.YesButton.MouseLeave += new System.EventHandler(this.YesButton_MouseLeave);
            // 
            // NoButton
            // 
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.FlatAppearance.BorderSize = 2;
            this.NoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.NoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.ForeColor = System.Drawing.Color.Black;
            this.NoButton.Location = new System.Drawing.Point(210, 143);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(110, 45);
            this.NoButton.TabIndex = 8;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            this.NoButton.MouseEnter += new System.EventHandler(this.NoButton_MouseEnter);
            this.NoButton.MouseLeave += new System.EventHandler(this.NoButton_MouseLeave);
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
            this.ClosePanel.Size = new System.Drawing.Size(400, 30);
            this.ClosePanel.TabIndex = 10;
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
            this.CloseLabel.ForeColor = System.Drawing.Color.Black;
            this.CloseLabel.Location = new System.Drawing.Point(374, -1);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // LeftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.LeftLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeftForm";
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
    }
}