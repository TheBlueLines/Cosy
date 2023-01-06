
namespace Cosy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.Encrypt = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar.Controls.Add(this.Exit);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(420, 30);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(395, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Gray;
            this.Encrypt.Enabled = false;
            this.Encrypt.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Encrypt.ForeColor = System.Drawing.Color.DimGray;
            this.Encrypt.Location = new System.Drawing.Point(10, 40);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(400, 60);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            this.Encrypt.MouseEnter += new System.EventHandler(this.Encrypt_MouseEnter);
            this.Encrypt.MouseLeave += new System.EventHandler(this.Encrypt_MouseLeave);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Gray;
            this.Decrypt.Enabled = false;
            this.Decrypt.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decrypt.ForeColor = System.Drawing.Color.DimGray;
            this.Decrypt.Location = new System.Drawing.Point(10, 110);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(400, 60);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            this.Decrypt.MouseEnter += new System.EventHandler(this.Decrypt_MouseEnter);
            this.Decrypt.MouseLeave += new System.EventHandler(this.Decrypt_MouseLeave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.DarkGray;
            this.Password.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.Color.DimGray;
            this.Password.Location = new System.Drawing.Point(10, 180);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(400, 60);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.MouseEnter += new System.EventHandler(this.AutoLogin_MouseEnter);
            this.Password.MouseLeave += new System.EventHandler(this.AutoLogin_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Label Encrypt;
        private System.Windows.Forms.Label Decrypt;
        private System.Windows.Forms.Label Password;
    }
}

