using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuisdierenLibrary;

namespace HuisdierenForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AssignToButtons();
        }

        private void AssignToButtons()
        {
            button1.Text = "Laat horen";

            //Maak objecten aan van de HuisdierenLibrary. Geef elke radiobutton een referentie naar dit object.
            Koe koe = new Koe("Maggie");
            Slang slang = new Slang("Sir Hiss");
            Varken varken = new Varken("Hamm");

            radioButton1.Tag = koe;
            radioButton1.Name = koe.Naam;
            radioButton1.Text = koe.ToString();

            radioButton2.Tag = slang;
            radioButton2.Name = slang.Naam;
            radioButton2.Text = slang.ToString();

            radioButton3.Tag = varken;
            radioButton3.Name = varken.Naam;
            radioButton3.Text = varken.ToString();
        }

        //Call ShowMessage voor de geselecteerde RadioButton
        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ShowMessage(checkedButton.Tag);
        }

        //Toon een MessageBox die de method Zeg oproept voor het object waarnaar de RadioButton refereert.
        private static void ShowMessage(Object o)
        {
            if (o is Koe k)
            {
                MessageBox.Show($"{ k.Zeg(true)}", k.Naam);
            }
            else if (o is Slang s)
            {
                MessageBox.Show($"{ s.Zeg()}", s.Naam);
            }
            else if (o is Varken v)
            {
                MessageBox.Show($"{ v.Zeg(true)}", v.Naam);
            }
        }
    }
}
