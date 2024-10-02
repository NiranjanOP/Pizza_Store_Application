namespace PizzaStore
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.Pwdtb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClr = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 564);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(359, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Ordering System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(262, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(267, 249);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(346, 34);
            this.UnameTb.TabIndex = 4;
            // 
            // Pwdtb
            // 
            this.Pwdtb.Location = new System.Drawing.Point(267, 349);
            this.Pwdtb.Name = "Pwdtb";
            this.Pwdtb.Size = new System.Drawing.Size(346, 34);
            this.Pwdtb.TabIndex = 6;
            // 
            // PasswordTb
            // 
            this.PasswordTb.AutoSize = true;
            this.PasswordTb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.Black;
            this.PasswordTb.Location = new System.Drawing.Point(262, 309);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(100, 26);
            this.PasswordTb.TabIndex = 5;
            this.PasswordTb.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.LoginBtn.BorderColor = System.Drawing.Color.Gold;
            this.LoginBtn.BorderSize = 3;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = null;
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(221, 414);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Size = new System.Drawing.Size(160, 42);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(818, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.AnimationHoverSpeed = 0.07F;
            this.BtnClr.AnimationSpeed = 0.03F;
            this.BtnClr.BaseColor = System.Drawing.Color.OrangeRed;
            this.BtnClr.BorderColor = System.Drawing.Color.Gold;
            this.BtnClr.BorderSize = 3;
            this.BtnClr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClr.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClr.ForeColor = System.Drawing.Color.White;
            this.BtnClr.Image = null;
            this.BtnClr.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClr.Location = new System.Drawing.Point(472, 414);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnClr.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnClr.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnClr.OnHoverImage = null;
            this.BtnClr.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClr.Size = new System.Drawing.Size(160, 42);
            this.BtnClr.TabIndex = 9;
            this.BtnClr.Text = "Clear";
            this.BtnClr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 564);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Pwdtb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Pwdtb;
        private System.Windows.Forms.Label PasswordTb;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton LoginBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton BtnClr;
    }
}

