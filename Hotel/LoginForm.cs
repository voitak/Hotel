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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.ActiveControl = LoginTextLabel;

            LoginTextLabel.ForeColor = Color.FromArgb(171, 144, 84);

            LoginTextBox.Text = "Логин";
            PasswordTextBox.Text = "Пароль";

            LoginTextBox.ForeColor = Color.Gray;
            PasswordTextBox.ForeColor = Color.Gray;

            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void ClosePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
            CloseLabel.BackColor = Color.Silver;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(LoginTextBox, "Введите логин!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (PasswordTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(PasswordTextBox, "Введите пароль!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }         
                
            String loginUser = LoginTextBox.Text;
            String passwordUser = PasswordTextBox.Text;

            //Ищем нужного пользователя в базе данных
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT `id`,`type` FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                MainForm mainForm;
                if (reader["type"].ToString() == "1")
                {
                    mainForm = new MainForm("admin");
                }
                else 
                {
                    mainForm = new MainForm(reader["id"].ToString());
                }
                reader.Dispose();
                db.closeConnection();
                mainForm.StartPosition = FormStartPosition.CenterScreen;
                mainForm.Show();
                this.Hide();
            }
            else
            {
                reader.Dispose();
                db.closeConnection();
                MessageBox.Show("Такого аккаунта не существует!");
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Логин")
            {
                LoginTextBox.Text = "";
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Логин";
                LoginTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Пароль";
                PasswordTextBox.ForeColor = Color.Gray;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void EyePictureBox_Click(object sender, EventArgs e)
        {
            if ((PasswordTextBox.UseSystemPasswordChar == false) && (PasswordTextBox.Text != "Пароль"))
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            } 
            else if ((PasswordTextBox.UseSystemPasswordChar == true) && (PasswordTextBox.Text != "Пароль"))
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }

        }

        private void LogToRegLabel_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["RegisterForm"] != null)
            {
                Form = Application.OpenForms["RegisterForm"];
            }
            else
            {
                Form = new RegisterForm();
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
        }

        private void LogToRegLabel_MouseEnter(object sender, EventArgs e)
        {
            LogToRegLabel.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void LogToRegLabel_MouseLeave(object sender, EventArgs e)
        {
            LogToRegLabel.ForeColor = Color.Black;
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.Black;
        }

        private void GuestLabel_MouseEnter(object sender, EventArgs e)
        {
            GuestLabel.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void GuestLabel_MouseLeave(object sender, EventArgs e)
        {
            GuestLabel.ForeColor = Color.Black;
        }

        private void GuestLabel_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm mainForm = new MainForm("guest");
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
            this.Hide();
        }
    }
}
