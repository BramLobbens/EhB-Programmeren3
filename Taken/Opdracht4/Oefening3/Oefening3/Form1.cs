using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public List<string> symbols;
        private const string symbol = " # ";
        public Form1()
        {
            InitializeComponent();
            symbols = new List<string>();
        }

        private void Draw()
        {
            textBox1.Clear();
            // De dimensie van de vierkante matrix is een functie van een bovenafronding van de vierkantswortel van het aantal elementen.
            // 1 -> 1
            // 2 -> 2
            // ...
            // 4 -> 2
            // 5 -> 3
            // ...
            // 9 -> 3
            // 10 -> 4
            // ...
            // 16 -> 4
            // etc.
            var n = Math.Ceiling(Math.Sqrt(symbols.Count));

            var num = 1;
            var count = symbols.Count;
            var sb = new StringBuilder();
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    if (count > 0)
                    {
                        sb.Append($"  {num++:0000}  ");
                        count--;
                    }
                }
                sb.Append(Environment.NewLine);
            }

            textBox1.Text = sb.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            symbols.Add(symbol);
            Draw();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (symbols.Count > 0)
            {
                symbols.RemoveAt(symbols.Count - 1);
            }
            Draw();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            symbols.Clear();
            Draw();
        }
    }
}
