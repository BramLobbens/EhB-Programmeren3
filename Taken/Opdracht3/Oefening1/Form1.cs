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
            stapel.Toevoegen(5);
        }
    }
}
