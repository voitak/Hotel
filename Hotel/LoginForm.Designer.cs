namespace Hotel
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.GuestLabel = new System.Windows.Forms.Label();
            this.LogToRegLabel = new System.Windows.Forms.Label();
            this.EyePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LockPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.LoginTextLabel = new System.Windows.Forms.Label();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.GuestLabel);
            this.LoginPanel.Controls.Add(this.LogToRegLabel);
            this.LoginPanel.Controls.Add(this.EyePictureBox);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordTextBox);
            this.LoginPanel.Controls.Add(this.LockPictureBox);
            this.LoginPanel.Controls.Add(this.LoginTextBox);
            this.LoginPanel.Controls.Add(this.UserPicture);
            this.LoginPanel.Controls.Add(this.LoginTextLabel);
            this.LoginPanel.Controls.Add(this.ClosePanel);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(400, 500);
            this.LoginPanel.TabIndex = 0;
            // 
            // GuestLabel
            // 
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuestLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestLabel.ForeColor = System.Drawing.Color.Black;
            this.GuestLabel.Location = new System.Drawing.Point(137, 474);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GuestLabel.Size = new System.Drawing.Size(113, 16);
            this.GuestLabel.TabIndex = 16;
            this.GuestLabel.Text = "Зайти как гость";
            this.GuestLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GuestLabel_MouseClick);
            this.GuestLabel.MouseEnter += new System.EventHandler(this.GuestLabel_MouseEnter);
            this.GuestLabel.MouseLeave += new System.EventHandler(this.GuestLabel_MouseLeave);
            // 
            // LogToRegLabel
            // 
            this.LogToRegLabel.AutoSize = true;
            this.LogToRegLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogToRegLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogToRegLabel.ForeColor = System.Drawing.Color.Black;
            this.LogToRegLabel.Location = new System.Drawing.Point(82, 447);
            this.LogToRegLabel.Name = "LogToRegLabel";
            this.LogToRegLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogToRegLabel.Size = new System.Drawing.Size(227, 16);
            this.LogToRegLabel.TabIndex = 15;
            this.LogToRegLabel.Text = "Еще нет аккаунта? Регистрация";
            this.LogToRegLabel.Click += new System.EventHandler(this.LogToRegLabel_Click);
            this.LogToRegLabel.MouseEnter += new System.EventHandler(this.LogToRegLabel_MouseEnter);
            this.LogToRegLabel.MouseLeave += new System.EventHandler(this.LogToRegLabel_MouseLeave);
            // 
            // EyePictureBox
            // 
            this.EyePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EyePictureBox.Image = global::Hotel.Properties.Resources.eye;
            this.EyePictureBox.Location = new System.Drawing.Point(339, 250);
            this.EyePictureBox.Name = "EyePictureBox";
            this.EyePictureBox.Size = new System.Drawing.Size(48, 48);
            this.EyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EyePictureBox.TabIndex = 7;
            this.EyePictureBox.TabStop = false;
            this.EyePictureBox.Click += new System.EventHandler(this.EyePictureBox_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(140, 390);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(110, 45);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.LoginButton_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(85, 250);
            this.PasswordTextBox.MaxLength = 16;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 47);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // LockPictureBox
            // 
            this.LockPictureBox.Image = global::Hotel.Properties.Resources._lock;
            this.LockPictureBox.Location = new System.Drawing.Point(35, 250);
            this.LockPictureBox.Name = "LockPictureBox";
            this.LockPictureBox.Size = new System.Drawing.Size(48, 48);
            this.LockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockPictureBox.TabIndex = 4;
            this.LockPictureBox.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(85, 160);
            this.LoginTextBox.MaxLength = 12;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginTextBox.Size = new System.Drawing.Size(250, 47);
            this.LoginTextBox.TabIndex = 3;
            this.LoginTextBox.Enter += new System.EventHandler(this.LoginTextBox_Enter);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Hotel.Properties.Resources.user;
            this.UserPicture.Location = new System.Drawing.Point(35, 160);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(48, 48);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 2;
            this.UserPicture.TabStop = false;
            // 
            // LoginTextLabel
            // 
            this.LoginTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTextLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginTextLabel.Location = new System.Drawing.Point(0, 30);
            this.LoginTextLabel.Name = "LoginTextLabel";
            this.LoginTextLabel.Size = new System.Drawing.Size(398, 42);
            this.LoginTextLabel.TabIndex = 1;
            this.LoginTextLabel.Text = "Авторизация";
            this.LoginTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ClosePanel.Size = new System.Drawing.Size(398, 30);
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
            this.CloseLabel.Location = new System.Drawing.Point(373, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginTextLabel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox LockPictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox EyePictureBox;
        private System.Windows.Forms.Label LogToRegLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label GuestLabel;
    }
}