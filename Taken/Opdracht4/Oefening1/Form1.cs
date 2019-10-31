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
        private const string FontName = "Fira Code";
        private const double MaxFontSize = 50.0f;
        private const double MinFontSize = 8.0f;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Tip: maak je tekst groter en kleiner met Ctrl+L en Ctrl+S";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Only change ForeColor if it does not match the background color;
        private void ChangeForeColor(Color c)
        {
            richTextBox1.ForeColor = richTextBox1.BackColor.Equals(c) ? richTextBox1.ForeColor : c; 
        }

        // Only change BackColor if it does not match the text color;
        private void ChangeBackColor(Color c)
        {
            richTextBox1.BackColor = richTextBox1.ForeColor.Equals(c) ? richTextBox1.BackColor : c;
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColor(Color.Red);
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColor(Color.Green);
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColor(Color.Blue);
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForeColor(Color.Black);
        }

        private void RedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeBackColor(Color.Red);
        }

        private void GreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeBackColor(Color.Green);
        }

        private void BlueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeBackColor(Color.Blue);
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBackColor(Color.White);
        }

        private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Size > MinFontSize)
                richTextBox1.Font = new Font(FontName, richTextBox1.Font.Size * 0.8f);
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FontName, 9.5f);
        }

        private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Size < MaxFontSize)
                richTextBox1.Font = new Font(FontName, richTextBox1.Font.Size * 1.2f);

        }

    }
}
