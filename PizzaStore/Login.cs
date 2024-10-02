using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || Pwdtb.Text == "")
            {
                MessageBox.Show("Missing Information !");
            }
            else if (UnameTb.Text == "Username" && PasswordTb.Text == "Password")
            {
                Billing Obj = new Billing();


                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
            private void BtnClr_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            Pwdtb.Text = "";
        }
    }
}
