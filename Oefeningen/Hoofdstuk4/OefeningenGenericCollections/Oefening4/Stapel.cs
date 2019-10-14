using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    public class Stapel<T>
    {
        public List<T> Values { get; set; }
        public void AddtoStapel(T t)
        {
            Values.Add(t);
        }

        public T Pop()
        {
            if (Values.Count > 0)
            {
                var first = Values.ElementAt(0);
                Values.RemoveAt(0);

                return first;
            }
            return default(T); //default int = 0, default string = null
        }
    }
}
