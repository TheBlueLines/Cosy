using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Cosy
{
	public partial class Security : Form
	{
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private bool mouseIsDown;
		private Point firstPoint;
		public string[] files;
		public Security(string[] fileNames, bool mode)
		{
			files = fileNames;
			InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
            password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, password.Width, password.Height, 5, 5));
            Login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Login.Width, Login.Height, 5, 5));
            KeyPreview = true;
            Login.Text = mode ? "ENCRYPT" : "DECRYPT";
        }
		void Security_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Save_Click(sender, e);
			}
		}
		private void Save_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(password.Text))
			{
				MessageBox.Show("Password Missing!");
			}
			else if (File.Exists("C:\\TTMC\\Cosy\\cosy.pswd"))
			{
				byte[] secret = Engine.Decrypt(File.ReadAllBytes("C:\\TTMC\\Cosy\\cosy.pswd"), password.Text);
				if (Convert.ToBase64String(secret) == "Q09TWQ==")
				{
					if (Login.Text == "ENCRYPT")
					{
						List<string> list = new();
						if (File.Exists("C:\\TTMC\\Cosy\\list.pswd"))
						{
							list.AddRange(File.ReadLines("C:\\TTMC\\Cosy\\list.pswd"));
						}
						foreach (string file in files)
						{
							File.WriteAllBytes(file + ".cosy", Engine.Encrypt(File.ReadAllBytes(file), password.Text));
							File.Delete(file);
							if (!list.Contains(file))
							{
								list.Add(file);
							}
						}
						File.WriteAllLines("C:\\TTMC\\Cosy\\list.pswd", list);
					}
					else if (Login.Text == "DECRYPT")
					{
						List<string> list = new();
						if (File.Exists("C:\\TTMC\\Cosy\\list.pswd"))
						{
                            list.AddRange(File.ReadLines("C:\\TTMC\\Cosy\\list.pswd"));
                        }
						foreach (string file in files)
						{
							File.WriteAllBytes(file[0..^5], Engine.Decrypt(File.ReadAllBytes(file), password.Text));
							File.Delete(file);
							if (list.Contains(file[0..^5]))
							{
								list.Remove(file[0..^5]);
							}
						}
						File.WriteAllLines("C:\\TTMC\\Cosy\\list.pswd", list);
					}
					Close();
				}
				else
				{
					MessageBox.Show("Wrong Password!");
				}
			}
		}
		private void Save_MouseEnter(object sender, EventArgs e)
		{
			Login.BackColor = Color.Silver;
		}
		private void Save_MouseLeave(object sender, EventArgs e)
		{
			Login.BackColor = Color.DarkGray;
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
			Close();
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
	}
}