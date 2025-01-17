
namespace Cosy
{
	partial class Security
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Security));
			TitleBar = new System.Windows.Forms.Panel();
			Exit = new System.Windows.Forms.Panel();
			Head = new System.Windows.Forms.Label();
			password = new System.Windows.Forms.TextBox();
			Login = new System.Windows.Forms.Label();
			TitleBar.SuspendLayout();
			SuspendLayout();
			// 
			// TitleBar
			// 
			TitleBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			TitleBar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
			TitleBar.Controls.Add(Exit);
			TitleBar.Location = new System.Drawing.Point(0, 0);
			TitleBar.Name = "TitleBar";
			TitleBar.Size = new System.Drawing.Size(420, 30);
			TitleBar.TabIndex = 0;
			TitleBar.MouseDown += TitleBar_MouseDown;
			TitleBar.MouseMove += TitleBar_MouseMove;
			TitleBar.MouseUp += TitleBar_MouseUp;
			// 
			// Exit
			// 
			Exit.BackColor = System.Drawing.Color.DimGray;
			Exit.Location = new System.Drawing.Point(395, 5);
			Exit.Name = "Exit";
			Exit.Size = new System.Drawing.Size(20, 20);
			Exit.TabIndex = 5;
			Exit.Click += Exit_Click;
			Exit.MouseEnter += Exit_MouseEnter;
			Exit.MouseLeave += Exit_MouseLeave;
			// 
			// Head
			// 
			Head.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Head.BackColor = System.Drawing.Color.Transparent;
			Head.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold);
			Head.ForeColor = System.Drawing.Color.DarkGray;
			Head.Location = new System.Drawing.Point(10, 40);
			Head.Name = "Head";
			Head.Size = new System.Drawing.Size(400, 50);
			Head.TabIndex = 2;
			Head.Text = "Password:";
			Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// password
			// 
			password.BackColor = System.Drawing.Color.DarkGray;
			password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
			password.ForeColor = System.Drawing.Color.Gray;
			password.Location = new System.Drawing.Point(10, 100);
			password.Name = "password";
			password.PasswordChar = '×';
			password.Size = new System.Drawing.Size(400, 31);
			password.TabIndex = 3;
			password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			password.KeyDown += Security_KeyDown;
			// 
			// Login
			// 
			Login.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Login.BackColor = System.Drawing.Color.DarkGray;
			Login.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold);
			Login.ForeColor = System.Drawing.Color.DimGray;
			Login.Location = new System.Drawing.Point(10, 140);
			Login.Name = "Login";
			Login.Size = new System.Drawing.Size(400, 50);
			Login.TabIndex = 4;
			Login.Text = "LOGIN";
			Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			Login.Click += Save_Click;
			Login.MouseEnter += Save_MouseEnter;
			Login.MouseLeave += Save_MouseLeave;
			// 
			// Security
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.DimGray;
			ClientSize = new System.Drawing.Size(420, 200);
			Controls.Add(Login);
			Controls.Add(password);
			Controls.Add(Head);
			Controls.Add(TitleBar);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Name = "Security";
			Text = "Security";
			TitleBar.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Label Head;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label Login;
		private System.Windows.Forms.Panel Exit;
	}
}