using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    public class Stapel
    {
        public List<int> Nums { get; set; }
        public void AddtoStapel(int n)
        {
            Nums.Add(n);
        }

        public int? Pop()
        {
            if (Nums.Count > 0)
            {
                var first = Nums.ElementAt(0);
                Nums.RemoveAt(0);

                return first;
            }
            return null;
        }
    }
}
