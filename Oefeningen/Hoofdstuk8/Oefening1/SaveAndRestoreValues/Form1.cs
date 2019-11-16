using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveAndRestoreValues
{
    public partial class Form1 : Form
    {
        private string fileName = @"Values.txt";
        private List<TextBox> textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            // is added in reverse order, so add Reverse()
            textBoxes = Controls.OfType<TextBox>().ToList();
            textBoxes.Reverse();
            Console.WriteLine(textBoxes.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int lineNumber = 0;

            foreach (string line in File.ReadLines(fileName))
            {
                InputLine(line, lineNumber);
                lineNumber++;
            }
        }

        private void InputLine(string line, int pos)
        {
            textBoxes.ElementAt(pos).Text = line;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var lines = new StringBuilder();
            foreach (var textBox in textBoxes)
            {
                lines.Append(textBox.Text + "\n");
            }
            using (StreamWriter writer = File.CreateText(fileName))
            {
                writer.Write(lines);
            }
        }
    }
}
