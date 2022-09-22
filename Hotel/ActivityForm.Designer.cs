namespace Hotel
{
    partial class ActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyButton = new System.Windows.Forms.Button();
            this.QaAButton = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
            this.RestarauntsButton = new System.Windows.Forms.Button();
            this.ActivityButton = new System.Windows.Forms.Button();
            this.FavouriteListButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RoomButton = new System.Windows.Forms.Button();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ManagmentButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.ActivityLabel);
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.ClosePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 2;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityLabel.ForeColor = System.Drawing.Color.Black;
            this.ActivityLabel.Location = new System.Drawing.Point(543, 64);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(199, 32);
            this.ActivityLabel.TabIndex = 19;
            this.ActivityLabel.Text = "Мероприятия";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1275, 625);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ManagmentButton);
            this.panel1.Controls.Add(this.MyButton);
            this.panel1.Controls.Add(this.QaAButton);
            this.panel1.Controls.Add(this.ContactButton);
            this.panel1.Controls.Add(this.RestarauntsButton);
            this.panel1.Controls.Add(this.ActivityButton);
            this.panel1.Controls.Add(this.FavouriteListButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.RoomButton);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 30);
            this.panel1.TabIndex = 16;
            // 
            // MyButton
            // 
            this.MyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyButton.Location = new System.Drawing.Point(2, -1);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(118, 30);
            this.MyButton.TabIndex = 33;
            this.MyButton.Text = "Мои номера";
            this.MyButton.UseVisualStyleBackColor = true;
            this.MyButton.Click += new System.EventHandler(this.MyButton_Click);
            this.MyButton.MouseEnter += new System.EventHandler(this.MyButton_MouseEnter);
            this.MyButton.MouseLeave += new System.EventHandler(this.MyButton_MouseLeave);
            // 
            // QaAButton
            // 
            this.QaAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QaAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QaAButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QaAButton.Location = new System.Drawing.Point(640, -1);
            this.QaAButton.Name = "QaAButton";
            this.QaAButton.Size = new System.Drawing.Size(125, 30);
            this.QaAButton.TabIndex = 32;
            this.QaAButton.Text = "Вопросы и ответы";
            this.QaAButton.UseVisualStyleBackColor = true;
            this.QaAButton.Click += new System.EventHandler(this.QaAButton_Click);
            this.QaAButton.MouseEnter += new System.EventHandler(this.QaAButton_MouseEnter);
            this.QaAButton.MouseLeave += new System.EventHandler(this.QaAButton_MouseLeave);
            // 
            // ContactButton
            // 
            this.ContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactButton.Location = new System.Drawing.Point(771, -1);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(118, 30);
            this.ContactButton.TabIndex = 31;
            this.ContactButton.Text = "Контакты";
            this.ContactButton.UseVisualStyleBackColor = true;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            this.ContactButton.MouseEnter += new System.EventHandler(this.ContactButton_MouseEnter);
            this.ContactButton.MouseLeave += new System.EventHandler(this.ContactButton_MouseLeave);
            // 
            // RestarauntsButton
            // 
            this.RestarauntsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestarauntsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestarauntsButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestarauntsButton.Location = new System.Drawing.Point(516, -1);
            this.RestarauntsButton.Name = "RestarauntsButton";
            this.RestarauntsButton.Size = new System.Drawing.Size(118, 30);
            this.RestarauntsButton.TabIndex = 30;
            this.RestarauntsButton.Text = "Рестораны";
            this.RestarauntsButton.UseVisualStyleBackColor = true;
            this.RestarauntsButton.Click += new System.EventHandler(this.RestarauntsButton_Click);
            this.RestarauntsButton.MouseEnter += new System.EventHandler(this.RestarauntsButton_MouseEnter);
            this.RestarauntsButton.MouseLeave += new System.EventHandler(this.RestarauntsButton_MouseLeave);
            // 
            // ActivityButton
            // 
            this.ActivityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivityButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivityButton.Location = new System.Drawing.Point(392, -1);
            this.ActivityButton.Name = "ActivityButton";
            this.ActivityButton.Size = new System.Drawing.Size(118, 30);
            this.ActivityButton.TabIndex = 29;
            this.ActivityButton.Text = "Мероприятия";
            this.ActivityButton.UseVisualStyleBackColor = true;
            // 
            // FavouriteListButton
            // 
            this.FavouriteListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouriteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteListButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavouriteListButton.Location = new System.Drawing.Point(250, -1);
            this.FavouriteListButton.Name = "FavouriteListButton";
            this.FavouriteListButton.Size = new System.Drawing.Size(136, 30);
            this.FavouriteListButton.TabIndex = 28;
            this.FavouriteListButton.Text = "Список избранного";
            this.FavouriteListButton.UseVisualStyleBackColor = true;
            this.FavouriteListButton.Click += new System.EventHandler(this.FavouriteListButton_Click);
            this.FavouriteListButton.MouseEnter += new System.EventHandler(this.FavouriteListButton_MouseEnter);
            this.FavouriteListButton.MouseLeave += new System.EventHandler(this.FavouriteListButton_MouseLeave);
            // 
            // LeftButton
            // 
            this.LeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftButton.Location = new System.Drawing.Point(1129, -1);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(128, 30);
            this.LeftButton.TabIndex = 27;
            this.LeftButton.Text = "Выйти из аккаунта";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            this.LeftButton.MouseEnter += new System.EventHandler(this.LeftButton_MouseEnter);
            this.LeftButton.MouseLeave += new System.EventHandler(this.LeftButton_MouseLeave);
            // 
            // RoomButton
            // 
            this.RoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomButton.Location = new System.Drawing.Point(126, -1);
            this.RoomButton.Name = "RoomButton";
            this.RoomButton.Size = new System.Drawing.Size(118, 30);
            this.RoomButton.TabIndex = 26;
            this.RoomButton.Text = "Выбрать номер";
            this.RoomButton.UseVisualStyleBackColor = true;
            this.RoomButton.Click += new System.EventHandler(this.RoomButton_Click);
            this.RoomButton.MouseEnter += new System.EventHandler(this.RoomButton_MouseEnter);
            this.RoomButton.MouseLeave += new System.EventHandler(this.RoomButton_MouseLeave);
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
            this.ClosePanel.Size = new System.Drawing.Size(1278, 30);
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
            this.CloseLabel.Location = new System.Drawing.Point(1253, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // ManagmentButton
            // 
            this.ManagmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagmentButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagmentButton.Location = new System.Drawing.Point(895, -1);
            this.ManagmentButton.Name = "ManagmentButton";
            this.ManagmentButton.Size = new System.Drawing.Size(133, 30);
            this.ManagmentButton.TabIndex = 34;
            this.ManagmentButton.Text = "Панель управления";
            this.ManagmentButton.UseVisualStyleBackColor = true;
            this.ManagmentButton.Click += new System.EventHandler(this.ManagmentButton_Click);
            this.ManagmentButton.MouseEnter += new System.EventHandler(this.ManagmentButton_MouseEnter);
            this.ManagmentButton.MouseLeave += new System.EventHandler(this.ManagmentButton_MouseLeave);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ActivityForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Button MyButton;
        private System.Windows.Forms.Button QaAButton;
        private System.Windows.Forms.Button ContactButton;
        private System.Windows.Forms.Button RestarauntsButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Button FavouriteListButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RoomButton;
        private System.Windows.Forms.Button ManagmentButton;
    }
}