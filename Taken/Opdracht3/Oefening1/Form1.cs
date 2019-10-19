using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Foo();
        }

        void Foo()
        {
            var stapel = new Stapel<int>();
            stapel.Toevoegen(1);
            stapel.Toevoegen(2);
            stapel.Toevoegen(3);

            Console.WriteLine($"origineel: {stapel}");

            var copy = stapel.Copy();
            Console.WriteLine($"copy: {copy}");
            copy.Verwijderen();

            Console.WriteLine($"origineel: {stapel}");
            Console.WriteLine($"copy: {copy}");
        }
    }
}
