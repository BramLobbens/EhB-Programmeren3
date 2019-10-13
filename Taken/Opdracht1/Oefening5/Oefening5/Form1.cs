using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CelsiusToFahrenheit(double degree)
        {
            return (degree * (9.0 / 5.0)) + 32;
        }

        private double FahrenheitToCelsius(double degree)
        {
            return (degree - 32) * 5.0 / 9.0;
        }

        //C to F
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input a value.");
                return;
            }
            try
            {
                double val = double.Parse(textBox1.Text);
                textBox2.Text = CelsiusToFahrenheit(val).ToString();
            } catch (FormatException err)
            {
                MessageBox.Show("Input must be a number.");
                Console.WriteLine(err.Source);
            }
            
        }

        //F to C
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please input a value.");
                return;
            }
            try
            {
                double val = double.Parse(textBox2.Text);
                textBox1.Text = FahrenheitToCelsius(val).ToString();
            }
            catch (FormatException err)
            {
                MessageBox.Show("Input must be a number.");
                Console.WriteLine(err.Source);
            }
        }
    }
}
