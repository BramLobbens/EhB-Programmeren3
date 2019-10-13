using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RekenmachineLibrary;

namespace Rekenmachine
{
    class ClickListener
   {
        private Calculator Calc { get; set; }
        private TextBox X { get; set; }
        private TextBox Y { get; set; }
        private TextBox Output { get; set; }
        public ClickListener(Calculator Calc, TextBox inputX, TextBox inputY, TextBox output)
        {
            this.Calc = Calc;
            this.X = inputX;
            this.Y = inputY;
            this.Output = output;
        }

        public void HandleEvent(object sender)
        {
            double x = GetVal(X);
            double y = GetVal(Y);

            var button = sender as Button;
            switch (button.Name)
            {
                case "add":
                    Calc.Add(x, y);
                    break;
                case "sub":
                    Calc.Sub(x, y);
                    break;
                case "mult":
                    Calc.Mult(x, y);
                    break;
                case "div":
                    try
                    {
                        Calc.Div(x, y);
                    } catch (DivideByZeroException)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        goto case "clear";
                    }
                    break;
                case "clear":
                    Calc.Value = 0;
                    X.Clear();
                    Y.Clear();
                    X.Focus();
                    break;
                default:
                    break;
            }

            Output.Text = Calc.Value.ToString();
        }

        private double GetVal(TextBox src)
        {
            try
            {
                return int.Parse(src.Text);
            } catch (FormatException e)
            {
                Console.WriteLine(e.Source);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Source);
            }
            return 0;
        }
    }
}
