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
    public partial class Settings : Form
    {
        Functions Con;
        public Settings()
        {
            InitializeComponent();
            Con = new Functions();
            PizzaCb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            if (int.TryParse(PriceTb.Text, out int Pr) && Pr >= 0)
            {
                if (PizzaCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select A Pizza!!!");
                }
                else
                {
                    if (PizzaCb.SelectedIndex == 0)
                    {
                        Key = "Extra Large";
                    }
                    else if (PizzaCb.SelectedIndex == 1)
                    {
                        Key = "Large";
                    }
                    else if (PizzaCb.SelectedIndex == 2)
                    {
                        Key = "Medium";
                    }
                    else // (PizzaCb.SelectedIndex == 3)
                    {
                        Key = "Small";
                    }

                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer for the price!");
            }
        }

        private void PizzaCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
