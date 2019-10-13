using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConvertor
{
    public partial class Form1 : Form
    {
        //10/10/2019 USD Exchange rates
        private const double USDtoGBP = 0.80390; //British Pound
        private const double USDtoEUR = 0.90836; //Euro
        private const double USDtoJPY = 107.87461; //Japanese Yen
        private const double USDtoINR = 70.98776; //Indian Rupee
        private const double USDtoCHF = 0.99634; //Swiss Franc

        private double Value { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayMessage();
        }

        private void DisplayMessage()
        {
            MessageBox.Show("Please be aware that user input is not optimal. You should only type in whole numbers before the decimal point.", "Notification");
        }

        private void InputHandler(object sender)
        {
            //Read input field from one currency field and convert to USD.
            var control = sender as Control;

            /*
             * Note: ContainsFocus necessary to avoid floating point bug of original input value.
             * e.g. input of "1" -> may turn into "1.01" or "0.99" without this check.
             */
            if (control.ContainsFocus)
            {
                ConvertLocaltoUSD(control); 
            }
            //Convert USD amount of input field to local currencies of all other fields.
            Controls.OfType<TextBox>().ToList().ForEach(a => ConvertUSDtoLocal(a));
        }

        private void ConvertLocaltoUSD(Control control)
        {
            var localValue = ParseValue(control.Text);

            if (control.Name.Equals(usdField.Name))
            {
                Value = localValue;
            }
            else if (control.Name.Equals(gbpField.Name))
            {
                Value = localValue / USDtoGBP;
            }
            else if (control.Name.Equals(eurField.Name))
            {
                Value = localValue / USDtoEUR;
            }
            else if (control.Name.Equals(jpyField.Name))
            {
                Value = localValue / USDtoJPY;
            }
            else if (control.Name.Equals(inrField.Name))
            {
                Value = localValue / USDtoINR;
            }
            else if (control.Name.Equals(chfField.Name))
            {
                Value = localValue / USDtoCHF;
            }
        }

        private void ConvertUSDtoLocal(Control control)
        {
            if (control.Name.Equals(usdField.Name))
            {
                control.Text = Value.ToString("n2");
            }
            else if (control.Name.Equals(gbpField.Name))
            {
                control.Text = (Value * USDtoGBP).ToString("n2");
            }
            else if (control.Name.Equals(eurField.Name))
            {
                control.Text = (Value * USDtoEUR).ToString("n2");
            }
            else if (control.Name.Equals(jpyField.Name))
            {
                control.Text = (Value * USDtoJPY).ToString("n2");
            }
            else if (control.Name.Equals(inrField.Name))
            {
                control.Text = (Value * USDtoINR).ToString("n2");
            }
            else if (control.Name.Equals(chfField.Name))
            {
                control.Text = (Value * USDtoCHF).ToString("n2");
            }
        }

        private double ParseValue(string text)
        {
            try
            {
                return double.Parse(text);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Source);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Source);
            }
            return 0;
        }

        private void usdField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }

        private void gbpField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }

        private void eurField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }

        private void jpyField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }

        private void inrField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }

        private void chfField_TextChanged(object sender, EventArgs e)
        {
            InputHandler(sender);
        }
    }
}
