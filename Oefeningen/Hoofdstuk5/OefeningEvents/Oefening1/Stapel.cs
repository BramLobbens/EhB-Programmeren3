using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Stapel<T>
    {
        public List<T> Values { get; set; }

        // delegate
        public delegate void Handler(string s);
        // event
        public event Handler Wijzig;


        public void AddtoStapel(T t)
        {
            Values.Add(t);
            Wijzig($"{t} werd toegevoegd");
        }

        public T Pop()
        {
            if (Values.Count > 0)
            {
                var first = Values.ElementAt(0);
                Values.RemoveAt(0);

                Wijzig($"{first} werd verwijderd");
                return first;
            }
            return default(T);
        }
    }
}
