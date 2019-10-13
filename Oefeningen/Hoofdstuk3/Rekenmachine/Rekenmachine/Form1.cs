using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RekenmachineLibrary;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Calculator Calc { get; set; }
        ClickListener Listener { get; set; }
        public Form1()
        {
            InitializeComponent();
            Calc = new Calculator();
            Listener = new ClickListener(Calc, inputX, inputY, output);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Listener.HandleEvent(sender);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Listener.HandleEvent(sender);
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Listener.HandleEvent(sender);
        }

        private void div_Click(object sender, EventArgs e)
        {
            Listener.HandleEvent(sender);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Listener.HandleEvent(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
