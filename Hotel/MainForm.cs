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
    public partial class MainForm : Form
    {
        string id;
        string roomid;
        private Panel[] Panel1; 
        private int count = -1;
        int DynamicButtonCount = 1;
        int countRooms = 0;

        public MainForm(string lu)
        {
            InitializeComponent();

            MyButton.BackColor = Color.White; 
            MyButton.ForeColor = Color.FromArgb(171, 144, 84);
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
            ManagmentButton.BackColor = Color.FromArgb(171, 144, 84);
            ManagmentButton.ForeColor = Color.White;

            ManagmentButton.Visible = false;

            this.ActiveControl = ClosePanel;

            id = lu;

            if (id == "admin")
            {
                ManagmentButton.Visible = true;
            }

            if(id == "guest")
            {
                LeftButton.Text = "Войти";
            }

            Panel1 = new Panel[100];

            DB db = new DB();
            MySqlCommand command = new MySqlCommand
                ("SELECT rooms.id, rooms.title, rooms.price, rooms.variant, rooms.type, rooms.rating, orders.beginDate, orders.endDate " +
                "FROM rooms INNER JOIN orders ON rooms.id = orders.roomsId WHERE `usersId` = @uI", db.getConnection());
            command.Parameters.AddWithValue("@uI", id);
           
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                countRooms++;
                write_panel(reader);
            }

            if(countRooms == 0)
            {
                Label titleLabel = new Label();

                titleLabel.ForeColor = Color.Black;
                titleLabel.Font = new Font("Century Gothic", 16);
                titleLabel.Size = new System.Drawing.Size(700, 300);
                titleLabel.Location = new System.Drawing.Point(0, 0);

                if (id == "guest")
                {
                    titleLabel.Text = "Вы не можете бронировать номер в режиме гостя";
                }
                else
                {
                    titleLabel.Text = "Вы еще не забронировали номер";
                }


                flowLayoutPanel1.Controls.Add(titleLabel);
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
            ratingLabel.Name = reader["id"].ToString();
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

            Label dateLabel = new Label();
            dateLabel.Name = reader["beginDate"].ToString();
            dateLabel.Text = "c " + reader["beginDate"].ToString() + " до " + reader["endDate"].ToString();
            dateLabel.ForeColor = Color.FromArgb(171, 144, 84);
            dateLabel.Font = new Font("Century Gothic", 9);
            dateLabel.Size = new System.Drawing.Size(200, 30);
            dateLabel.Location = new System.Drawing.Point(0, 140);
            dateLabel.BringToFront();

            string name = "" + DynamicButtonCount;
            Button btnDeleteButton = new Button();
            btnDeleteButton.Name = name;
            btnDeleteButton.Cursor = Cursors.Hand;
            btnDeleteButton.Text = "Убрать бронь";
            btnDeleteButton.Size = new System.Drawing.Size(150, 30);
            btnDeleteButton.Font = new Font("Century Gothic", 13);
            btnDeleteButton.Location = new System.Drawing.Point(165, 125);
            btnDeleteButton.Click += new EventHandler(this.btnDeleteButton_Click);
            Panel1[count].Controls.Add(btnDeleteButton);
            btnDeleteButton.BringToFront();

            Panel1[count].Controls.Add(btnDeleteButton);
            Panel1[count].Controls.Add(titleLabel);
            Panel1[count].Controls.Add(variantLabel);
            Panel1[count].Controls.Add(typeLabel);
            Panel1[count].Controls.Add(ratingLabel);
            Panel1[count].Controls.Add(priceLabel);
            Panel1[count].Controls.Add(dateLabel);
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
                        ("DELETE FROM `orders` WHERE `usersId` = @uI AND `roomsId` = @rI", db.getConnection());
            command3.Parameters.AddWithValue("@uI", id);
            command3.Parameters.AddWithValue("@rI", roomid);

            if (countRooms == 0)
            {
                Label titleLabel = new Label();
                titleLabel.Text = "Вы еще не забронировали номер";
                titleLabel.ForeColor = Color.Black;
                titleLabel.Font = new Font("Century Gothic", 16);
                titleLabel.Size = new System.Drawing.Size(700, 300);
                titleLabel.Location = new System.Drawing.Point(0, 0);
                flowLayoutPanel1.Controls.Add(titleLabel);
            }


            db.openConnection();
            command3.ExecuteNonQuery();
            db.closeConnection();
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


    }
}
