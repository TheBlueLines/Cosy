
namespace Cosy
{
    partial class AutoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoLogin));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.Head = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.password3 = new System.Windows.Forms.TextBox();
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
            // Head
            // 
            this.Head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Head.BackColor = System.Drawing.Color.Transparent;
            this.Head.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Head.ForeColor = System.Drawing.Color.LightGray;
            this.Head.Location = new System.Drawing.Point(10, 40);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(400, 50);
            this.Head.TabIndex = 1;
            this.Head.Text = "Password:";
            this.Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password1
            // 
            this.password1.BackColor = System.Drawing.Color.DarkGray;
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password1.ForeColor = System.Drawing.Color.Gray;
            this.password1.Location = new System.Drawing.Point(10, 100);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(400, 31);
            this.password1.TabIndex = 2;
            this.password1.Text = "Old password";
            this.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password1.Enter += new System.EventHandler(this.password1_Enter);
            this.password1.Leave += new System.EventHandler(this.password1_Leave);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.DarkGray;
            this.Save.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.DimGray;
            this.Save.Location = new System.Drawing.Point(10, 220);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(400, 50);
            this.Save.TabIndex = 3;
            this.Save.Text = "SAVE";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.MouseEnter += new System.EventHandler(this.Save_MouseEnter);
            this.Save.MouseLeave += new System.EventHandler(this.Save_MouseLeave);
            // 
            // password2
            // 
            this.password2.BackColor = System.Drawing.Color.DarkGray;
            this.password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password2.ForeColor = System.Drawing.Color.Gray;
            this.password2.Location = new System.Drawing.Point(10, 140);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(400, 31);
            this.password2.TabIndex = 4;
            this.password2.Text = "New password";
            this.password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password2.Enter += new System.EventHandler(this.password2_Enter);
            this.password2.Leave += new System.EventHandler(this.password2_Leave);
            // 
            // password3
            // 
            this.password3.BackColor = System.Drawing.Color.DarkGray;
            this.password3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password3.ForeColor = System.Drawing.Color.Gray;
            this.password3.Location = new System.Drawing.Point(10, 180);
            this.password3.Name = "password3";
            this.password3.Size = new System.Drawing.Size(400, 31);
            this.password3.TabIndex = 5;
            this.password3.Text = "New password again";
            this.password3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password3.Enter += new System.EventHandler(this.password3_Enter);
            this.password3.Leave += new System.EventHandler(this.password3_Leave);
            // 
            // AutoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password3);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoLogin";
            this.Text = "AutoLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AutoLogin_KeyDown);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.TextBox password3;
    }
}