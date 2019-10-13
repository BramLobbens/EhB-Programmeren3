using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening6
{
    public partial class Form1 : Form
    {
        public const double TaxRate = 0.07; //7% tax rate
        public const int NumOfItems = 4;
        public const int PriceEachCol = 1;
        public const int QtyCol = 2;
        public const int PriceCol = 3;

        private double subtotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculatePrices()
        {
            subtotal = 0; //Reset subtotal before recalculating

            //Read all labels in the 'Price Each' and 'Quantity' column
            for (int i = 0; i < NumOfItems; i++)
            {
                Control priceEachLabel = this.tableLayoutPanel1.GetControlFromPosition(PriceEachCol, i + 1);
                if (string.IsNullOrEmpty(priceEachLabel.Text))
                {
                    priceEachLabel.Text = "0";
                }
                double priceEach = double.Parse(priceEachLabel.Text);
                Console.WriteLine(priceEach);

                Control quantityLabel = this.tableLayoutPanel1.GetControlFromPosition(QtyCol, i + 1);
                if (string.IsNullOrEmpty(quantityLabel.Text))
                {
                    quantityLabel.Text = "0";
                }
                double quantity = double.Parse(quantityLabel.Text);

                Control priceLabel = this.tableLayoutPanel1.GetControlFromPosition(PriceCol, i + 1);
                double price = priceEach * quantity;
                priceLabel.Text = "€ " + price.ToString("N2");

                subtotal += price;
            }
        }

        // EUR 5.00 if cost < 20. EUR 7.50 if cost < 50. EUR 10.00 if < 75. If >= 75 shipping is free.
        private double CalculateShipping(double cost)
        {
            double shipping = 0;
            if (cost < 75 && cost >= 50)
            {
                shipping = 10;
            } else if (cost < 50 && cost >= 20)
            {
                shipping = 7.5;
            } else if (cost < 20 && cost > 0)
            {
                shipping = 5;
            }

            return shipping;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatePrices();

            //Subtotal
            subtotalField.Text = "€ " + subtotal.ToString("N2");

            //Sales Tax
            double salesTax = subtotal * TaxRate;
            salesTaxField.Text = "€ " + salesTax.ToString("N2");

            //Shipping
            double shipping = CalculateShipping(subtotal);
            shippingField.Text = "€ " + shipping.ToString("N2");

            //Grand Total
            grandTotalField.Text = "€ " + (subtotal + salesTax + shipping).ToString("N2");

        }
    }
}
