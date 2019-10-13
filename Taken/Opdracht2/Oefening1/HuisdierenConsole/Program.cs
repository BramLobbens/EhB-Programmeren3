using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuisdierenLibrary;

namespace HuisdierenConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>();

            Koe huisKoe = new Koe("Maggie")
            {
                Gewicht = new Random().Next(400, 700)
            };
            dieren.Add(huisKoe);

            Slang huisSlang = new Slang("Sir Hiss")
            {
                Gewicht = new Random().Next(1, 5)
            };
            dieren.Add(huisSlang);

            Varken huisVarken = new Varken("Hamm")
            {
                Gewicht = new Random().Next(45, 100)
            };
            dieren.Add(huisVarken);

            dieren.ForEach(a => Console.WriteLine($"{a} zegt: {a.Zeg()}"));
        }
    }
}
