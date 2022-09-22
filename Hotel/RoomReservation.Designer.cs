namespace Hotel
{
    partial class RoomReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomReservation));
            this.ReservePanel = new System.Windows.Forms.Panel();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ReservButton = new System.Windows.Forms.Button();
            this.BeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ReservePanel.SuspendLayout();
            this.ClosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservePanel
            // 
            this.ReservePanel.BackColor = System.Drawing.Color.White;
            this.ReservePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReservePanel.Controls.Add(this.ToLabel);
            this.ReservePanel.Controls.Add(this.FromLabel);
            this.ReservePanel.Controls.Add(this.DateLabel);
            this.ReservePanel.Controls.Add(this.ReservButton);
            this.ReservePanel.Controls.Add(this.BeginDateTimePicker);
            this.ReservePanel.Controls.Add(this.EndDateTimePicker);
            this.ReservePanel.Controls.Add(this.ClosePanel);
            this.ReservePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReservePanel.Location = new System.Drawing.Point(0, 0);
            this.ReservePanel.Name = "ReservePanel";
            this.ReservePanel.Size = new System.Drawing.Size(420, 160);
            this.ReservePanel.TabIndex = 3;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLabel.ForeColor = System.Drawing.Color.Black;
            this.ToLabel.Location = new System.Drawing.Point(203, 75);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(34, 22);
            this.ToLabel.TabIndex = 35;
            this.ToLabel.Text = "до";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromLabel.ForeColor = System.Drawing.Color.Black;
            this.FromLabel.Location = new System.Drawing.Point(3, 75);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(22, 22);
            this.FromLabel.TabIndex = 34;
            this.FromLabel.Text = "с";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(133, 46);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(192, 22);
            this.DateLabel.TabIndex = 33;
            this.DateLabel.Text = "Даты размещения:";
            // 
            // ReservButton
            // 
            this.ReservButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReservButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservButton.Location = new System.Drawing.Point(137, 117);
            this.ReservButton.Name = "ReservButton";
            this.ReservButton.Size = new System.Drawing.Size(146, 30);
            this.ReservButton.TabIndex = 25;
            this.ReservButton.Text = "Забронировать";
            this.ReservButton.UseVisualStyleBackColor = true;
            this.ReservButton.Click += new System.EventHandler(this.ReservButton_Click);
            this.ReservButton.MouseEnter += new System.EventHandler(this.ReservButton_MouseEnter);
            this.ReservButton.MouseLeave += new System.EventHandler(this.ReservButton_MouseLeave);
            // 
            // BeginDateTimePicker
            // 
            this.BeginDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginDateTimePicker.Location = new System.Drawing.Point(27, 71);
            this.BeginDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.BeginDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.BeginDateTimePicker.Name = "BeginDateTimePicker";
            this.BeginDateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.BeginDateTimePicker.TabIndex = 27;
            this.BeginDateTimePicker.Value = new System.DateTime(2020, 5, 9, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(243, 71);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.EndDateTimePicker.TabIndex = 21;
            this.EndDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
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
            // RoomReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 160);
            this.Controls.Add(this.ReservePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomReservation";
            this.ReservePanel.ResumeLayout(false);
            this.ReservePanel.PerformLayout();
            this.ClosePanel.ResumeLayout(false);
            this.ClosePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReservePanel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button ReservButton;
        private System.Windows.Forms.DateTimePicker BeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label CloseLabel;
    }
}