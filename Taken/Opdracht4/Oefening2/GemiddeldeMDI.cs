using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class GemiddeldeMDI : Form
    {
        private ObservableCollection<int> Waardes { get; set; }
        public GemiddeldeMDI()
        {
            InitializeComponent();
            Waardes = new ObservableCollection<int>();
            Waardes.CollectionChanged += UpdateDisplayedItems;
        }

        private void UpdateDisplayedItems(object sender, NotifyCollectionChangedEventArgs e)
        {
            listBox1.Items.Clear(); // Items moeten gecleared worden wanneer Waardes worden gecleared.
            foreach (var waarde in Waardes)
            {
                listBox1.Items.Add(waarde);
            }
            // Bereken het nieuwe gemiddelde tot op twee cijfers
            textBox1.Text = (Waardes.Count > 0) ? $"{Waardes.Average():0.##}" : "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var form = new DialoogVenster())
            {
                // Verkrijg de gekozen dialoogvenster waarde en verkrijg de waarde als de gebruiker voor OK heeft gekozen
                DialogResult dialogResult = form.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    int num;
                    if (int.TryParse(form.Waarde, out num))
                    {
                        Waardes.Add(num);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Waardes.Clear();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klik op de knop 'Nieuw getal' om een waarde in te geven.", "Help");
        }
    }
}
