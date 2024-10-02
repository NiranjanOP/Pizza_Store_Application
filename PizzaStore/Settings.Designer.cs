namespace PizzaStore
{
    partial class Settings
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PizzaCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new Guna.UI.WinForms.GunaButton();
            this.BackLbl = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 720);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(209, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Ordering System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(276, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(627, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PizzaCb
            // 
            this.PizzaCb.FormattingEnabled = true;
            this.PizzaCb.Items.AddRange(new object[] {
            "Extra Large",
            "Large",
            "Medium",
            "Small"});
            this.PizzaCb.Location = new System.Drawing.Point(187, 213);
            this.PizzaCb.Name = "PizzaCb";
            this.PizzaCb.Size = new System.Drawing.Size(313, 34);
            this.PizzaCb.TabIndex = 10;
            this.PizzaCb.SelectedIndexChanged += new System.EventHandler(this.PizzaCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(182, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select The Pizza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(184, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter the Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(187, 347);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(313, 31);
            this.PriceTb.TabIndex = 13;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AnimationHoverSpeed = 0.07F;
            this.SubmitBtn.AnimationSpeed = 0.03F;
            this.SubmitBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.SubmitBtn.BorderColor = System.Drawing.Color.Gold;
            this.SubmitBtn.BorderSize = 3;
            this.SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubmitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Image = null;
            this.SubmitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SubmitBtn.Location = new System.Drawing.Point(255, 437);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SubmitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubmitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SubmitBtn.OnHoverImage = null;
            this.SubmitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SubmitBtn.Size = new System.Drawing.Size(160, 42);
            this.SubmitBtn.TabIndex = 14;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.BackLbl.Location = new System.Drawing.Point(298, 553);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(63, 28);
            this.BackLbl.TabIndex = 15;
            this.BackLbl.Text = "Back";
            this.BackLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 720);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PizzaCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PizzaCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTb;
        private Guna.UI.WinForms.GunaButton SubmitBtn;
        private System.Windows.Forms.Label BackLbl;
    }
}