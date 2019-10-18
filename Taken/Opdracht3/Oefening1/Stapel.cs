using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Stapel<T>
    {
        internal List<T> Values { get; set; }

        public Stapel()
        {
            Values = new List<T>();
        }

        public void Toevoegen(T t)
        {
            Values.Add(t);
        }

        //Pop the first item from the list and return its value.
        public T Verwijderen()
        {
            if (Values.Count > 0)
            {
                var first = Values.ElementAt(0);
                Values.RemoveAt(0);

                return first;
            }
            return default;
        }

        //Empty the list
        public void Leegmaken()
        {
            Values.Clear();
        }

        public bool IsAanwezig(T t)
        {
            return Values.Contains(t);
        }

        //Make a Shallow copy of Values
        public Stapel<T> Copy()
        {
            List<T> copy = Values.ConvertAll(value => value);
            Stapel<T> newStapel = new Stapel<T>();
            foreach(var val in copy)
            {
                newStapel.Toevoegen(val);
            }
            return newStapel;
        }

        public override string ToString()
        {
            return Values.ToString();
        }

    }
}
