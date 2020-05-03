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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

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
            this.Close();
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

        private void RegButton_Click(object sender, EventArgs e)
        {
            if ((RegLoginTextBox.Text == "" || RegLoginTextBox.Text == "Логин")
                || (RegPasswordTextBox.Text == "" || RegPasswordTextBox.Text == "Пароль")
                || (RegNameTextBox.Text == "" || RegNameTextBox.Text == "Имя")
                || (RegLastnameTextBox.Text == "" || RegLastnameTextBox.Text == "Фамилия")
                || (RegMailTextBox.Text == "" || RegMailTextBox.Text == "Почта")
                || (RegPhoneTextBox.Text == "" || RegPhoneTextBox.Text == "Телефон"))
            {
                MessageBox.Show("Введите данные");
                return;
            }
            
            if(isUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `lastname`, `mail`, `phone`) VALUES (@login, @password, @name, @lastname, @mail, @phone)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RegLoginTextBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = RegPasswordTextBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = RegNameTextBox.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = RegLastnameTextBox.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = RegMailTextBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.UInt64).Value = RegPhoneTextBox.Text;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Не создан");
            }

            db.closeConnection();
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
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
