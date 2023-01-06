using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cosy
{
    public partial class AutoLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private bool mouseIsDown;
        private Point firstPoint;
        public bool newPassword = false;
        public AutoLogin()
        {
            InitializeComponent();
            ActiveControl = Save;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
            Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Save.Width, Save.Height, 5, 5));
            password1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, password1.Width, password1.Height, 5, 5));
            password2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, password2.Width, password2.Height, 5, 5));
            password3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, password3.Width, password3.Height, 5, 5));
            KeyPreview = true;
            if (!File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
            {
                password1.BackColor = Color.Gray;
                password1.ForeColor = Color.DimGray;
                password1.Enabled = false;
            }
        }
        private void AutoLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SavePassword();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Red;
        }
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.DimGray;
        }
        private void Save_MouseEnter(object sender, EventArgs e)
        {
            Save.BackColor = Color.Silver;
        }
        private void Save_MouseLeave(object sender, EventArgs e)
        {
            Save.BackColor = Color.DarkGray;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SavePassword();
        }
        void SavePassword()
        {
            if (password2.Text != password3.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            if (string.IsNullOrEmpty(password2.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }
            if (!File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
            {
                File.WriteAllBytes("C:\\TTMC\\Cosy\\cosy.pswd", Engine.Encrypt(Convert.FromBase64String("Q09TWQ=="), password2.Text));
                newPassword = true;
                Close();
                return;
            }
            if (string.IsNullOrEmpty(password1.Text))
            {
                MessageBox.Show("Old Password Missing!");
                return;
            }
            byte[] secret = Engine.Decrypt(File.ReadAllBytes("C:\\TTMC\\Cosy\\cosy.pswd"), password1.Text);
            if (Convert.ToBase64String(secret) == "Q09TWQ==")
            {
                File.WriteAllBytes("C:\\TTMC\\Cosy\\cosy.pswd", Engine.Encrypt(secret, password2.Text));
                if (File.Exists("C:\\TTMC\\Cosy\\list.pswd"))
                {
                    foreach (string item in File.ReadLines("C:\\TTMC\\Cosy\\list.pswd"))
                    {
                        File.WriteAllBytes(item + ".cosy", Engine.Encrypt(Engine.Decrypt(File.ReadAllBytes(item + ".cosy"), password1.Text), password2.Text));
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;
                int x = Location.X - xDiff;
                int y = Location.Y - yDiff;
                Location = new Point(x, y);
            }
        }
        private void password1_Enter(object sender, EventArgs e)
        {
            if (password1.ForeColor == Color.Gray)
            {
                password1.Text = string.Empty;
                password1.ForeColor = Color.DimGray;
                password1.PasswordChar = '×';
            }
        }
        private void password1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password1.Text))
            {
                password1.Text = "Old password";
                password1.ForeColor = Color.Gray;
                password1.PasswordChar = '\u0000';
            }
        }
        private void password2_Enter(object sender, EventArgs e)
        {
            if (password2.ForeColor == Color.Gray)
            {
                password2.Text = string.Empty;
                password2.ForeColor = Color.DimGray;
                password2.PasswordChar = '×';
            }
        }
        private void password2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password2.Text))
            {
                password2.Text = "New password";
                password2.ForeColor = Color.Gray;
                password2.PasswordChar = '\u0000';
            }
        }
        private void password3_Enter(object sender, EventArgs e)
        {
            if (password3.ForeColor == Color.Gray)
            {
                password3.Text = string.Empty;
                password3.ForeColor = Color.DimGray;
                password3.PasswordChar = '×';
            }
        }
        private void password3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password3.Text))
            {
                password3.Text = "New password again";
                password3.ForeColor = Color.Gray;
                password3.PasswordChar = '\u0000';
            }
        }
    }
}