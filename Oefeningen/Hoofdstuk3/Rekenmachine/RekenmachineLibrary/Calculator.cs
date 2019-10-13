using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenmachineLibrary
{
    public interface ICalculator
    {
        void Add(double x, double y);
        void Sub(double x, double y);
        void Mult(double x, double y);
        void Div(double x, double y);
        void Pow(double x, double y);
        void Sqrt(double n);
    }
    public class Calculator : ICalculator
    {
        public double Value { get; set; }

        public void Add(double x, double y)
        {
            Value = x + y;
        }
        public void Sub(double x, double y)
        {
            Value = x - y;
        }
        public void Mult(double x, double y)
        {
            Value = x * y;
        }
        public void Div(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            Value = x / y;
        }
        public void Pow(double x, double y)
        {
            Value = Math.Pow(x, y);
        }
        public void Sqrt(double n)
        {
            Value = Math.Sqrt(n);
        }
    }
}
