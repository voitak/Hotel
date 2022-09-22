namespace Hotel
{
    partial class InfoChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoChangeForm));
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BigInfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.VariantComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BigInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureHided = new System.Windows.Forms.PictureBox();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.ClosePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHided)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.ClosePanel.Size = new System.Drawing.Size(1000, 30);
            this.ClosePanel.TabIndex = 1;
            this.ClosePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseDown);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseMove);
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureHided);
            this.panel1.Controls.Add(this.BigInfoLabel);
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Controls.Add(this.ChangeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ActivityLabel);
            this.panel1.Controls.Add(this.TypeComboBox);
            this.panel1.Controls.Add(this.VariantComboBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.BigInfoRichTextBox);
            this.panel1.Controls.Add(this.InfoRichTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 491);
            this.panel1.TabIndex = 2;
            // 
            // BigInfoLabel
            // 
            this.BigInfoLabel.AutoSize = true;
            this.BigInfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.BigInfoLabel.Location = new System.Drawing.Point(88, 192);
            this.BigInfoLabel.Name = "BigInfoLabel";
            this.BigInfoLabel.Size = new System.Drawing.Size(99, 21);
            this.BigInfoLabel.TabIndex = 36;
            this.BigInfoLabel.Text = "Описание:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoLabel.Location = new System.Drawing.Point(88, 56);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(126, 21);
            this.InfoLabel.TabIndex = 35;
            this.InfoLabel.Text = "Информация:";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(749, 24);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(140, 30);
            this.ChangeButton.TabIndex = 34;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(490, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Тип размещения:";
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityLabel.ForeColor = System.Drawing.Color.Black;
            this.ActivityLabel.Location = new System.Drawing.Point(292, 6);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(192, 21);
            this.ActivityLabel.TabIndex = 32;
            this.ActivityLabel.Text = "Вариант размещения:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Econom",
            "Standart",
            "Lux"});
            this.TypeComboBox.Location = new System.Drawing.Point(494, 30);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(130, 24);
            this.TypeComboBox.TabIndex = 31;
            // 
            // VariantComboBox
            // 
            this.VariantComboBox.BackColor = System.Drawing.Color.White;
            this.VariantComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VariantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VariantComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariantComboBox.ForeColor = System.Drawing.Color.Black;
            this.VariantComboBox.FormattingEnabled = true;
            this.VariantComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.VariantComboBox.Location = new System.Drawing.Point(314, 30);
            this.VariantComboBox.Name = "VariantComboBox";
            this.VariantComboBox.Size = new System.Drawing.Size(130, 24);
            this.VariantComboBox.TabIndex = 30;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(88, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 21);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Название:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(11, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(273, 21);
            this.NameTextBox.TabIndex = 2;
            // 
            // BigInfoRichTextBox
            // 
            this.BigInfoRichTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigInfoRichTextBox.Location = new System.Drawing.Point(11, 217);
            this.BigInfoRichTextBox.Name = "BigInfoRichTextBox";
            this.BigInfoRichTextBox.Size = new System.Drawing.Size(878, 205);
            this.BigInfoRichTextBox.TabIndex = 1;
            this.BigInfoRichTextBox.Text = "";
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoRichTextBox.Location = new System.Drawing.Point(11, 80);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.Size = new System.Drawing.Size(878, 109);
            this.InfoRichTextBox.TabIndex = 0;
            this.InfoRichTextBox.Text = "";
            // 
            // pictureHided
            // 
            this.pictureHided.Image = global::Hotel.Properties.Resources.blank;
            this.pictureHided.Location = new System.Drawing.Point(896, 80);
            this.pictureHided.Name = "pictureHided";
            this.pictureHided.Size = new System.Drawing.Size(100, 50);
            this.pictureHided.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHided.TabIndex = 64;
            this.pictureHided.TabStop = false;
            this.pictureHided.Visible = false;
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
            // InfoChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClosePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoChangeForm";
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHided)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RichTextBox BigInfoRichTextBox;
        private System.Windows.Forms.RichTextBox InfoRichTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox VariantComboBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label BigInfoLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox pictureHided;
    }
}