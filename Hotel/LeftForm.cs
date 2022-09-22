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
    public partial class LeftForm : Form
    {
        public LeftForm()
        {
            InitializeComponent();

            YesButton.BackColor = Color.FromArgb(171, 144, 84);
            YesButton.ForeColor = Color.White;
            NoButton.BackColor = Color.FromArgb(171, 144, 84);
            NoButton.ForeColor = Color.White;

            this.ActiveControl = ClosePanel;

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
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

        private void YesButton_MouseEnter(object sender, EventArgs e)
        {
            YesButton.BackColor = Color.White;
            YesButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.BackColor = Color.FromArgb(171, 144, 84);
            YesButton.ForeColor = Color.White;
        }

        private void NoButton_MouseEnter(object sender, EventArgs e)
        {
            NoButton.BackColor = Color.White;
            NoButton.ForeColor = Color.FromArgb(171, 144, 84);
        }

        private void NoButton_MouseLeave(object sender, EventArgs e)
        {
            NoButton.BackColor = Color.FromArgb(171, 144, 84);
            NoButton.ForeColor = Color.White;
        }
    }
}
