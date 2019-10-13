using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class Form1 : Form
    {
        private IList<double> quantities;
        private IList<double> unitPrices;
        private IList<double> subTotals;
        public Form1()
        {
            InitializeComponent();
            this.quantities = new List<double>();
            this.unitPrices = new List<double>();
            this.subTotals = new List<double>();
        }

        private void readValues()
        {
            // Read all labels in the quantity column
            for (int i = 0; i < Constants.NumOfItems; i++)
            {
                Control control = this.tableLayoutPanel1.GetControlFromPosition(Constants.QtyCol, i + 1);
                quantities.Add(double.Parse(control.Text));
            }

            // Read all labels in the unitPrice column
            for (int i = 0; i < Constants.NumOfItems; i++)
            {
                Control control = this.tableLayoutPanel1.GetControlFromPosition(Constants.UnitPriceCol, i + 1);
                if (string.IsNullOrEmpty(control.Text))
                {
                    control.Text = "0";
                }
                unitPrices.Add(double.Parse(control.Text));
                
            }
        }

        private void calcSubTotals()
        {
            // Using Zip to combine quantities and unit prices. Result is stored in subTotals list
            var results = quantities.Zip(unitPrices, (a, b) => a * b);
            foreach (var result in results)
            {
                subTotals.Add((double) result);
            }
        }

        private void displayResults()
        {
            //Ext. Price
            for (int i = 0; i < Constants.NumOfItems; i++)
            {
                Control control = this.tableLayoutPanel1.GetControlFromPosition(Constants.SubTotCol, i + 1);
                control.Text = Constants.CurrencyPref + subTotals.ElementAt(i).ToString("N2");
            }

            //Subtotal
            subtotalField.Clear();

            double subtotal = subTotals.Sum();
            subtotalField.Text = Constants.CurrencyPref + subtotal.ToString("N2");

            //Sales Tax
            if (string.IsNullOrEmpty(taxRateField.Text))
            {
                taxRateField.Text = "0";
            }
            double salestax = subtotal * double.Parse(taxRateField.Text);
            salesTaxField.Text = Constants.CurrencyPref + salestax.ToString("N2");

            //Grand Total
            if (string.IsNullOrEmpty(shippingField.Text))
            {
                shippingField.Text = "0";
            }
            double shipping = double.Parse(shippingField.Text);
            grandTotalField.Text = Constants.CurrencyPref + (subtotal + salestax + shipping);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readValues();
            calcSubTotals();
            displayResults();
        }
    }
    static class Constants
    {
        public const string CurrencyPref = "€ ";
        public const int NumOfItems = 4;
        public const int QtyCol = 1;
        public const int UnitPriceCol = 2;
        public const int SubTotCol = 3;
    }
}
