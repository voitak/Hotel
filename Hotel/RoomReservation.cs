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
    public partial class RoomReservation : Form
    {
        string uID;
        string rID;
        public RoomReservation(string userID, string roomID)
        {
            InitializeComponent();

            uID = userID;
            rID = roomID;

            ReservButton.BackColor = Color.FromArgb(171, 144, 84);
            ReservButton.ForeColor = Color.White;
        }

        private void ReservButton_Click(object sender, EventArgs e)
        {
            string beginDateSQL;
            string endDateSQL;

            string beginDate = BeginDateTimePicker.Text;
            string endDate = EndDateTimePicker.Text;
            string[] beginWords = beginDate.Split('.');
            string[] endWords = endDate.Split('.');
            int temp1, temp2;

            temp1 = 31 * (Int32.Parse(beginWords[1]) - 1) + (Int32.Parse(beginWords[0]));
            temp2 = 31 * (Int32.Parse(endWords[1]) - 1) + (Int32.Parse(endWords[0]));

            if (temp1 > temp2)
            {
                MessageBox.Show("Выберите корректную дату!");
                return;
            }    

            DB db = new DB();

            MySqlCommand command = new MySqlCommand
                ("SELECT * FROM `orders` WHERE `roomsId` = @rI", db.getConnection());
            command.Parameters.Add("@rI", MySqlDbType.VarChar).Value = rID;
           // command.Parameters.Add("@uI", MySqlDbType.VarChar).Value = uID;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                beginDateSQL = reader["beginDate"].ToString();
                endDateSQL = reader["endDate"].ToString();
                string[] beginWordsSQL = beginDateSQL.Split('.');
                string[] endWordsSQL = endDateSQL.Split('.');


                for(int i = 31 * (Int32.Parse(beginWords[1]) - 1) + (Int32.Parse(beginWords[0])); 
                    i < 31 * (Int32.Parse(endWords[1]) - 1) + (Int32.Parse(endWords[0])); i++)
                {
                    for (int j = 31 * (Int32.Parse(beginWordsSQL[1]) - 1) + (Int32.Parse(beginWordsSQL[0]));
                        j < 31 * (Int32.Parse(endWordsSQL[1]) - 1) + (Int32.Parse(endWordsSQL[0])); j++)
                    {
                        if(i == j)
                        {
                            MessageBox.Show("Данная комната занята с " + beginDateSQL + " до " + endDateSQL +
                            "\nВыберите другую дату!");
                            return;
                        }
                    }
                }
            }

            reader.Dispose();
            db.closeConnection();

            MySqlCommand command1 = new MySqlCommand
                ("INSERT INTO `orders` (`roomsId`,`usersId`,`beginDate`,`endDate`) VALUES" +
                "(@rI, @uI, @bd, @ed);", db.getConnection());
            command1.Parameters.AddWithValue("@rI", rID);
            command1.Parameters.AddWithValue("@uI", uID);
            command1.Parameters.AddWithValue("@bd", beginDate);
            command1.Parameters.AddWithValue("@ed", endDate);

            db.openConnection();
            command1.ExecuteNonQuery();
            db.closeConnection();

            this.Hide();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void ReservButton_MouseEnter(object sender, EventArgs e)
        {
            ReservButton.BackColor = Color.White;
            ReservButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void ReservButton_MouseLeave(object sender, EventArgs e)
        {
            ReservButton.BackColor = Color.FromArgb(171, 144, 84);
            ReservButton.ForeColor = Color.White;
        }
    }
}
