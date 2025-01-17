
namespace Cosy
{
	partial class Home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			TitleBar = new System.Windows.Forms.Panel();
			Exit = new System.Windows.Forms.Panel();
			Encrypt = new System.Windows.Forms.Label();
			Decrypt = new System.Windows.Forms.Label();
			TitleBar.SuspendLayout();
			SuspendLayout();
			// 
			// TitleBar
			// 
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
			Exit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			Exit.BackColor = System.Drawing.Color.DimGray;
			Exit.Location = new System.Drawing.Point(395, 5);
			Exit.Name = "Exit";
			Exit.Size = new System.Drawing.Size(20, 20);
			Exit.TabIndex = 1;
			Exit.Click += Exit_Click;
			Exit.MouseEnter += Exit_MouseEnter;
			Exit.MouseLeave += Exit_MouseLeave;
			// 
			// Encrypt
			// 
			Encrypt.BackColor = System.Drawing.Color.Gray;
			Encrypt.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold);
			Encrypt.ForeColor = System.Drawing.Color.DimGray;
			Encrypt.Location = new System.Drawing.Point(10, 40);
			Encrypt.Name = "Encrypt";
			Encrypt.Size = new System.Drawing.Size(400, 60);
			Encrypt.TabIndex = 1;
			Encrypt.Text = "Encrypt";
			Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			Encrypt.Click += Encrypt_Click;
			Encrypt.MouseEnter += Encrypt_MouseEnter;
			Encrypt.MouseLeave += Encrypt_MouseLeave;
			// 
			// Decrypt
			// 
			Decrypt.BackColor = System.Drawing.Color.Gray;
			Decrypt.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold);
			Decrypt.ForeColor = System.Drawing.Color.DimGray;
			Decrypt.Location = new System.Drawing.Point(10, 110);
			Decrypt.Name = "Decrypt";
			Decrypt.Size = new System.Drawing.Size(400, 60);
			Decrypt.TabIndex = 2;
			Decrypt.Text = "Decrypt";
			Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			Decrypt.Click += Decrypt_Click;
			Decrypt.MouseEnter += Decrypt_MouseEnter;
			Decrypt.MouseLeave += Decrypt_MouseLeave;
			// 
			// Home
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.DimGray;
			ClientSize = new System.Drawing.Size(420, 180);
			Controls.Add(Decrypt);
			Controls.Add(Encrypt);
			Controls.Add(TitleBar);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Name = "Home";
			Text = "Home";
			Activated += Home_Activated;
			Deactivate += Home_Deactivate;
			TitleBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Panel Exit;
		private System.Windows.Forms.Label Encrypt;
		private System.Windows.Forms.Label Decrypt;
	}
}

