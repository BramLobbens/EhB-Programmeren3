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
        // Add the user input to each stapel and display all elements of each stapel.
        private void button1_Click(object sender, EventArgs e)
        {
            // Intstapel
            if (int_Field.Text != "")
            {
                try
                {
                    IntStapel.Toevoegen(int.Parse(int_Field.Text));
                    intStapel_Field.Text = IntStapel.ToString();
                    int_Field.Clear();
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.StackTrace);
                    MessageBox.Show("Number should be an integer.", err.GetType().ToString());
                }
                catch (OverflowException err)
                {
                    Console.WriteLine(err.StackTrace);
                    MessageBox.Show($"Number should be no bigger than {int.MaxValue}", err.GetType().ToString());
                }
            }

            // Stringstapel
            if (string_Field.Text != "")
            {
                StringStapel.Toevoegen(string_Field.Text);
                stringStapel_Field.Text = StringStapel.ToString();
                string_Field.Clear();
            }

            // Bookstapel
            if (title_Field.Text != "" || author_Field.Text != "" || date_Field.Text != "")
            {
                (string title, string author, string date) bookStrings = (title_Field.Text, author_Field.Text, date_Field.Text);
                var book = new Book(bookStrings.title, bookStrings.author, bookStrings.date);
                BookStapel.Toevoegen(book);
                bookStapel_Field.Text = BookStapel.ToString();
                title_Field.Clear();
                author_Field.Clear();
                date_Field.Clear();
            }
        }

        // Haal van stapel
        // Pop the first elements from each stapel. Display the popped element and display the remaining elements.
        private void button2_Click(object sender, EventArgs e)
        {
            {
                var result = IntStapel.Verwijderen();
                intStapel_ItemField.Text = result != 0 ? result.ToString() : "Stapel is leeg";
                intStapel_Field.Text = IntStapel.ToString();
            }
            
            {
                var result = StringStapel.Verwijderen();
                stringStapel_ItemField.Text = result ?? "Stapel is leeg";
                stringStapel_Field.Text = StringStapel.ToString();
            }

            {
                var result = BookStapel.Verwijderen();
                bookStapel_ItemField.Text = result != null ? result.ToString() : "Stapel is leeg";
                bookStapel_Field.Text = BookStapel.ToString();
            }
        }
    }
}
