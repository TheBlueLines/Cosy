using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Cosy
{
	public partial class Home : Form
	{
		private Color backColor;
		private bool mouseIsDown;
		private Point firstPoint;
		public List<string> lines = new();
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
		[DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
		private static extern bool ZeroMemory(IntPtr Destination, int Length);
		public Home()
		{
			InitializeComponent();
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
			Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
			Encrypt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Encrypt.Width, Encrypt.Height, 5, 5));
			Decrypt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Decrypt.Width, Decrypt.Height, 5, 5));
		}
		private void RePaint(bool Activated)
		{
			if (Activated)
			{
				backColor = Color.DimGray;
				BackColor = Color.Gray;
				Encrypt.BackColor = Encrypt.Enabled ? Color.DarkGray : Color.DimGray;
				Decrypt.BackColor = Decrypt.Enabled ? Color.DarkGray : Color.DimGray;
			}
			else
			{
				backColor = Color.FromArgb(255, 80, 80, 80);
				BackColor = Color.FromArgb(255, 90, 90, 90);
				Encrypt.BackColor = backColor;
				Decrypt.BackColor = backColor;
			}
			Exit.BackColor = backColor;
		}
		private void Exit_MouseEnter(object sender, EventArgs e)
		{
			Exit.BackColor = Color.Red;
		}
		private void Exit_MouseLeave(object sender, EventArgs e)
		{
			Exit.BackColor = backColor;
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
			Encrypt.BackColor = backColor == Color.DimGray ? Color.Silver : Color.Gray;
		}
		private void Decrypt_MouseEnter(object sender, EventArgs e)
		{
			Decrypt.BackColor = backColor == Color.DimGray ? Color.Silver : Color.Gray;
		}
		private void Encrypt_MouseLeave(object sender, EventArgs e)
		{
			Encrypt.BackColor = backColor == Color.DimGray ? Color.DarkGray : backColor;
		}
		private void Decrypt_MouseLeave(object sender, EventArgs e)
		{
			Decrypt.BackColor = backColor == Color.DimGray ? Color.DarkGray : backColor;
		}
		private void Encrypt_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new()
			{
				Title = "Encrypt File",
				DefaultExt = ".*",
				Filter = "All files (*.*)|*.*",
				Multiselect = true
			};
			if (open.ShowDialog() == DialogResult.OK)
			{
				Form from = new Security(open.FileNames, true);
				from.ShowDialog();
			}
		}
		private void Decrypt_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new()
			{
				Title = "Decrypt File",
				DefaultExt = "cosy",
				Filter = "Cosy files (*.cosy)|*.cosy",
				Multiselect = true
			};
			if (open.ShowDialog() == DialogResult.OK)
			{
				Form from = new Security(open.FileNames, false);
				from.ShowDialog();
			}
		}
		private void Home_Activated(object sender, EventArgs e)
		{
			RePaint(true);
		}
		private void Home_Deactivate(object sender, EventArgs e)
		{
			RePaint(false);
		}
	}
}