using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.ActiveControl = RegTextLabel;

            RegTextLabel.ForeColor = Color.FromArgb(171, 144, 84);

            RegNameTextBox.Text = "Имя";
            RegLastnameTextBox.Text = "Фамилия";
            RegLoginTextBox.Text = "Логин";
            RegMailTextBox.Text = "Почта";
            RegPhoneTextBox.Text = "Телефон";
            RegPasswordTextBox.Text = "Пароль";

            RegNameTextBox.ForeColor = Color.Gray;
            RegLastnameTextBox.ForeColor = Color.Gray;
            RegLoginTextBox.ForeColor = Color.Gray;
            RegMailTextBox.ForeColor = Color.Gray;
            RegPhoneTextBox.ForeColor = Color.Gray;
            RegPasswordTextBox.ForeColor = Color.Gray;

            RegPasswordTextBox.UseSystemPasswordChar = false;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            CloseLabel.BackColor = Color.Silver;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.White;
        }

        private void RegNameTextBox_Enter(object sender, EventArgs e)
        {
            if (RegNameTextBox.Text == "Имя")
            { 
                RegNameTextBox.Text = "";
                RegNameTextBox.ForeColor = Color.Black;
            }
        }

        private void RegNameTextBox_Leave(object sender, EventArgs e)
        {
            if (RegNameTextBox.Text == "")
            {
                RegNameTextBox.Text = "Имя";
                RegNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegLastnameTextBox_Enter(object sender, EventArgs e)
        {
            if (RegLastnameTextBox.Text == "Фамилия")
            {
                RegLastnameTextBox.Text = "";
                RegLastnameTextBox.ForeColor = Color.Black;
            }
        }

        private void RegLastnameTextBox_Leave(object sender, EventArgs e)
        {
            if (RegLastnameTextBox.Text == "")
            {
                RegLastnameTextBox.Text = "Фамилия";
                RegLastnameTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegLoginTextBox_Enter(object sender, EventArgs e)
        {
            if (RegLoginTextBox.Text == "Логин")
            {
                RegLoginTextBox.Text = "";
                RegLoginTextBox.ForeColor = Color.Black;
            }
        }

        private void RegLoginTextBox_Leave(object sender, EventArgs e)
        {
            if (RegLoginTextBox.Text == "")
            {
                RegLoginTextBox.Text = "Логин";
                RegLoginTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegMailTextBox_Enter(object sender, EventArgs e)
        {
            if (RegMailTextBox.Text == "Почта")
            {
                RegMailTextBox.Text = "";
                RegMailTextBox.ForeColor = Color.Black;
            }
        }

        private void RegMailTextBox_Leave(object sender, EventArgs e)
        {
            if (RegMailTextBox.Text == "")
            {
                RegMailTextBox.Text = "Почта";
                RegMailTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegPhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (RegPhoneTextBox.Text == "Телефон")
            {
                RegPhoneTextBox.Text = "";
                RegPhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void RegPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (RegPhoneTextBox.Text == "")
            {
                RegPhoneTextBox.Text = "Телефон";
                RegPhoneTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (RegPasswordTextBox.Text == "Пароль")
            {
                RegPasswordTextBox.Text = "";
                RegPasswordTextBox.ForeColor = Color.Black;
                RegPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RegPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (RegPasswordTextBox.Text == "")
            {
                RegPasswordTextBox.Text = "Пароль";
                RegPasswordTextBox.ForeColor = Color.Gray;
                RegPasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void EyePictureBox_Click(object sender, EventArgs e)
        {
            if ((RegPasswordTextBox.UseSystemPasswordChar == false) && (RegPasswordTextBox.Text != "Пароль"))
            {
                RegPasswordTextBox.UseSystemPasswordChar = true;
            }
            else if ((RegPasswordTextBox.UseSystemPasswordChar == true) && (RegPasswordTextBox.Text != "Пароль"))
            {
                RegPasswordTextBox.UseSystemPasswordChar = false;
            }

        }

        private void RegPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        //Регистрация пользователя
        private void RegButton_Click(object sender, EventArgs e)
        {

            #region Проверка на корректность введеных данных

            if (RegNameTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegNameTextBox, "Введите имя!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (RegLastnameTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegLastnameTextBox, "Введите фамилию!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (RegLoginTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegLoginTextBox, "Введите логин!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (RegMailTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegMailTextBox, "Введите почту!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (RegPhoneTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegPhoneTextBox, "Введите телефон!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            if (RegPasswordTextBox.ForeColor == Color.Gray)
            {
                ErrorProvider.SetError(RegPasswordTextBox, "Введите пароль!");
                return;
            }
            else
            {
                ErrorProvider.Clear();
            }

            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(RegMailTextBox.Text, pattern))
            {
                ErrorProvider.Clear();
            }    
            else
            {
                ErrorProvider.SetError(RegMailTextBox, "Введите корректную почту!");
                return;
            }

            #endregion

            if (isUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `lastname`, `mail`, `phone`, `type`) VALUES (@login, @password, @name, @lastname, @mail, @phone, @ty)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RegLoginTextBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = RegPasswordTextBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = RegNameTextBox.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = RegLastnameTextBox.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = RegMailTextBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.UInt64).Value = RegPhoneTextBox.Text;
            command.Parameters.AddWithValue("@ty", "0");

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                MessageBox.Show("Аккаунт был создан");
                Form Form = Application.OpenForms[0];
                if (Application.OpenForms["LoginForm"] != null)
                {
                    Form = Application.OpenForms["LoginForm"];
                }
                else
                {
                    Form = new LoginForm();
                }
                Form.Left = this.Left;
                Form.Top = this.Top;
                Form.Show();
                this.Hide();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Аккаунт не удалось создать");
            }

        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = RegLoginTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                ErrorProvider.SetError(RegLoginTextBox, "Такой логин уже существует! Придумайте новый");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegToLogLabel_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["LoginForm"] != null)
            {
                Form = Application.OpenForms["LoginForm"];
            }
            else
            {
                Form = new LoginForm();
            }
            Form.Left = this.Left;
            Form.Top = this.Top;
            Form.Show();
            this.Hide();
        }

        private void RegToLogLabel_MouseEnter(object sender, EventArgs e)
        {
            RegToLogLabel.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void RegToLogLabel_MouseLeave(object sender, EventArgs e)
        {
            RegToLogLabel.ForeColor = Color.Black;
        }

        private void RegButton_MouseEnter(object sender, EventArgs e)
        {
            RegButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void RegButton_MouseLeave(object sender, EventArgs e)
        {
            RegButton.ForeColor = Color.Black;
        }
    }
}
