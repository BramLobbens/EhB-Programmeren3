using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class Form1 : Form
    {
        Stapel<int> MijnStapel { get; set; }
        public Form1()
        {
            InitializeComponent();
            MijnStapel = new Stapel<int>()
            {
                Values = new List<int>()
            };
        }

        // Haal van stapel
        private void Button1_Click(object sender, EventArgs e)
        {
            var value = MijnStapel.Pop();
            textBox1.Text = value != 0 ? value.ToString() : "Stapel is leeg";
            ToonStapel();
        }

        // Voeg aan stapel toe
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MijnStapel.AddtoStapel(int.Parse(textBox1.Text));
                ToonStapel();
            }
        }
        [System.Diagnostics.Conditional("DEBUG")]
        private void ToonStapel()
        {
            string s = "";
            foreach (var num in MijnStapel.Values)
            {
                s += $"{num}" + ";";
            }
            textBox2.Text = s;
        }
    }
}
