namespace Hotel
{
    partial class RateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateForm));
            this.RatePanel = new System.Windows.Forms.Panel();
            this.RateComboBox = new System.Windows.Forms.ComboBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.RateButton = new System.Windows.Forms.Button();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.RatePanel.SuspendLayout();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RatePanel
            // 
            this.RatePanel.BackColor = System.Drawing.Color.White;
            this.RatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatePanel.Controls.Add(this.RateComboBox);
            this.RatePanel.Controls.Add(this.RateLabel);
            this.RatePanel.Controls.Add(this.RateButton);
            this.RatePanel.Controls.Add(this.ClosePanel);
            this.RatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RatePanel.Location = new System.Drawing.Point(0, 0);
            this.RatePanel.Name = "RatePanel";
            this.RatePanel.Size = new System.Drawing.Size(420, 160);
            this.RatePanel.TabIndex = 4;
            // 
            // RateComboBox
            // 
            this.RateComboBox.BackColor = System.Drawing.Color.White;
            this.RateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RateComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateComboBox.ForeColor = System.Drawing.Color.Black;
            this.RateComboBox.FormattingEnabled = true;
            this.RateComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RateComboBox.Location = new System.Drawing.Point(226, 71);
            this.RateComboBox.Name = "RateComboBox";
            this.RateComboBox.Size = new System.Drawing.Size(130, 29);
            this.RateComboBox.TabIndex = 34;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateLabel.ForeColor = System.Drawing.Color.Black;
            this.RateLabel.Location = new System.Drawing.Point(36, 71);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(184, 24);
            this.RateLabel.TabIndex = 33;
            this.RateLabel.Text = "Выбрать оценку:";
            // 
            // RateButton
            // 
            this.RateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateButton.Location = new System.Drawing.Point(144, 117);
            this.RateButton.Name = "RateButton";
            this.RateButton.Size = new System.Drawing.Size(126, 30);
            this.RateButton.TabIndex = 25;
            this.RateButton.Text = "Оценить";
            this.RateButton.UseVisualStyleBackColor = true;
            this.RateButton.Click += new System.EventHandler(this.RateButton_Click);
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
            this.ClosePanel.Size = new System.Drawing.Size(418, 30);
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
            this.CloseLabel.Location = new System.Drawing.Point(387, 1);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 160);
            this.Controls.Add(this.RatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RateForm";
            this.RatePanel.ResumeLayout(false);
            this.RatePanel.PerformLayout();
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RatePanel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Button RateButton;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.ComboBox RateComboBox;
    }
}