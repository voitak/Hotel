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
    public partial class InfoChangeForm : Form
    {
        string table, name, id, tableType;

        public InfoChangeForm(string lu, string tableInfo, string nameInfo, string tabletype)
        {
            InitializeComponent();

            this.ActiveControl = ClosePanel;

            table = tableInfo;
            name = nameInfo;
            id = lu;
            tableType = tabletype;

            InfoLabel.Text = "Информация:";

            InfoRichTextBox.Visible = true;
            BigInfoRichTextBox.Visible = true;
            VariantComboBox.Visible = true;
            TypeComboBox.Visible = true;

            if (tableType == "change")
            {
                ChangeButton.Text = "Изменить";

                if (table == "rooms")
                {
                    //InfoRichTextBox.Visible = false;
                    BigInfoRichTextBox.Visible = false;

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                        ("SELECT `title`,`info` FROM `rooms` WHERE `title` = @uI", db.getConnection());
                    command.Parameters.AddWithValue("@uI", name);

                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        NameTextBox.Text = reader["title"].ToString();
                        InfoRichTextBox.Text = reader["info"].ToString();
                    }

                    reader.Close();
                    db.closeConnection();
                }
                else if (table == "restaraunts")
                {
                    InfoRichTextBox.Visible = true;
                    BigInfoRichTextBox.Visible = true;
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                        ("SELECT `name`,`info`,`biginfo` " +
                        "FROM `restaraunts` WHERE `name` = @uI", db.getConnection());
                    command.Parameters.AddWithValue("@uI", name);

                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        NameTextBox.Text = reader["name"].ToString();
                        InfoRichTextBox.Text = reader["info"].ToString();
                        BigInfoRichTextBox.Text = reader["biginfo"].ToString();
                    }

                    reader.Close();
                    db.closeConnection();
                }
                else if (table == "activity")
                {
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;

                    InfoLabel.Text = "Дата:";

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                        ("SELECT `name`,`info`,`date` " +
                        "FROM `activity` WHERE `name` = @uI", db.getConnection());
                    command.Parameters.AddWithValue("@uI", name);

                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        NameTextBox.Text = reader["name"].ToString();
                        InfoRichTextBox.Text = reader["date"].ToString();
                        BigInfoRichTextBox.Text = reader["info"].ToString();
                    }

                    reader.Close();
                    db.closeConnection();
                }
                else if (table == "qaa")
                {
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;
                    NameTextBox.Visible = false;
                    InfoRichTextBox.Visible = false;

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                        ("SELECT `info` FROM `qaa` WHERE id = 1", db.getConnection());

                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        BigInfoRichTextBox.Text = reader["info"].ToString();
                    }

                    reader.Close();
                    db.closeConnection();
                }
                else if (table == "contacts")
                {
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;
                    NameTextBox.Visible = false;
                    InfoRichTextBox.Visible = false;

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                        ("SELECT `info` FROM `contacts` WHERE id = 1", db.getConnection());

                    db.openConnection();

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        BigInfoRichTextBox.Text = reader["info"].ToString();
                    }

                    reader.Close();
                    db.closeConnection();
                }
            }
            else if (tableType == "add")
            {
                ChangeButton.Text = "Добавить";

                if (table == "rooms")
                {
                    InfoLabel.Text = "Цена:";
                }
                if (table == "restaraunts")
                {
                    InfoRichTextBox.Visible = true;
                    BigInfoRichTextBox.Visible = true;
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;
                }
                else if (table == "activity")
                {
                    VariantComboBox.Visible = false;
                    TypeComboBox.Visible = false;

                    InfoLabel.Text = "Дата:";
                }
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (tableType == "change")
            {
                if (table == "rooms")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя");
                        return;
                    }

                    if (VariantComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Выберите вариант размещения!");
                        return;
                    }

                    if (TypeComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Выберите тип размещения!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Введите информацию!");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("UPDATE `rooms` SET `title` = @nm, `variant` = @vr, `type` = @ty, `info` = @in " +
                            "WHERE `title` = @uN", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", VariantComboBox.Text);
                    command.Parameters.AddWithValue("@ty", TypeComboBox.Text);
                    command.Parameters.AddWithValue("@in", InfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@uN", name);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "restaraunts")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите краткую информацию!");
                        return;
                    }

                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание!");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("UPDATE `restaraunts` SET `name` = @nm, `info` = @vr, `biginfo` = @ty " +
                            "WHERE `name` = @uN", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", InfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@ty", BigInfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@uN", name);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "activity")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Введите дату!");
                        return;
                    }

                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("UPDATE `activity` SET `name` = @nm, `info` = @vr, `date` = @ty " +
                            "WHERE `name` = @uN", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", BigInfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@ty", InfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@uN", name);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "qaa")
                {
                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("UPDATE `qaa` SET `info` = @vr WHERE id = 1", db.getConnection());
                    command.Parameters.AddWithValue("@vr", BigInfoRichTextBox.Text);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "contacts")
                {
                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("UPDATE `contacts` SET `info` = @vr WHERE id = 1", db.getConnection());
                    command.Parameters.AddWithValue("@vr", BigInfoRichTextBox.Text);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
            }
            else if (tableType == "add")
            {
                if (table == "rooms")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя");
                        return;
                    }

                    if (VariantComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Выберите вариант размещения!");
                        return;
                    }

                    if (TypeComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Выберите тип размещения!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Введите информацию!");
                        return;
                    }


                    MemoryStream ms = new MemoryStream();
                    pictureHided.Image.Save(ms, pictureHided.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("INSERT INTO `rooms` (`title`, `variant`,`rating`, `type`, `price`,`info`,`image`) " +
                            "VALUES (@nm, @vr, @r, @ty, @pr, @in, @img)", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", VariantComboBox.Text);
                    command.Parameters.AddWithValue("@r", "Нет");
                    command.Parameters.AddWithValue("@ty", TypeComboBox.Text);
                    command.Parameters.AddWithValue("@pr", InfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@in", BigInfoRichTextBox.Text);
                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "restaraunts")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите краткую информацию!");
                        return;
                    }

                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание!");
                        return;
                    }

                    MemoryStream ms = new MemoryStream();
                    pictureHided.Image.Save(ms, pictureHided.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("INSERT INTO `restaraunts` (`name`, `info`, `biginfo`, `image`)" +
                            " VALUES (@nm, @vr, @ty, @img)", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", InfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@ty", BigInfoRichTextBox.Text);
                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
                else if (table == "activity")
                {
                    if (NameTextBox.Text == "")
                    {
                        MessageBox.Show("Введите имя!");
                        return;
                    }

                    if (InfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Введите дату!");
                        return;
                    }

                    if (BigInfoRichTextBox.Text == "")
                    {
                        MessageBox.Show("Напишите описание");
                        return;
                    }

                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand
                            ("INSERT INTO `activity` (`name`, `info`, `date`) " +
                            "VALUES (@nm, @vr, @ty)", db.getConnection());
                    command.Parameters.AddWithValue("@nm", NameTextBox.Text);
                    command.Parameters.AddWithValue("@vr", BigInfoRichTextBox.Text);
                    command.Parameters.AddWithValue("@ty", InfoRichTextBox.Text);

                    db.openConnection();
                    command.ExecuteNonQuery();
                    db.closeConnection();
                }
            }

            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["AdminForm"] != null)
            {
                Form = new AdminForm(id);
                this.Dispose();

                Form.Top = Application.OpenForms["AdminForm"].Top;
                Form.Left = Application.OpenForms["AdminForm"].Left;

                Form.Show();
                Application.OpenForms["AdminForm"].Dispose();
            }
            else
            {
                Form = new AdminForm(id);
                this.Dispose();

                Form.Top = Application.OpenForms["AdminForm"].Top;
                Form.Left = Application.OpenForms["AdminForm"].Left;

                Form.Show();
                Application.OpenForms["AdminForm"].Dispose();
            }
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Form Form = Application.OpenForms[0];
            if (Application.OpenForms["AdminForm"] != null)
            {
                this.Dispose();
            }
            else
            {
                Form = new AdminForm(id);
                this.Dispose();

                Form.StartPosition = FormStartPosition.CenterScreen;

                Form.Show();
            }
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
