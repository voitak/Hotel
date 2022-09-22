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
    public partial class FavouriteForm : Form
    {
        string id;
        string roomid;
        private Panel[] Panel1;    // Array of textboxes
        private int count = -1;
        //Counter for Dynamic Buttons.
        int DynamicButtonCount = 1;
        int countRooms = 0;  
        public FavouriteForm(string lu)
        {
            InitializeComponent();

            MyButton.BackColor = Color.FromArgb(171, 144, 84);
            MyButton.ForeColor = Color.White;
            RoomButton.BackColor = Color.FromArgb(171, 144, 84);
            RoomButton.ForeColor = Color.White;
            FavouriteListButton.BackColor = Color.White;
            FavouriteListButton.ForeColor = Color.FromArgb(171, 144, 84);
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

            Panel1 = new Panel[100];

            DB db = new DB();
            MySqlCommand command = new MySqlCommand
                ("SELECT rooms.id, rooms.title, rooms.price, rooms.variant, rooms.type, rooms.rating " +
                "FROM rooms INNER JOIN `favourite` ON rooms.id = favourite.roomsId WHERE `usersId` = @uI", db.getConnection());
            command.Parameters.AddWithValue("@uI", id);

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            //QaATextLabel.Text = reader.GetValue(0).ToString();

            while (reader.Read())
            {
                countRooms++;
                write_panel(reader);
            }

            reader.Dispose();
            db.closeConnection();
        }

        void write_panel(MySqlDataReader reader)
        {
            count++;

            Panel1[count] = new Panel();
            Panel1[count].BackColor = Color.White;
            Panel1[count].BorderStyle = BorderStyle.FixedSingle;
            Panel1[count].Size = new System.Drawing.Size(320, 160);
            Panel1[count].Name = reader["id"].ToString();


            Label titleLabel = new Label();
            titleLabel.Text = reader["title"].ToString();
            string name0 = "" + DynamicButtonCount;
            titleLabel.Name = name0;
            titleLabel.Click += new EventHandler(this.btnAboutButton_Click);
            titleLabel.Cursor = Cursors.Hand;
            titleLabel.ForeColor = Color.Black;
            titleLabel.ForeColor = Color.FromArgb(171, 144, 84);
            titleLabel.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            titleLabel.Size = new System.Drawing.Size(200, 30);
            titleLabel.Location = new System.Drawing.Point(0, 0);

            Label typeLabel = new Label();
            typeLabel.Text = reader["type"].ToString();
            typeLabel.ForeColor = Color.Black;
            typeLabel.Font = new Font("Century Gothic", 16);
            typeLabel.Size = new System.Drawing.Size(260, 30);
            typeLabel.Location = new System.Drawing.Point(0, 40);

            Label variantLabel = new Label();
            variantLabel.Text = reader["variant"].ToString();
            variantLabel.ForeColor = Color.Black;
            variantLabel.Font = new Font("Century Gothic", 16);
            variantLabel.Size = new System.Drawing.Size(260, 30);
            variantLabel.Location = new System.Drawing.Point(0, 75);

            Label ratingLabel = new Label();
            ratingLabel.Text = "Рейтинг:" + reader["rating"].ToString();
            ratingLabel.ForeColor = Color.FromArgb(171, 144, 84);
            ratingLabel.Font = new Font("Century Gothic", 12);
            ratingLabel.Size = new System.Drawing.Size(150, 30);
            ratingLabel.Location = new System.Drawing.Point(220, 0);

            Label priceLabel = new Label();
            priceLabel.Name = reader["price"].ToString();
            priceLabel.Text = "Цена: " + reader["price"].ToString() + "р./сутки";
            priceLabel.ForeColor = Color.Black;
            priceLabel.Font = new Font("Century Gothic", 12);
            priceLabel.Size = new System.Drawing.Size(200, 25);
            priceLabel.Location = new System.Drawing.Point(0, 115);
            priceLabel.BringToFront();

            if (id != "guest")
            {
                string name = "" + DynamicButtonCount;
                Button btnDynamicButton = new Button();
                btnDynamicButton.Name = name;
                btnDynamicButton.Cursor = Cursors.Hand;
                btnDynamicButton.Text = "Удалить";
                btnDynamicButton.Size = new System.Drawing.Size(150, 30);
                btnDynamicButton.Font = new Font("Century Gothic", 13);
                btnDynamicButton.Location = new System.Drawing.Point(165, 95);
                btnDynamicButton.Click += new EventHandler(this.btnDeleteButton_Click);
                btnDynamicButton.BringToFront();

                Panel1[count].Controls.Add(btnDynamicButton);

                string name2 = "" + DynamicButtonCount;
                Button btnReserveButton = new Button();
                btnReserveButton.Name = name;
                btnReserveButton.Cursor = Cursors.Hand;
                btnReserveButton.Text = "Выбрать дату";
                btnReserveButton.Size = new System.Drawing.Size(150, 30);
                btnReserveButton.Font = new Font("Century Gothic", 13);
                btnReserveButton.Location = new System.Drawing.Point(165, 125);
                btnReserveButton.Click += new EventHandler(this.btnReserveButton_Click);
                btnReserveButton.BringToFront();

                Panel1[count].Controls.Add(btnReserveButton);
            }


            Panel1[count].Controls.Add(titleLabel);
            Panel1[count].Controls.Add(variantLabel);
            Panel1[count].Controls.Add(typeLabel);
            Panel1[count].Controls.Add(ratingLabel);
            Panel1[count].Controls.Add(priceLabel);
            flowLayoutPanel1.Controls.Add(Panel1[count]);

            DynamicButtonCount++;
        }
        protected void btnAboutButton_Click(object sender, EventArgs e)
        {
            Label dynamicButton = (sender as Label);

            int x = Int32.Parse(dynamicButton.Name);

            roomid = Panel1[x - 1].Name;

            AboutRoomForm form = new AboutRoomForm(roomid);
            form.Show();
        }

        protected void btnDeleteButton_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);

            int x = Int32.Parse(dynamicButton.Name);

            roomid = Panel1[x - 1].Name;

            flowLayoutPanel1.Controls.Remove(Panel1[x - 1]);
            count--;
            countRooms--;

            DB db = new DB();

            MySqlCommand command3 = new MySqlCommand
                        ("DELETE FROM `favourite` WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
            command3.Parameters.AddWithValue("@uI", id);
            command3.Parameters.AddWithValue("@rI", roomid);


            db.openConnection();
            command3.ExecuteNonQuery();
            db.closeConnection();
        }

        protected void btnReserveButton_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);

            int x = Int32.Parse(dynamicButton.Name);

            roomid = Panel1[x - 1].Name;

            DB db = new DB();

            MySqlCommand commandDel = new MySqlCommand
                        ("SELECT * FROM `orders` WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
            commandDel.Parameters.AddWithValue("@rI", roomid);
            commandDel.Parameters.AddWithValue("@uI", id);

            db.openConnection();
            MySqlDataReader reader = commandDel.ExecuteReader();
            if (!reader.Read())
            {
                db.closeConnection();
                RoomReservation form = new RoomReservation(id, roomid);
                form.Show();
            }
            else
            {
                MessageBox.Show("Вы уже забронировали данный номер! Отмените прошлую бронь");
                return;
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

        private void QaAButton_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["QaAForm"] != null)
            {
                Form = Application.OpenForms["QaAForm"];
            }
            else
            {
                Form = new QaAForm(id);
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
