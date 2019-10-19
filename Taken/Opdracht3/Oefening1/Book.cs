using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Book : ICopyable<Book>
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public DateTime PublicatieDatum { get; set; }

        public Book(string titel = "", string auteur = "", string publicatieDatum = "")
        {
            Titel = titel;
            Auteur = auteur;
            try
            {
                PublicatieDatum = DateTime.Parse(publicatieDatum);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
                PublicatieDatum = default;
            }
        }

        public Book Copy()
        {
            return new Book(Titel, Auteur, PublicatieDatum.ToString());
        }

        public override string ToString()
        {
            return $"Titel: {Titel}, Auteur: {Auteur}, Publicatiedatum: {PublicatieDatum.ToShortDateString()}";
        }
    }
}
