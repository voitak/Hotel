using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class RateForm : Form
    {
        string id;
        string roomId;    
        public RateForm(string uid, string rid)
        {
            InitializeComponent();

            id = uid;
            roomId = rid;
        }

        private void RateButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand commandDel = new MySqlCommand
                        ("SELECT * FROM `rating` WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
            commandDel.Parameters.AddWithValue("@rI", roomId);
            commandDel.Parameters.AddWithValue("@uI", id);

            db.openConnection();
            MySqlDataReader reader = commandDel.ExecuteReader();
            if (!reader.Read())
            {
                reader.Dispose();
                db.closeConnection();


                MySqlCommand command = new MySqlCommand
                             ("INSERT INTO `rating` (`usersId`,`roomsId`,`ratingNumb`) VALUES" +
                "(@uI, @rI, @r);", db.getConnection());
                command.Parameters.AddWithValue("@uI", id);
                command.Parameters.AddWithValue("@rI", roomId);
                command.Parameters.AddWithValue("@r", RateComboBox.Text);

                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            else
            {
                reader.Dispose();
                db.closeConnection();
                MySqlCommand command = new MySqlCommand
                        ("UPDATE `rating` SET `ratingNumb` = @r " +
                        "WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
                command.Parameters.AddWithValue("@r", RateComboBox.Text);
                command.Parameters.AddWithValue("@uI", id);
                command.Parameters.AddWithValue("@rI", roomId);

                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }

            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["RoomForm"] != null)
            {
                Form = new RoomForm(id);
                this.Dispose();

                Form.Top = Application.OpenForms["RoomForm"].Top;
                Form.Left = Application.OpenForms["RoomForm"].Left;

                Form.Show();
                Application.OpenForms["RoomForm"].Dispose();
            }
            else
            {
                Form = new RoomForm(id);
                this.Dispose();

                Form.Top = Application.OpenForms["RoomForm"].Top;
                Form.Left = Application.OpenForms["RoomForm"].Left;

                Form.Show();
                Application.OpenForms["RoomForm"].Dispose();
            }
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
        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.Gainsboro;
            CloseLabel.ForeColor = Color.FromArgb(171, 144, 84);
        }
        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.White;
            CloseLabel.ForeColor = Color.Black;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
