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
    public partial class ActivityForm : Form
    {
        string id;
        string roomid;
        private Panel[] Panel1;    // Array of textboxes
        private int count = -1;
        //Counter for Dynamic Buttons.
        int DynamicButtonCount = 1;
        public ActivityForm(string lu)
        {
            InitializeComponent();

            MyButton.BackColor = Color.FromArgb(171, 144, 84);
            MyButton.ForeColor = Color.White;
            RoomButton.BackColor = Color.FromArgb(171, 144, 84);
            RoomButton.ForeColor = Color.White;
            FavouriteListButton.BackColor = Color.FromArgb(171, 144, 84);
            FavouriteListButton.ForeColor = Color.White;
            ActivityButton.BackColor = Color.White;
            ActivityButton.ForeColor = Color.FromArgb(171, 144, 84);
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

            ActivityLabel.ForeColor = Color.FromArgb(171, 144, 84);

            Panel1 = new Panel[100];

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `activity`", db.getConnection());

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
            Panel1[count].Size = new System.Drawing.Size(630, 260);
            Panel1[count].Name = reader["id"].ToString();


            Label nameLabel = new Label();
            nameLabel.Text = reader["name"].ToString();
            nameLabel.ForeColor = Color.Black;
            nameLabel.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            nameLabel.Size = new System.Drawing.Size(630, 30);
            nameLabel.Location = new System.Drawing.Point(0, 0);

            Label infoLabel = new Label();
            infoLabel.Text = reader["info"].ToString();
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font("Century Gothic", 16);
            infoLabel.Size = new System.Drawing.Size(630, 220);
            infoLabel.Location = new System.Drawing.Point(0, 35);

            Label dateLabel = new Label();
            dateLabel.Text = reader["date"].ToString();
            dateLabel.ForeColor = Color.FromArgb(171, 144, 84);
            dateLabel.Font = new Font("Century Gothic", 12);
            dateLabel.Size = new System.Drawing.Size(400, 100);
            dateLabel.Location = new System.Drawing.Point(0, 230);

            if (id == "admin")
            {
                string name = "" + DynamicButtonCount;
                Button btnDynamicButton = new Button();
                btnDynamicButton.Name = name;
                btnDynamicButton.Cursor = Cursors.Hand;
                btnDynamicButton.Text = "Удалить";
                btnDynamicButton.Size = new System.Drawing.Size(150, 30);
                btnDynamicButton.Font = new Font("Century Gothic", 13);
                btnDynamicButton.Location = new System.Drawing.Point(480, 230);
                btnDynamicButton.Click += new EventHandler(this.btnDeleteButton_Click);
                btnDynamicButton.BringToFront();

                Panel1[count].Controls.Add(btnDynamicButton);
            }

            Panel1[count].Controls.Add(dateLabel);
            Panel1[count].Controls.Add(nameLabel);
            Panel1[count].Controls.Add(infoLabel);
            flowLayoutPanel1.Controls.Add(Panel1[count]);

            DynamicButtonCount++;
        }

        protected void btnDeleteButton_Click(object sender, EventArgs e)
        {
            Button dynamicButton = (sender as Button);

            int x = Int32.Parse(dynamicButton.Name);

            roomid = Panel1[x - 1].Name;

            flowLayoutPanel1.Controls.Remove(Panel1[x - 1]);
            count--;

            DB db = new DB();

            MySqlCommand command3 = new MySqlCommand
                        ("DELETE FROM `activity` WHERE `id` = @rI", db.getConnection());
            command3.Parameters.AddWithValue("@rI", roomid);


            db.openConnection();
            command3.ExecuteNonQuery();
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
