using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStore
{
    public partial class Billing : Form
    {
        Functions Con;
        int Key = 0;
        int Price = 0;
        int n = 0;
        int GrdTotal = 0;
        private int itemIdCounter = 1;

        private string appName = "Pizza Store Applications";
        private string totalAmount = "0";
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();
            QtyTb.KeyPress += QtyTb_KeyPress;

            BillDGV.ReadOnly = true;
            SmallBtn.AutoSize = true;
            MediumBtn.AutoSize = true;
            LargeBtn.AutoSize = true;
            ExtraLargeBtn.AutoSize = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsQuantityValid()
        {
            if (string.IsNullOrEmpty(QtyTb.Text))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }

            int quantity;
            if (!int.TryParse(QtyTb.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a positive integer value for the quantity.");
                return false;
            }

            return true;
        }


        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }
        //int Key = 0;
       // int Price = 0;
        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1)
            {
                Pizza = "Small";
            }else if(Key == 2)
            {
                Pizza = "Medium";    
            }
            else if (Key == 3)
            {
                Pizza = "Large";
            }
            else if (Key == 4)
            {
                Pizza = "Extra Large";
            }
            string Query = "select * from PizzaTbl where Item ='{0}'";
            Query = string.Format(Query, Pizza);
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
            }
        //int n = 0;
        string Items;
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if(!IsQuantityValid())
            {
                return;
            }
            if(SmallBtn.Checked)
            {
                Key = 1;
                Items = "Small Pizza";
            }else if(MediumBtn.Checked)
            {
                Key = 2;
                Items = "Medium Pizza";
            }
            else if (LargeBtn.Checked)
            {
                Key = 3;
                Items = "Large Pizza";
            }
            else if (ExtraLargeBtn.Checked)
            {
                Key = 4;
                Items = "Extra Large Pizza ";
            }

            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            newRow.Cells[0].Value = itemIdCounter;
            itemIdCounter++;
            BillDGV.Rows.Add(newRow);
            n++;
            GrdTotal = GrdTotal + total;
            GrdTotalLbl.Text = "Rs " + GrdTotal;
            QtyTb.Text = "";

            SmallBtn.Checked = false;
            MediumBtn.Checked = false;
            LargeBtn.Checked = false;
            ExtraLargeBtn.Checked = false;
        }

        private void GrdTotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog();
            /*using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument1;
                if(printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            BillDGV.Rows.Clear();
            GrdTotal = 0;
            itemIdCounter = 1;
            GrdTotalLbl.Text = "Rs " + GrdTotal;
            SmallBtn.Checked = false;
            MediumBtn.Checked = false;
            LargeBtn.Checked = false;
            ExtraLargeBtn.Checked = false;

            QtyTb.Text = "";
            MessageBox.Show("Cart Cleared!!!");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font titleFont = new Font("Arial", 36, FontStyle.Bold))
            using (Font headingFont = new Font("Calibri", 24, FontStyle.Bold))
            using (Font contentFont = new Font("Arial", 18, FontStyle.Regular))
            using (SolidBrush titleBrush = new SolidBrush(Color.DarkBlue))
            using (SolidBrush headingBrush = new SolidBrush(Color.DarkGreen))
            using (SolidBrush contentBrush = new SolidBrush(Color.DarkRed))
            {
                int xPos = e.MarginBounds.Left;
                int yPos = e.MarginBounds.Top;

                // Measure the width of the title text
                SizeF titleSize = e.Graphics.MeasureString(appName, titleFont);

                // Calculate the X-coordinate to center the title
                xPos = (int)((e.PageBounds.Width - titleSize.Width) / 2);
    
                // Draw the application name as the title at the top of the page
                e.Graphics.DrawString(appName, titleFont, titleBrush, xPos, yPos);

                // Draw a decorative line below the title
                yPos += (int)titleFont.GetHeight() + 10;
                e.Graphics.DrawLine(new Pen(Color.Black), xPos, yPos, e.MarginBounds.Right, yPos);

                // Draw headings for content below the decorative line
                yPos += 15;
                e.Graphics.DrawString("Order Details", headingFont, headingBrush, xPos, yPos);

                // Draw the total amount below the order details
                yPos += (int)headingFont.GetHeight() + 5;
                e.Graphics.DrawString("Total Amount: Rs " + GrdTotal, contentFont, contentBrush, xPos, yPos);
            }
        }

        private void QtyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
