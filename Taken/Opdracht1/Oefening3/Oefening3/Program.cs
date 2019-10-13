using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToCheck = 546;

            for (int i = 1; i <= 100; i++)
            {
                if ((i * 7) > numToCheck)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
