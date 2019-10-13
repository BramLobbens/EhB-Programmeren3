using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuisdierenLibrary
{
    public abstract class Dier
    {
        public int Gewicht { get; set; } = 0;

        public Dier() { }
        public Dier(int gewicht)
        {
            Gewicht = gewicht;
        }

        public abstract string Zeg(bool playSound=false);

        public override string ToString()
        {
            return "(gewicht: " + Gewicht.ToString() + ")";
        }
    }

    public class Koe : Dier
    {
        public string Naam { get; set; } = "Koe";
        public Koe(string naam) : base()
        {
            Naam = naam;
        }
        public override string Zeg(bool playSound=false)
        {
            if (playSound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\HuisdierenLibrary\media\cow.wav");
                player.Play();
            }
            return "Boe";
        }

        public override string ToString()
        {
            return "Koe " + Naam + " " + base.ToString();
        }
    }

    public class Slang : Dier
    {
        public string Naam { get; set; } = "Slang";
        public Slang(string naam) : base()
        {
            Naam = naam;
        }
        public override string Zeg(bool playSound=false)
        {
            return "ssj";
        }

        public override string ToString()
        {
            return "Slang " + Naam + " " + base.ToString();
        }
    }

    public class Varken : Dier
    {
        public string Naam { get; set; } = "Varken";
        public Varken(string naam) : base()
        {
            Naam = naam;
        }
        public override string Zeg(bool playSound=false)
        {
            if (playSound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\HuisdierenLibrary\media\cow.wav");
                player.Play();
            }
            return "groink";
        }

        public override string ToString()
        {
            return "Varken " + Naam + " " + base.ToString();
        }
    }
}
