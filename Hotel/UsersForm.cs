using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class UsersForm : Form
    {
        string id;
        string roomid;
        private Panel[] Panel1;  
        private int count = -1;
        //Counter for Dynamic Buttons.
        int DynamicButtonCount = 1;
        public UsersForm()
        {
            InitializeComponent();

            this.ActiveControl = ClosePanel;

            Panel1 = new Panel[100];


            DB db = new DB();
            MySqlCommand command = new MySqlCommand
                ("SELECT users.id, users.name, users.lastname, users.mail, users.phone, rooms.title, rooms.id, orders.beginDate, orders.endDate " +
                "FROM `users` JOIN `orders` ON users.id = orders.usersId JOIN `rooms` ON rooms.id = orders.roomsId", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                write_panel(reader);
            }

            db.closeConnection();
        }

        void write_panel(MySqlDataReader reader)
        {
            count++;

            Panel1[count] = new Panel();
            Panel1[count].BackColor = Color.White;
            Panel1[count].BorderStyle = BorderStyle.FixedSingle;
            Panel1[count].Size = new System.Drawing.Size(900, 150);
            Panel1[count].Name = reader.GetValue(0).ToString();


            Label nameInfoLabel = new Label();
            nameInfoLabel.Text = "Имя:";
            nameInfoLabel.ForeColor = Color.Black;
            nameInfoLabel.Font = new Font("Century Gothic", 18);
            nameInfoLabel.Size = new System.Drawing.Size(70, 30);
            nameInfoLabel.Location = new System.Drawing.Point(0, 0);

            Label lastInfoLabel = new Label();
            lastInfoLabel.Text = "Фамилия:";
            lastInfoLabel.ForeColor = Color.Black;
            lastInfoLabel.Font = new Font("Century Gothic", 18);
            lastInfoLabel.Size = new System.Drawing.Size(140, 30);
            lastInfoLabel.Location = new System.Drawing.Point(0, 30);

            Label mailInfoLabel = new Label();
            mailInfoLabel.Text = "Почта:";
            mailInfoLabel.ForeColor = Color.Black;
            mailInfoLabel.Font = new Font("Century Gothic", 18);
            mailInfoLabel.Size = new System.Drawing.Size(140, 30);
            mailInfoLabel.Location = new System.Drawing.Point(0, 60);

            Label phoneInfoLabel = new Label();
            phoneInfoLabel.Text = "Телефон:";
            phoneInfoLabel.ForeColor = Color.Black;
            phoneInfoLabel.Font = new Font("Century Gothic", 18);
            phoneInfoLabel.Size = new System.Drawing.Size(140, 30);
            phoneInfoLabel.Location = new System.Drawing.Point(0, 90);            
            
            Label titleInfoLabel = new Label();
            titleInfoLabel.Text = "Номер:";
            titleInfoLabel.ForeColor = Color.Black;
            titleInfoLabel.Font = new Font("Century Gothic", 18);
            titleInfoLabel.Size = new System.Drawing.Size(140, 30);
            titleInfoLabel.Location = new System.Drawing.Point(0, 115);

            ///////////////////////////////////////////////////////////////

            Label nameLabel = new Label();
            nameLabel.Text = reader["name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 20);
            nameLabel.Size = new System.Drawing.Size(500, 30);
            nameLabel.Location = new System.Drawing.Point(140, 0);

            Label lastLabel = new Label();
            lastLabel.Text = reader["lastname"].ToString();
            lastLabel.ForeColor = Color.Black;
            lastLabel.Font = new Font("Century Gothic", 20);
            lastLabel.Size = new System.Drawing.Size(500, 30);
            lastLabel.Location = new System.Drawing.Point(140, 30);

            Label mailLabel = new Label();
            mailLabel.Text = reader["mail"].ToString();
            mailLabel.ForeColor = Color.Black;
            mailLabel.Font = new Font("Century Gothic", 20);
            mailLabel.Size = new System.Drawing.Size(500, 30);
            mailLabel.Location = new System.Drawing.Point(140, 60);

            Label phoneLabel = new Label();
            phoneLabel.Text = reader["phone"].ToString();
            phoneLabel.ForeColor = Color.Black;
            phoneLabel.Font = new Font("Century Gothic", 20);
            phoneLabel.Size = new System.Drawing.Size(500, 30);
            phoneLabel.Location = new System.Drawing.Point(140, 90);            
            
            Label titleLabel = new Label();
            titleLabel.Text = reader["title"].ToString();
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Century Gothic", 20);
            titleLabel.Size = new System.Drawing.Size(500, 30);
            titleLabel.Location = new System.Drawing.Point(140, 115);

            Label dateLabel = new Label();
            dateLabel.Name = reader["beginDate"].ToString();
            dateLabel.Text = "c " + reader["beginDate"].ToString() + " до " + reader["endDate"].ToString();
            dateLabel.ForeColor = Color.FromArgb(171, 144, 84);
            dateLabel.Font = new Font("Century Gothic", 18);
            dateLabel.Size = new System.Drawing.Size(500, 30);
            dateLabel.Location = new System.Drawing.Point(420, 120);
            dateLabel.BringToFront();

            string name = "" + DynamicButtonCount;
            Button btnDynamicButton = new Button();
            btnDynamicButton.Name = name + "," + reader.GetValue(6).ToString();
            btnDynamicButton.Text = "Удалить";
            btnDynamicButton.Cursor = Cursors.Hand;
            btnDynamicButton.Size = new System.Drawing.Size(150, 50);
            btnDynamicButton.Font = new Font("Century Gothic", 18);
            btnDynamicButton.Location = new System.Drawing.Point(750, 100);
            btnDynamicButton.Click += new EventHandler(this.btnDeleteButton_Click);
            btnDynamicButton.BringToFront();

            Panel1[count].Controls.Add(nameInfoLabel);
            Panel1[count].Controls.Add(lastInfoLabel);
            Panel1[count].Controls.Add(mailInfoLabel);
            Panel1[count].Controls.Add(phoneInfoLabel);
            Panel1[count].Controls.Add(titleInfoLabel);


            Panel1[count].Controls.Add(btnDynamicButton);
            Panel1[count].Controls.Add(dateLabel);
            Panel1[count].Controls.Add(nameLabel);
            Panel1[count].Controls.Add(lastLabel);
            Panel1[count].Controls.Add(mailLabel);
            Panel1[count].Controls.Add(phoneLabel);
            Panel1[count].Controls.Add(titleLabel);
            flowLayoutPanel1.Controls.Add(Panel1[count]);

            DynamicButtonCount++;
        }

        protected void btnDeleteButton_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);

            string[] name = dynamicButton.Name.Split(',');

            int x = Int32.Parse(name[0]);

            id = Panel1[x - 1].Name;

            flowLayoutPanel1.Controls.Remove(Panel1[x - 1]);
            count--;

            DB db = new DB();

            MySqlCommand command3 = new MySqlCommand
                        ("DELETE FROM `orders` WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
            command3.Parameters.AddWithValue("@uI", id);
            command3.Parameters.AddWithValue("@rI", name[1]);

            db.openConnection();
            command3.ExecuteNonQuery();
            db.closeConnection();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand
                ("SELECT users.id, users.name, users.lastname, users.mail, users.phone, rooms.title, rooms.id, orders.beginDate, orders.endDate " +
                "FROM `users` JOIN `orders` ON users.id = orders.usersId JOIN `rooms` ON rooms.id = orders.roomsId", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                sb.Append(reader["name"].ToString() + " " + reader["lastname"].ToString() + ", " 
                    + reader["mail"].ToString() + ", "+ reader["phone"].ToString() + " - "+ reader["title"].ToString()
                    + " c " + reader["beginDate"].ToString() + " до " + reader["endDate"].ToString());
                sb.Append("\n");
            }

            db.closeConnection();

            var path = @"C:\Users\voitak\Desktop\temp.txt";
            File.WriteAllText(path, sb.ToString());

            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"C:\Users\voitak\Desktop\temp.txt");

            psi.Verb = "PRINT";
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
  

            Process.Start(psi);
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
