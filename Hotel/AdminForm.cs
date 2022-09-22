using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AdminForm : Form
    {
        string table = "";
        string name = "";
        string nameInfo = "";
        string tableInfo = "";
        string id;
        string buttonType;

        public AdminForm(string lu)
        {
            InitializeComponent();

            MyButton.BackColor = Color.FromArgb(171, 144, 84);
            MyButton.ForeColor = Color.White;
            RoomButton.BackColor = Color.FromArgb(171, 144, 84);
            RoomButton.ForeColor = Color.White;
            FavouriteListButton.BackColor = Color.FromArgb(171, 144, 84);
            FavouriteListButton.ForeColor = Color.White;
            ActivityButton.BackColor = Color.FromArgb(171, 144, 84);
            ActivityButton.ForeColor = Color.White;
            RestarauntsButton.BackColor = Color.FromArgb(171, 144, 84);
            RestarauntsButton.ForeColor = Color.White;
            QaAButton.BackColor = Color.FromArgb(171, 144, 84);
            QaAButton.ForeColor = Color.White;
            ContactButton.BackColor = Color.FromArgb(171, 144, 84);
            ContactButton.ForeColor = Color.White;
            LeftButton.BackColor = Color.FromArgb(171, 144, 84);
            LeftButton.ForeColor = Color.White;
            AdminButton.BackColor = Color.White;
            AdminButton.ForeColor = Color.FromArgb(171, 144, 84);

            id = lu;

            this.ActiveControl = ClosePanel;

            WhatImgComboBox.Visible = false;
            WhatImgLabel.Visible = false;

            WhatInfoComboBox.Visible = false;
            WhatInfoLabel.Visible = false;
        }

        private void AddImgButton_Click(object sender, EventArgs e)
        {
            if (WhereImgComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите данные!");
                return;
            }

            if (table != "qaa")
            {
                if (WhatImgComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите данные!");
                    return;
                }
            }

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureHided.Image = Image.FromFile(dialog.FileName);

                MemoryStream ms = new MemoryStream();
                pictureHided.Image.Save(ms, pictureHided.Image.RawFormat);
                byte[] img = ms.ToArray();

                DB db= new DB();

                if (table == "rooms")
                {
                    MySqlCommand command = new MySqlCommand
                       ("UPDATE `rooms` SET `image` = @img WHERE `title` = @nm", db.getConnection());
                    command.Parameters.AddWithValue("@nm", WhatImgComboBox.Text);

                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Картинка загружена");
                    }
                    db.closeConnection();
                }
                else if (table == "restaraunts")
                {
                    MySqlCommand command = new MySqlCommand
                       ("UPDATE `restaraunts` SET `image` = @img WHERE `name` = @nm", db.getConnection());
                    command.Parameters.AddWithValue("@nm", WhatImgComboBox.Text);

                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Картинка загружена");
                    }
                    db.closeConnection();
                }
                else if (table == "qaa")
                {
                    MySqlCommand command = new MySqlCommand
                        ("UPDATE `qaa` SET `image` = @img WHERE id = 1", db.getConnection());

                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Картинка загружена");
                    }
                    db.closeConnection();
                }

                AdminForm Form = new AdminForm(id);
                Form.Show();
                Form.Top = this.Top;
                Form.Left = this.Left;
                this.Dispose();
            }
        }

        private void WhereImgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            WhatImgComboBox.Visible = true;
            WhatImgComboBox.Items.Clear();
            WhatImgLabel.Visible = true;

            WhatImgComboBox.Size = new System.Drawing.Size(170, 29);
            AddImgButton.Location = new System.Drawing.Point(802, 346);

            if (WhereImgComboBox.SelectedItem.ToString() == "Номера")
            {
                table = "rooms";
                name = "title";
                WhatImgComboBox.Size = new System.Drawing.Size(170, 29);
                AddImgButton.Location = new System.Drawing.Point(802, 346);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM rooms", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WhatImgComboBox.Items.Add(reader[name].ToString());
                }

                reader.Dispose();
                db.closeConnection();
            }    
            else if (WhereImgComboBox.SelectedItem.ToString() == "Рестораны")
            {
                table = "restaraunts";
                name = "name";

                WhatImgComboBox.Size = new System.Drawing.Size(270, 29);
                AddImgButton.Location = new System.Drawing.Point(902, 346);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM restaraunts", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WhatImgComboBox.Items.Add(reader[name].ToString());
                }

                reader.Dispose();
                db.closeConnection();
            }
            else if(WhereImgComboBox.SelectedItem.ToString() == "Вопросы и ответы")
            {
                table = "qaa";

                WhatImgComboBox.Size = new System.Drawing.Size(170, 29);
                AddImgButton.Location = new System.Drawing.Point(802, 346);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM qaa", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                WhatImgComboBox.Visible = false;
                WhatImgLabel.Visible = false;

                reader.Dispose();
                db.closeConnection();
            }
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            if (WhereInfoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите данные!");
                return;
            }

            if ((tableInfo != "qaa") && (tableInfo != "contacts"))
            {
                if (WhatInfoComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите данные!");
                    return;
                }
            }

            buttonType = "change";

            InfoChangeForm activity = new InfoChangeForm(id, tableInfo, WhatInfoComboBox.Text, buttonType);
            activity.Show();
        }

        private void WhereInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhatInfoComboBox.Visible = true;
            WhatInfoComboBox.Items.Clear();
            WhatInfoLabel.Visible = true;

            WhatInfoComboBox.Size = new System.Drawing.Size(170, 29);
            ChangeInfoButton.Location = new System.Drawing.Point(802, 497);

            if (WhereInfoComboBox.SelectedItem.ToString() == "Номера")
            {
                tableInfo = "rooms";
                nameInfo = "title";
                WhatInfoComboBox.Size = new System.Drawing.Size(170, 29);
                ChangeInfoButton.Location = new System.Drawing.Point(802, 497);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM rooms", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WhatInfoComboBox.Items.Add(reader[nameInfo].ToString());
                }

                reader.Dispose();
                db.closeConnection();
            }
            else if (WhereInfoComboBox.SelectedItem.ToString() == "Рестораны")
            {
                tableInfo = "restaraunts";
                nameInfo = "name";

                WhatInfoComboBox.Size = new System.Drawing.Size(270, 29);
                ChangeInfoButton.Location = new System.Drawing.Point(902, 497);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM restaraunts", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WhatInfoComboBox.Items.Add(reader[nameInfo].ToString());
                }

                reader.Dispose();
                db.closeConnection();
            }
            else if (WhereInfoComboBox.SelectedItem.ToString() == "Мероприятия")
            {
                tableInfo = "activity";
                nameInfo = "name";

                WhatInfoComboBox.Size = new System.Drawing.Size(270, 29);
                ChangeInfoButton.Location = new System.Drawing.Point(902, 497);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `activity`", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    WhatInfoComboBox.Items.Add(reader[nameInfo].ToString());
                }

                reader.Dispose();
                db.closeConnection();
            }
            else if (WhereInfoComboBox.SelectedItem.ToString() == "Вопросы и ответы")
            {
                tableInfo = "qaa";

                WhatInfoComboBox.Size = new System.Drawing.Size(170, 29);
                ChangeInfoButton.Location = new System.Drawing.Point(802, 497);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `qaa`", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                WhatInfoComboBox.Visible = false;
                WhatInfoLabel.Visible = false;

                reader.Dispose();
                db.closeConnection();
            }
            else if (WhereInfoComboBox.SelectedItem.ToString() == "Контакты")
            {
                tableInfo = "contacts";

                WhatInfoComboBox.Size = new System.Drawing.Size(170, 29);
                ChangeInfoButton.Location = new System.Drawing.Point(802, 497);

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts`", db.getConnection());

                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                WhatInfoComboBox.Visible = false;
                WhatInfoLabel.Visible = false;

                reader.Dispose();
                db.closeConnection();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(WhatAddComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите данные!");
                return;
            }

            buttonType = "add";

            InfoChangeForm activity = new InfoChangeForm(id, tableInfo, WhatAddComboBox.Text, buttonType);
            activity.Show();
        }
        private void WhatAddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhatAddComboBox.SelectedItem.ToString() == "Номер")
            {
                tableInfo = "rooms";
            }
            else if (WhatAddComboBox.SelectedItem.ToString() == "Ресторан")
            {
                tableInfo = "restaraunts";
            }
            else if (WhatAddComboBox.SelectedItem.ToString() == "Мероприятие")
            {
                tableInfo = "activity";
            }
        }
        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.Silver;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.White;
        }

        Point lastPoint;
        private void ClosePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ClosePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MainForm activity = new MainForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            RoomForm activity = new RoomForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void FavouriteListButton_Click(object sender, EventArgs e)
        {
            FavouriteForm activity = new FavouriteForm(id);
            activity.Left = this.Left;
            activity.Top = this.Top;
            activity.Show();
            this.Dispose();
        }

        private void ActivityButton_Click(object sender, EventArgs e)
        {
            ActivityForm activity = new ActivityForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void RestarauntsButton_Click(object sender, EventArgs e)
        {
            RestarauntsForm activity = new RestarauntsForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void QaAButton_Click(object sender, EventArgs e)
        {
            QaAForm activity = new QaAForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            ContactForm activity = new ContactForm(id);
            activity.Show();
            activity.Left = this.Left;
            activity.Top = this.Top;
            this.Dispose();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (id == "guest")
            {
                int temp = -1;
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "LoginForm")
                    {
                        Application.OpenForms[i].Dispose();
                    }
                    else
                    {
                        temp = i;
                    }
                }

                if (temp != -1)
                {
                    Application.OpenForms[temp].Show();
                }
            }
            else
            {
                Form Form = Application.OpenForms[0];
                if (Application.OpenForms["LeftForm"] != null)
                {
                    Form = Application.OpenForms["LeftForm"];
                }
                else
                {
                    Form = new LeftForm();
                }
                Form.Show();
            }
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            UsersForm activity = new UsersForm();
            activity.Show();
        }

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.White;
            MyButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            MyButton.BackColor = Color.FromArgb(171, 144, 84);
            MyButton.ForeColor = Color.White;
        }

        private void RoomButton_MouseEnter(object sender, EventArgs e)
        {
            RoomButton.BackColor = Color.White;
            RoomButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void RoomButton_MouseLeave(object sender, EventArgs e)
        {
            RoomButton.BackColor = Color.FromArgb(171, 144, 84);
            RoomButton.ForeColor = Color.White;
        }

        private void FavouriteListButton_MouseEnter(object sender, EventArgs e)
        {
            FavouriteListButton.BackColor = Color.White;
            FavouriteListButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void FavouriteListButton_MouseLeave(object sender, EventArgs e)
        {
            FavouriteListButton.BackColor = Color.FromArgb(171, 144, 84);
            FavouriteListButton.ForeColor = Color.White;
        }

        private void ActivityButton_MouseEnter(object sender, EventArgs e)
        {
            ActivityButton.BackColor = Color.White;
            ActivityButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void ActivityButton_MouseLeave(object sender, EventArgs e)
        {
            ActivityButton.BackColor = Color.FromArgb(171, 144, 84);
            ActivityButton.ForeColor = Color.White;
        }

        private void RestarauntsButton_MouseEnter(object sender, EventArgs e)
        {
            RestarauntsButton.BackColor = Color.White;
            RestarauntsButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void RestarauntsButton_MouseLeave(object sender, EventArgs e)
        {
            RestarauntsButton.BackColor = Color.FromArgb(171, 144, 84);
            RestarauntsButton.ForeColor = Color.White;
        }

        private void QaAButton_MouseEnter(object sender, EventArgs e)
        {
            QaAButton.BackColor = Color.White;
            QaAButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void QaAButton_MouseLeave(object sender, EventArgs e)
        {
            QaAButton.BackColor = Color.FromArgb(171, 144, 84);
            QaAButton.ForeColor = Color.White;
        }

        private void ContactButton_MouseEnter(object sender, EventArgs e)
        {
            ContactButton.BackColor = Color.White;
            ContactButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void ContactButton_MouseLeave(object sender, EventArgs e)
        {
            ContactButton.BackColor = Color.FromArgb(171, 144, 84);
            ContactButton.ForeColor = Color.White;
        }

        private void LeftButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButton.BackColor = Color.White;
            LeftButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void LeftButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButton.BackColor = Color.FromArgb(171, 144, 84);
            LeftButton.ForeColor = Color.White;
        }


    }
}
