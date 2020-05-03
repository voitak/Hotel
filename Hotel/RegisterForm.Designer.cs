namespace Hotel
{
    partial class RegisterForm
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
            this.RegPanel = new System.Windows.Forms.Panel();
            this.EyePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegMailTextBox = new System.Windows.Forms.TextBox();
            this.RegNameTextBox = new System.Windows.Forms.TextBox();
            this.RegPhoneTextBox = new System.Windows.Forms.TextBox();
            this.RegLastnameTextBox = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.RegPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegLockPictureBox = new System.Windows.Forms.PictureBox();
            this.RegLoginTextBox = new System.Windows.Forms.TextBox();
            this.RegUserPicture = new System.Windows.Forms.PictureBox();
            this.RegTextLabel = new System.Windows.Forms.Label();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.RegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegLockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegUserPicture)).BeginInit();
            this.ClosePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegPanel
            // 
            this.RegPanel.BackColor = System.Drawing.Color.White;
            this.RegPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegPanel.Controls.Add(this.EyePictureBox);
            this.RegPanel.Controls.Add(this.pictureBox2);
            this.RegPanel.Controls.Add(this.pictureBox1);
            this.RegPanel.Controls.Add(this.RegMailTextBox);
            this.RegPanel.Controls.Add(this.RegNameTextBox);
            this.RegPanel.Controls.Add(this.RegPhoneTextBox);
            this.RegPanel.Controls.Add(this.RegLastnameTextBox);
            this.RegPanel.Controls.Add(this.RegButton);
            this.RegPanel.Controls.Add(this.RegPasswordTextBox);
            this.RegPanel.Controls.Add(this.RegLockPictureBox);
            this.RegPanel.Controls.Add(this.RegLoginTextBox);
            this.RegPanel.Controls.Add(this.RegUserPicture);
            this.RegPanel.Controls.Add(this.RegTextLabel);
            this.RegPanel.Controls.Add(this.ClosePanel);
            this.RegPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegPanel.Location = new System.Drawing.Point(0, 0);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(400, 500);
            this.RegPanel.TabIndex = 1;
            // 
            // EyePictureBox
            // 
            this.EyePictureBox.Image = global::Hotel.Properties.Resources.eye;
            this.EyePictureBox.Location = new System.Drawing.Point(341, 331);
            this.EyePictureBox.Name = "EyePictureBox";
            this.EyePictureBox.Size = new System.Drawing.Size(40, 40);
            this.EyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EyePictureBox.TabIndex = 13;
            this.EyePictureBox.TabStop = false;
            this.EyePictureBox.Click += new System.EventHandler(this.EyePictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel.Properties.Resources.phone;
            this.pictureBox2.Location = new System.Drawing.Point(40, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(40, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegMailTextBox
            // 
            this.RegMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegMailTextBox.Location = new System.Drawing.Point(85, 239);
            this.RegMailTextBox.MaxLength = 20;
            this.RegMailTextBox.Name = "RegMailTextBox";
            this.RegMailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegMailTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegMailTextBox.TabIndex = 10;
            this.RegMailTextBox.Enter += new System.EventHandler(this.RegMailTextBox_Enter);
            this.RegMailTextBox.Leave += new System.EventHandler(this.RegMailTextBox_Leave);
            // 
            // RegNameTextBox
            // 
            this.RegNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegNameTextBox.Location = new System.Drawing.Point(85, 101);
            this.RegNameTextBox.MaxLength = 16;
            this.RegNameTextBox.Name = "RegNameTextBox";
            this.RegNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegNameTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegNameTextBox.TabIndex = 9;
            this.RegNameTextBox.Enter += new System.EventHandler(this.RegNameTextBox_Enter);
            this.RegNameTextBox.Leave += new System.EventHandler(this.RegNameTextBox_Leave);
            // 
            // RegPhoneTextBox
            // 
            this.RegPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPhoneTextBox.Location = new System.Drawing.Point(85, 285);
            this.RegPhoneTextBox.MaxLength = 12;
            this.RegPhoneTextBox.Name = "RegPhoneTextBox";
            this.RegPhoneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegPhoneTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegPhoneTextBox.TabIndex = 8;
            this.RegPhoneTextBox.Enter += new System.EventHandler(this.RegPhoneTextBox_Enter);
            this.RegPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegPhoneTextBox_KeyPress);
            this.RegPhoneTextBox.Leave += new System.EventHandler(this.RegPhoneTextBox_Leave);
            // 
            // RegLastnameTextBox
            // 
            this.RegLastnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegLastnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLastnameTextBox.Location = new System.Drawing.Point(85, 147);
            this.RegLastnameTextBox.MaxLength = 16;
            this.RegLastnameTextBox.Name = "RegLastnameTextBox";
            this.RegLastnameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegLastnameTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegLastnameTextBox.TabIndex = 7;
            this.RegLastnameTextBox.Enter += new System.EventHandler(this.RegLastnameTextBox_Enter);
            this.RegLastnameTextBox.Leave += new System.EventHandler(this.RegLastnameTextBox_Leave);
            // 
            // RegButton
            // 
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(100, 390);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(212, 45);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegPasswordTextBox
            // 
            this.RegPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPasswordTextBox.Location = new System.Drawing.Point(85, 331);
            this.RegPasswordTextBox.MaxLength = 16;
            this.RegPasswordTextBox.Name = "RegPasswordTextBox";
            this.RegPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegPasswordTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegPasswordTextBox.TabIndex = 5;
            this.RegPasswordTextBox.UseSystemPasswordChar = true;
            this.RegPasswordTextBox.Enter += new System.EventHandler(this.RegPasswordTextBox_Enter);
            this.RegPasswordTextBox.Leave += new System.EventHandler(this.RegPasswordTextBox_Leave);
            // 
            // RegLockPictureBox
            // 
            this.RegLockPictureBox.Image = global::Hotel.Properties.Resources._lock;
            this.RegLockPictureBox.Location = new System.Drawing.Point(40, 331);
            this.RegLockPictureBox.Name = "RegLockPictureBox";
            this.RegLockPictureBox.Size = new System.Drawing.Size(40, 40);
            this.RegLockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegLockPictureBox.TabIndex = 4;
            this.RegLockPictureBox.TabStop = false;
            // 
            // RegLoginTextBox
            // 
            this.RegLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLoginTextBox.Location = new System.Drawing.Point(85, 193);
            this.RegLoginTextBox.MaxLength = 12;
            this.RegLoginTextBox.Name = "RegLoginTextBox";
            this.RegLoginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegLoginTextBox.Size = new System.Drawing.Size(250, 40);
            this.RegLoginTextBox.TabIndex = 3;
            this.RegLoginTextBox.Enter += new System.EventHandler(this.RegLoginTextBox_Enter);
            this.RegLoginTextBox.Leave += new System.EventHandler(this.RegLoginTextBox_Leave);
            // 
            // RegUserPicture
            // 
            this.RegUserPicture.Image = global::Hotel.Properties.Resources.user;
            this.RegUserPicture.Location = new System.Drawing.Point(40, 193);
            this.RegUserPicture.Name = "RegUserPicture";
            this.RegUserPicture.Size = new System.Drawing.Size(40, 40);
            this.RegUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegUserPicture.TabIndex = 2;
            this.RegUserPicture.TabStop = false;
            // 
            // RegTextLabel
            // 
            this.RegTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegTextLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegTextLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegTextLabel.Location = new System.Drawing.Point(0, 30);
            this.RegTextLabel.Name = "RegTextLabel";
            this.RegTextLabel.Size = new System.Drawing.Size(398, 42);
            this.RegTextLabel.TabIndex = 1;
            this.RegTextLabel.Text = "Регистрация";
            this.RegTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.White;
            this.ClosePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClosePanel.Controls.Add(this.CloseLabel);
            this.ClosePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClosePanel.Location = new System.Drawing.Point(0, 0);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(398, 30);
            this.ClosePanel.TabIndex = 0;
            this.ClosePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseDown);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClosePanel_MouseMove);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.RegPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegLockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegUserPicture)).EndInit();
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox RegPasswordTextBox;
        private System.Windows.Forms.PictureBox RegLockPictureBox;
        private System.Windows.Forms.TextBox RegLoginTextBox;
        private System.Windows.Forms.PictureBox RegUserPicture;
        private System.Windows.Forms.Label RegTextLabel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.TextBox RegPhoneTextBox;
        private System.Windows.Forms.TextBox RegLastnameTextBox;
        private System.Windows.Forms.TextBox RegMailTextBox;
        private System.Windows.Forms.TextBox RegNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox EyePictureBox;
    }
}