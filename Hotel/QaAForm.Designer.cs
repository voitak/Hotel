namespace Hotel
{
    partial class QaAForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QaAForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.qaaPictureBox = new System.Windows.Forms.PictureBox();
            this.QaATextLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyButton = new System.Windows.Forms.Button();
            this.QaAButton = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
            this.RestarauntsButton = new System.Windows.Forms.Button();
            this.ActivityButton = new System.Windows.Forms.Button();
            this.FavouriteListButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RoomButton = new System.Windows.Forms.Button();
            this.QaALabel = new System.Windows.Forms.Label();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ManagmentButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qaaPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.QaALabel);
            this.MainPanel.Controls.Add(this.ClosePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.qaaPictureBox);
            this.panel2.Controls.Add(this.QaATextLabel);
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 614);
            this.panel2.TabIndex = 22;
            // 
            // qaaPictureBox
            // 
            this.qaaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.qaaPictureBox.Name = "qaaPictureBox";
            this.qaaPictureBox.Size = new System.Drawing.Size(1250, 228);
            this.qaaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qaaPictureBox.TabIndex = 21;
            this.qaaPictureBox.TabStop = false;
            // 
            // QaATextLabel
            // 
            this.QaATextLabel.AutoSize = true;
            this.QaATextLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QaATextLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QaATextLabel.ForeColor = System.Drawing.Color.Black;
            this.QaATextLabel.Location = new System.Drawing.Point(3, 234);
            this.QaATextLabel.MaximumSize = new System.Drawing.Size(1250, 0);
            this.QaATextLabel.Name = "QaATextLabel";
            this.QaATextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QaATextLabel.Size = new System.Drawing.Size(175, 22);
            this.QaATextLabel.TabIndex = 20;
            this.QaATextLabel.Text = "Текст сообщения";
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
            this.MyButton.TabIndex = 41;
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
            this.QaAButton.TabIndex = 40;
            this.QaAButton.Text = "Вопросы и ответы";
            this.QaAButton.UseVisualStyleBackColor = true;
            // 
            // ContactButton
            // 
            this.ContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactButton.Location = new System.Drawing.Point(771, -1);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(118, 30);
            this.ContactButton.TabIndex = 39;
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
            this.RestarauntsButton.TabIndex = 38;
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
            this.ActivityButton.TabIndex = 37;
            this.ActivityButton.Text = "Мероприятия";
            this.ActivityButton.UseVisualStyleBackColor = true;
            this.ActivityButton.Click += new System.EventHandler(this.ActivityButton_Click);
            this.ActivityButton.MouseEnter += new System.EventHandler(this.ActivityButton_MouseEnter);
            this.ActivityButton.MouseLeave += new System.EventHandler(this.ActivityButton_MouseLeave);
            // 
            // FavouriteListButton
            // 
            this.FavouriteListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouriteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavouriteListButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavouriteListButton.Location = new System.Drawing.Point(250, -1);
            this.FavouriteListButton.Name = "FavouriteListButton";
            this.FavouriteListButton.Size = new System.Drawing.Size(136, 30);
            this.FavouriteListButton.TabIndex = 36;
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
            this.LeftButton.TabIndex = 35;
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
            this.RoomButton.TabIndex = 34;
            this.RoomButton.Text = "Выбрать номер";
            this.RoomButton.UseVisualStyleBackColor = true;
            this.RoomButton.Click += new System.EventHandler(this.RoomButton_Click);
            this.RoomButton.MouseEnter += new System.EventHandler(this.RoomButton_MouseEnter);
            this.RoomButton.MouseLeave += new System.EventHandler(this.RoomButton_MouseLeave);
            // 
            // QaALabel
            // 
            this.QaALabel.AutoSize = true;
            this.QaALabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.QaALabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QaALabel.ForeColor = System.Drawing.Color.Black;
            this.QaALabel.Location = new System.Drawing.Point(393, 64);
            this.QaALabel.Name = "QaALabel";
            this.QaALabel.Size = new System.Drawing.Size(480, 38);
            this.QaALabel.TabIndex = 19;
            this.QaALabel.Text = "Часто задаваемые вопросы";
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
            this.ManagmentButton.TabIndex = 35;
            this.ManagmentButton.Text = "Панель управления";
            this.ManagmentButton.UseVisualStyleBackColor = true;
            this.ManagmentButton.Click += new System.EventHandler(this.ManagmentButton_Click);
            this.ManagmentButton.MouseEnter += new System.EventHandler(this.ManagmentButton_MouseEnter);
            this.ManagmentButton.MouseLeave += new System.EventHandler(this.ManagmentButton_MouseLeave);
            // 
            // QaAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QaAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QaAForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qaaPictureBox)).EndInit();
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
        private System.Windows.Forms.Label QaATextLabel;
        private System.Windows.Forms.Label QaALabel;
        private System.Windows.Forms.Button MyButton;
        private System.Windows.Forms.Button QaAButton;
        private System.Windows.Forms.Button ContactButton;
        private System.Windows.Forms.Button RestarauntsButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Button FavouriteListButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RoomButton;
        private System.Windows.Forms.PictureBox qaaPictureBox;
        private System.Windows.Forms.FlowLayoutPanel panel2;
        private System.Windows.Forms.Button ManagmentButton;
    }
}