using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGIS_350_PROJ1_FLOSS
{
    public partial class Form1 : Form
    {
        // default quantity
        decimal quantity = 0;

        // initializing quantities of each order
        decimal SSH = 0;
        decimal LSH = 0;
        decimal SS = 0;
        decimal LS = 0;
        decimal LBH = 0;
        decimal SBH = 0;
        decimal LB = 0;
        decimal SB = 0;
        decimal SSBH = 0;
        decimal LSBH = 0;
        decimal SSB = 0;
        decimal LSB = 0;

        // Total inventory amounts
        decimal strawberries = 0;
        decimal bananas = 0;
        decimal honey = 0;
        decimal milk = 0;
        int largeCups = 0;
        int smallCups = 0;

        // money vars
        decimal expenses = 0;
        decimal sales = 0;

        // constants (prices, amounts, etc)
        const decimal STRAWBERRY_SIZE_SMALL = 4;
        const decimal STRAWBERRY_SIZE_LARGE = 6;
        const decimal STRAWBERRY_PURCHASE_PRICE = 8;
        const decimal STRAWBERRY_PURCHASE_QTY = 32;
        const decimal BANANA_SIZE_SMALL = 4;
        const decimal BANANA_SIZE_LARGE = 6;
        const decimal BANANA_PURCHASE_PRICE = 0.7m;
        const decimal BANANA_PURCHASE_QTY = 16;
        const decimal HONEY_SIZE_SMALL = 1;
        const decimal HONEY_SIZE_LARGE = 2;
        const decimal HONEY_PURCHASE_PRICE = 9;
        const decimal HONEY_PURCHSE_QTY = 12;
        const decimal MILK_SIZE_SMALL = 6;
        const decimal MILK_SIZE_LARGE = 12;
        const decimal MILK_PURCHASE_PRICE = 3;
        const decimal MILK_PURCHASE_QTY = 12;
        const decimal SMALL_CUP_PURCHASE_PRICE = 4;
        const int SMALL_CUP_PURCHASE_QTY = 250;
        const decimal LARGE_CUP_PURCHASE_PRICE = 250;
        const int LARGE_CUP_PURCHASE_QTY = 250;

        public Form1()
        {
            InitializeComponent();
        }

        // BUY STRAWBS
        private void btnStrawberry_Click(object sender, EventArgs e)
        {
            strawberries += STRAWBERRY_PURCHASE_QTY;
            expenses += STRAWBERRY_PURCHASE_PRICE;
            lblStrawberry.Text = "Strawberries: " + strawberries + " oz";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        // BUY BANAN
        private void btnBanana_Click(object sender, EventArgs e)
        {
            bananas += BANANA_PURCHASE_QTY;
            expenses += BANANA_PURCHASE_PRICE;
            lblBanana.Text = "Bananas: " + bananas + " oz";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        // BUY HONEY
        private void btnHoney_Click(object sender, EventArgs e)
        {
            honey += HONEY_PURCHSE_QTY;
            expenses += HONEY_PURCHASE_PRICE;
            lblHoney.Text = "Honey: " + honey + " oz";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        // BUY MILK
        private void btnMilk_Click(object sender, EventArgs e)
        {
            milk += MILK_PURCHASE_QTY;
            expenses += MILK_PURCHASE_PRICE;
            lblMilk.Text = "Milk: " + milk + " oz";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        // BUY SMALLCUPS
        private void btnSmallCups_Click(object sender, EventArgs e)
        {
            smallCups += SMALL_CUP_PURCHASE_QTY;
            expenses += SMALL_CUP_PURCHASE_PRICE;
            lblSmallCups.Text = "Small Cups: " + smallCups + " units";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        //buy LARGE CUP
        private void btnLargeCups_Click(object sender, EventArgs e)
        {
            largeCups += LARGE_CUP_PURCHASE_QTY;
            expenses += LARGE_CUP_PURCHASE_PRICE;
            lblLargeCups.Text = "Large Cups: " + largeCups + " units";
            lblExpPrice.Text = expenses.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");
        }

        private void checkInv(decimal x, int index)
        {
            if (index == 0)
            {
                if((strawberries < 4 * x) || (honey < 1 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Strawberry with Honey");
                } 
                else
                {
                    strawberries -= 4 * x;
                    honey -= 1 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if(index == 1)
            {
                if ((bananas < 4 * x) || (strawberries < 4 * x) || (honey < 1 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Strawberry Banana with Honey");
                }
                else
                {
                    bananas -= 4 * x;
                    strawberries -= 4 * x;
                    honey -= 1 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if(index == 2)
            {
                if ((bananas < 4 * x) || (honey < 1 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Banana with Honey");
                }
                else
                {
                    bananas -= 4 * x;
                    honey -= 1 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if (index == 3)
            {
                if ((bananas < 4 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Banana");
                }
                else
                {
                    bananas -= 4 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if(index == 4)
            {
                if ((bananas < 4 * x) || (strawberries < 4 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Strawberry Banana");
                }
                else
                {
                    strawberries -= 4 * x;
                    bananas -= 4 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if(index == 5)
            {
                if ((strawberries < 4 * x) || (milk < 6 * x) || (smallCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Small Strawberry");
                }
                else
                {
                    strawberries -= 4 * x;
                    milk -= 6 * x;
                    smallCups -= 1 * (int)x;
                    sales += 4 * x;
                }
            }
            else if(index == 6)
            {
                if ((strawberries < 6 * x) || (honey < 2 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Strawberry with Honey");
                }
                else
                {
                    strawberries -= 6 * x;
                    honey -= 2 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
            else if(index == 7)
            {
                if ((bananas < 6 * x) || (strawberries < 6 * x) || (honey < 2 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Strawberry Banana with Honey");
                }
                else
                {
                    bananas -= 6 * x;
                    strawberries -= 6 * x;
                    honey -= 2 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
            else if(index == 8)
            {
                if ((bananas < 6 * x) || (honey < 2 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Banana with Honey");
                }
                else
                {
                    bananas -= 6 * x;
                    honey -= 2 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
            else if(index == 9)
            {
                if ((bananas < 6 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Banana");
                }
                else
                {
                    bananas -= 6 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
            else if(index == 10)
            {
                if ((strawberries < 6 * x) || (bananas < 6 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Strawberry Banana");
                }
                else
                {
                    strawberries -= 6 * x;
                    bananas -= 6 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
            else
            {
                if ((strawberries < 6 * x) || (milk < 12 * x) || (largeCups < 1 * x))
                {
                    MessageBox.Show("Insufficient inventory: Large Strawberry");
                }
                else
                {
                    strawberries -= 6 * x;
                    milk -= 12 * x;
                    largeCups -= 1 * (int)x;
                    sales += 5 * x;
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            txtOrderList.Text = "";
            decimal[] orderarr = new decimal[12] { SSH, SSBH, SBH, SB, SSB, SS,
                LSH, LSBH, LBH, LB, LSB, LS };
            // check inventory
            for(int i = 0; i < orderarr.Length; i++)
            {
                checkInv(orderarr[i], i);
            }

            // inv update
            lblStrawberry.Text = "Strawberries: " + strawberries + " oz";
            lblBanana.Text = "Bananas: " + bananas + " oz";
            lblHoney.Text = "Honey: " + honey + " oz";
            lblMilk.Text = "Milk: " + milk + " oz";
            lblSmallCups.Text = "Small Cups: " + smallCups + " units";
            lblLargeCups.Text = "Large Cups: " + largeCups + " units";
            
            // money
            sales += 0;
            lblTotSales.Text = sales.ToString("c");
            lblTotProfit.Text = (sales - expenses).ToString("c");

            // clear order values
            SSH = 0;
            LSH = 0;
            SS = 0;
            LS = 0;
            LBH = 0;
            SBH = 0;
            LB = 0;
            SB = 0;
            SSBH = 0;
            LSBH = 0;
            SSB = 0;
            LSB = 0;
            numQuant.Value = 0;
            chkStrawb.Checked = true;
            chkHoney.Checked = false;
            rdoSmall.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOrderList.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            quantity = numQuant.Value;
            if (chkStrawb.Checked == true && chkBanan.Checked == false && chkHoney.Checked == true && rdoSmall.Checked == true)
            { 
                txtOrderList.AppendText(quantity + " x Small Strawberry with Honey\n");
                SSH += quantity;
            }
            else if(chkStrawb.Checked == true && chkBanan.Checked == false && chkHoney.Checked == false && rdoSmall.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Small Strawberry\n");
                SS += quantity;
            }
            else if(chkStrawb.Checked == true && chkBanan.Checked == false && chkHoney.Checked == true && rdoLarge.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Large Strawberry with Honey\n");
                LSH += quantity;
            }
            else if(chkStrawb.Checked == true && chkBanan.Checked == false && chkHoney.Checked == false && rdoLarge.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Large Strawberry\n");
                LS += quantity;
            }
            else if (chkBanan.Checked == true && chkStrawb.Checked == false && chkHoney.Checked == true && rdoSmall.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Small Banana with Honey\n");
                SBH += quantity;
            }
            else if (chkBanan.Checked == true && chkStrawb.Checked == false && chkHoney.Checked == false && rdoSmall.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Small Banana\n");
                SB += quantity;
            }
            else if (chkBanan.Checked == true && chkStrawb.Checked == false && chkHoney.Checked == true && rdoLarge.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Large Banana with Honey\n");
                LBH += quantity;
            }
            else if(chkStrawb.Checked == true && chkBanan.Checked == true && chkHoney.Checked == true && rdoSmall.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Small Strawberry Banana with Honey\n");
                SSBH += quantity;
            }
            else if (chkStrawb.Checked == true && chkBanan.Checked == true && chkHoney.Checked == false && rdoSmall.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Small Strawberry Banana\n");
                SSB += quantity;
            }
            else if (chkStrawb.Checked == true && chkBanan.Checked == true && chkHoney.Checked == true && rdoLarge.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Large Strawberry Banana with Honey\n");
                LSBH += quantity;
            }
            else if (chkStrawb.Checked == true && chkBanan.Checked == true && chkHoney.Checked == false && rdoLarge.Checked == true)
            {
                txtOrderList.AppendText(quantity + " x Large Strawberry Banana\n");
                LSB += quantity;
            }
            else
            {
                txtOrderList.AppendText(quantity + " x Large Banana\n");
                LB += quantity;
            }
        }
    }
}