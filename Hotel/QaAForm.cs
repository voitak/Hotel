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
    public partial class QaAForm : Form
    {
        string id;
        public QaAForm(string lu)
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
            QaAButton.BackColor = Color.White;
            QaAButton.ForeColor = Color.FromArgb(171, 144, 84);
            ContactButton.BackColor = Color.FromArgb(171, 144, 84);
            ContactButton.ForeColor = Color.White;
            LeftButton.BackColor = Color.FromArgb(171, 144, 84);
            LeftButton.ForeColor = Color.White;

            QaALabel.BringToFront();

            ManagmentButton.BackColor = Color.FromArgb(171, 144, 84);
            ManagmentButton.ForeColor = Color.White;

            ManagmentButton.Visible = false;

            this.ActiveControl = ClosePanel;

            id = lu;

            if (id == "admin")
            {
                ManagmentButton.Visible = true;
            }

            if (id == "guest")
            {
                LeftButton.Text = "Войти";
            }

            QaALabel.ForeColor = Color.FromArgb(171, 144, 84);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `info` FROM `QaA` WHERE id = 1", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                QaATextLabel.Text = reader.GetValue(0).ToString();
            }
            reader.Dispose();
            db.closeConnection();

            MySqlCommand commandImg = new MySqlCommand
                ("SELECT `image` FROM `qaa` WHERE id = 1", db.getConnection());
            db.openConnection();
            MySqlDataReader reader2 = commandImg.ExecuteReader();

            if (reader2.Read())
            {
                byte[] image = (byte[])(reader2.GetValue(0));
                if (image == null)
                {
                    qaaPictureBox.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(image);
                    qaaPictureBox.Image = System.Drawing.Image.FromStream(mstream);
                }
            }

            reader2.Dispose();
            db.closeConnection();

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
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["ActivityForm"] != null)
            {
                Form = Application.OpenForms["ActivityForm"];
            }
            else
            {
                Form = new ActivityForm(id);
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
        }

        private void RestarauntsButton_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["RestarauntsForm"] != null)
            {
                Form = Application.OpenForms["RestarauntsForm"];
            }
            else
            {
                Form = new RestarauntsForm(id);
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["ContactForm"] != null)
            {
                Form = Application.OpenForms["ContactForm"];
            }
            else
            {
                Form = new ContactForm(id);
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
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

        private void ManagmentButton_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["AdminForm"] != null)
            {
                Form = Application.OpenForms["AdminForm"];
            }
            else
            {
                Form = new AdminForm(id);
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
        }

        private void ManagmentButton_MouseEnter(object sender, EventArgs e)
        {
            ManagmentButton.BackColor = Color.White;
            ManagmentButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void ManagmentButton_MouseLeave(object sender, EventArgs e)
        {
            ManagmentButton.BackColor = Color.FromArgb(171, 144, 84);
            ManagmentButton.ForeColor = Color.White;
        }
    }
}
