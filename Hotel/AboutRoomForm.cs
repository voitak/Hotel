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
    public partial class AboutRoomForm : Form
    {
        string roomid;
        public AboutRoomForm(string lu)
        {
            InitializeComponent();

            roomid = lu;

            NameLabel.ForeColor = Color.FromArgb(171, 144, 84);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `title`,`info` FROM `rooms` WHERE `id` = @rI", db.getConnection());
            command.Parameters.AddWithValue("@rI", roomid);

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                NameLabel.Text = reader["title"].ToString();
                TextLabel.Text = reader["info"].ToString();
            }

            db.closeConnection();

            MySqlCommand commandImg = new MySqlCommand
                ("SELECT `image` FROM `rooms` WHERE `id` = @rI", db.getConnection());
            commandImg.Parameters.AddWithValue("@rI", roomid);

            db.openConnection();
            MySqlDataReader reader2 = commandImg.ExecuteReader();

            if (reader2.Read())
            {
                byte[] image = (byte[])(reader2.GetValue(0));
                if (image == null)
                {
                    AboutPictureBox.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(image);
                    AboutPictureBox.Image = System.Drawing.Image.FromStream(mstream);
                }
            }

            reader2.Dispose();
            db.closeConnection();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
