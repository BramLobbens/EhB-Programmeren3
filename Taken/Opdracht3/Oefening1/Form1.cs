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
        public Stapel<int> IntStapel { get; set; }
        public Stapel<string> StringStapel { get; set; }
        public Stapel<Book> BookStapel { get; set; }
        public Form1()
        {
            InitializeComponent();
            IntStapel = new Stapel<int>();
            StringStapel = new Stapel<string>();
            BookStapel = new Stapel<Book>();
        }

        // Zet op stapel
        private void button1_Click(object sender, EventArgs e)
        {
            // Intstapel
            if (textBox1.Text != "")
            {
                try
                {
                    IntStapel.Toevoegen(int.Parse(textBox1.Text));
                    textBox3.Text = IntStapel.ToString();
                    textBox1.Clear();
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.StackTrace);
                    MessageBox.Show("Please provide an integer.");
                }
            }

            // Stringstapel
            if (textBox4.Text != "")
            {
                StringStapel.Toevoegen(textBox4.Text);
                textBox10.Text = StringStapel.ToString();
                textBox4.Clear();
            }

            // Bookstapel
            if (textBox6.Text != "" || textBox8.Text != "" || textBox9.Text != "")
            {
                (string title, string author, string date) bookStrings = (textBox6.Text, textBox8.Text, textBox9.Text);
                var book = new Book(bookStrings.title, bookStrings.author, bookStrings.date);
                BookStapel.Toevoegen(book);
                textBox11.Text = BookStapel.ToString();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
        }

        // Haal van stapel
        private void button2_Click(object sender, EventArgs e)
        {
            if (IntStapel.Count != 0)
            {
                textBox2.Text = IntStapel.Verwijderen().ToString();
                textBox3.Text = IntStapel.ToString();
            }
            if (StringStapel.Count != 0)
            {
                textBox5.Text = StringStapel.Verwijderen();
                textBox10.Text = StringStapel.ToString();
            }
            if (BookStapel.Count != 0)
            {
                textBox7.Text = BookStapel.Verwijderen().ToString();
                textBox11.Text = BookStapel.ToString();
            }
        }
    }
}
