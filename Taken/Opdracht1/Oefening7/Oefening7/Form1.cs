using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Makes summation of given integer. ( ( n ( n + 1 ) ) / 2 ).
        /// </summary>
        /// <param name="num">an integer number</param>
        /// <returns>the summation of all numbers before given param num</returns>
        private int TriangleNumber(int num)
        {
            return (num * (num + 1)) / 2;
        }

        private void displayResult()
        {
            // Read number from textBox1 and call TriangleNumber. Return result to textBox2. Clear textBox1.
            try
            {
                int num = Int32.Parse(this.inputField.Text);
                this.outputField.Text = TriangleNumber(num).ToString();
            }
            catch (FormatException err)
            {
                string err_Message = "Input must not be empty and must be a number.";
                MessageBox.Show(err_Message);
                Console.WriteLine(err_Message + ": {0}", err.Source);
            }
            finally
            {
                this.inputField.Clear();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            displayResult();
        }

        private void inputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13) // enter key
            {
                displayResult();
            }
        }
    }
}
