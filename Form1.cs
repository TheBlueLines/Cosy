using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Cosy
{
    public partial class Form1 : Form
    {
        private bool mouseIsDown;
        private Point firstPoint;
        public List<string> lines = new();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        private static extern bool ZeroMemory(IntPtr Destination, int Length);
        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
            Encrypt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Encrypt.Width, Encrypt.Height, 5, 5));
            Decrypt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Decrypt.Width, Decrypt.Height, 5, 5));
            Password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Password.Width, Password.Height, 5, 5));
            if (File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
            {
                EnableEncryptDecrypt();   
            }
        }
        private void EnableEncryptDecrypt()
        {
            Encrypt.BackColor = Color.DarkGray;
            Decrypt.BackColor = Color.DarkGray;
            Encrypt.Enabled = true;
            Decrypt.Enabled = true;
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Red;
        }
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.DimGray;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void Encrypt_MouseEnter(object sender, EventArgs e)
        {
            Encrypt.BackColor = Color.Silver;
        }
        private void Decrypt_MouseEnter(object sender, EventArgs e)
        {
            Decrypt.BackColor = Color.Silver;
        }
        private void AutoLogin_MouseEnter(object sender, EventArgs e)
        {
            Password.BackColor = Color.Silver;
        }
        private void Encrypt_MouseLeave(object sender, EventArgs e)
        {
            Encrypt.BackColor = Color.DarkGray;
        }
        private void Decrypt_MouseLeave(object sender, EventArgs e)
        {
            Decrypt.BackColor = Color.DarkGray;
        }
        private void AutoLogin_MouseLeave(object sender, EventArgs e)
        {
            Password.BackColor = Color.DarkGray;
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
            {
                OpenFileDialog open = new();
                open.Title = "Encrypt File";
                open.DefaultExt = ".*";
                open.Filter = "All files (*.*)|*.*";
                open.Multiselect = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Form from = new Security(open.FileNames, true);
                    from.ShowDialog();
                }
            }
        }
        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
            {
                OpenFileDialog open = new();
                open.Title = "Decrypt File";
                open.DefaultExt = "cosy";
                open.Filter = "cosy files (*.cosy)|*.cosy";
                open.Multiselect = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Form from = new Security(open.FileNames, false);
                    from.ShowDialog();
                }
            }
        }
        private void Password_Click(object sender, EventArgs e)
        {
            AutoLogin autoLogin = new AutoLogin();
            autoLogin.ShowDialog();
            if (autoLogin.newPassword)
            {
                EnableEncryptDecrypt();
            }
        }
    }
}