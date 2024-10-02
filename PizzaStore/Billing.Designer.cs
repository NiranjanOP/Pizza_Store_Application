namespace PizzaStore
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtraLargeBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.LargeBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.MediumBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.SmallBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.OrderBtn = new Guna.UI.WinForms.GunaButton();
            this.BillDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrintBtn = new Guna.UI.WinForms.GunaButton();
            this.GrdTotalLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new Guna.UI.WinForms.GunaButton();
            this.LogoutBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Ordering System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExtraLargeBtn);
            this.panel1.Controls.Add(this.LargeBtn);
            this.panel1.Controls.Add(this.MediumBtn);
            this.panel1.Controls.Add(this.SmallBtn);
            this.panel1.Location = new System.Drawing.Point(165, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 330);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please Select a Pizza";
            // 
            // ExtraLargeBtn
            // 
            this.ExtraLargeBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.ExtraLargeBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.ExtraLargeBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExtraLargeBtn.FillColor = System.Drawing.Color.White;
            this.ExtraLargeBtn.Location = new System.Drawing.Point(48, 249);
            this.ExtraLargeBtn.Name = "ExtraLargeBtn";
            this.ExtraLargeBtn.Size = new System.Drawing.Size(138, 28);
            this.ExtraLargeBtn.TabIndex = 3;
            this.ExtraLargeBtn.Text = "Extra Large";
            // 
            // LargeBtn
            // 
            this.LargeBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.LargeBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.LargeBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LargeBtn.FillColor = System.Drawing.Color.White;
            this.LargeBtn.Location = new System.Drawing.Point(48, 195);
            this.LargeBtn.Name = "LargeBtn";
            this.LargeBtn.Size = new System.Drawing.Size(84, 28);
            this.LargeBtn.TabIndex = 2;
            this.LargeBtn.Text = "Large";
            // 
            // MediumBtn
            // 
            this.MediumBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.MediumBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.MediumBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MediumBtn.FillColor = System.Drawing.Color.White;
            this.MediumBtn.Location = new System.Drawing.Point(48, 143);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(104, 28);
            this.MediumBtn.TabIndex = 1;
            this.MediumBtn.Text = "Medium";
            // 
            // SmallBtn
            // 
            this.SmallBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.SmallBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.SmallBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SmallBtn.FillColor = System.Drawing.Color.White;
            this.SmallBtn.Location = new System.Drawing.Point(47, 89);
            this.SmallBtn.Name = "SmallBtn";
            this.SmallBtn.Size = new System.Drawing.Size(83, 28);
            this.SmallBtn.TabIndex = 0;
            this.SmallBtn.Text = "Small";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 785);
            this.panel2.TabIndex = 4;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // OrderBtn
            // 
            this.OrderBtn.AnimationHoverSpeed = 0.07F;
            this.OrderBtn.AnimationSpeed = 0.03F;
            this.OrderBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.OrderBtn.BorderColor = System.Drawing.Color.Gold;
            this.OrderBtn.BorderSize = 3;
            this.OrderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OrderBtn.FocusedColor = System.Drawing.Color.Empty;
            this.OrderBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.Color.White;
            this.OrderBtn.Image = null;
            this.OrderBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.OrderBtn.Location = new System.Drawing.Point(153, 546);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.OrderBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OrderBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.OrderBtn.OnHoverImage = null;
            this.OrderBtn.OnPressedColor = System.Drawing.Color.Black;
            this.OrderBtn.Size = new System.Drawing.Size(198, 42);
            this.OrderBtn.TabIndex = 8;
            this.OrderBtn.Text = "Add To Your Order";
            this.OrderBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // BillDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillDGV.ColumnHeadersHeight = 29;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillDGV.EnableHeadersVisualStyles = false;
            this.BillDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.Location = new System.Drawing.Point(578, 93);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersVisible = false;
            this.BillDGV.RowHeadersWidth = 51;
            this.BillDGV.RowTemplate.Height = 24;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(712, 479);
            this.BillDGV.TabIndex = 9;
            this.BillDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.BillDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.BillDGV.ThemeStyle.ReadOnly = false;
            this.BillDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(1335, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.Location = new System.Drawing.Point(314, 490);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(100, 34);
            this.QtyTb.TabIndex = 11;
            this.QtyTb.TextChanged += new System.EventHandler(this.QtyTb_TextChanged);
            this.QtyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // PrintBtn
            // 
            this.PrintBtn.AnimationHoverSpeed = 0.07F;
            this.PrintBtn.AnimationSpeed = 0.03F;
            this.PrintBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.PrintBtn.BorderColor = System.Drawing.Color.Gold;
            this.PrintBtn.BorderSize = 3;
            this.PrintBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PrintBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Image = null;
            this.PrintBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PrintBtn.Location = new System.Drawing.Point(830, 705);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PrintBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PrintBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PrintBtn.OnHoverImage = null;
            this.PrintBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PrintBtn.Size = new System.Drawing.Size(198, 42);
            this.PrintBtn.TabIndex = 13;
            this.PrintBtn.Text = "Print Your Order";
            this.PrintBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrintBtn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // GrdTotalLbl
            // 
            this.GrdTotalLbl.AutoSize = true;
            this.GrdTotalLbl.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdTotalLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GrdTotalLbl.Location = new System.Drawing.Point(865, 656);
            this.GrdTotalLbl.Name = "GrdTotalLbl";
            this.GrdTotalLbl.Size = new System.Drawing.Size(149, 36);
            this.GrdTotalLbl.TabIndex = 14;
            this.GrdTotalLbl.Text = "GrdTotalbl";
            this.GrdTotalLbl.Click += new System.EventHandler(this.GrdTotalLbl_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AnimationHoverSpeed = 0.07F;
            this.SettingsBtn.AnimationSpeed = 0.03F;
            this.SettingsBtn.BackColor = System.Drawing.Color.White;
            this.SettingsBtn.BaseColor = System.Drawing.Color.Gold;
            this.SettingsBtn.BorderColor = System.Drawing.Color.OrangeRed;
            this.SettingsBtn.BorderSize = 3;
            this.SettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingsBtn.Image = null;
            this.SettingsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsBtn.Location = new System.Drawing.Point(195, 705);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.SettingsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnHoverImage = null;
            this.SettingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsBtn.Size = new System.Drawing.Size(180, 28);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.Text = "Set The Price";
            this.SettingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsBtn.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AnimationHoverSpeed = 0.07F;
            this.LogoutBtn.AnimationSpeed = 0.03F;
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.BaseColor = System.Drawing.Color.DodgerBlue;
            this.LogoutBtn.BorderColor = System.Drawing.Color.Blue;
            this.LogoutBtn.BorderSize = 3;
            this.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = null;
            this.LogoutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LogoutBtn.Location = new System.Drawing.Point(404, 705);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.LogoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LogoutBtn.OnHoverImage = null;
            this.LogoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogoutBtn.Size = new System.Drawing.Size(180, 28);
            this.LogoutBtn.TabIndex = 16;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogoutBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.OrangeRed;
            this.gunaButton1.BorderColor = System.Drawing.Color.Gold;
            this.gunaButton1.BorderSize = 3;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(386, 546);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(198, 42);
            this.gunaButton1.TabIndex = 17;
            this.gunaButton1.Text = "Clear Cart";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 785);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GrdTotalLbl);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BillDGV);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaRadioButton ExtraLargeBtn;
        private Guna.UI.WinForms.GunaRadioButton LargeBtn;
        private Guna.UI.WinForms.GunaRadioButton MediumBtn;
        private Guna.UI.WinForms.GunaRadioButton SmallBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton OrderBtn;
        private Guna.UI.WinForms.GunaDataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtyTb;
        private Guna.UI.WinForms.GunaButton PrintBtn;
        private Guna.UI.WinForms.GunaButton SettingsBtn;
        private System.Windows.Forms.Label GrdTotalLbl;
        private Guna.UI.WinForms.GunaButton LogoutBtn;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}