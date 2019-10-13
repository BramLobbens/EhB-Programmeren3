using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Format Window
            this.Text = "IsItBigger";
            this.Width = 500;
            this.Height = 200;

            //Create Layout
            TableLayoutPanel panel = new TableLayoutPanel
            {
                AutoSize = true,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(panel);

            //Add Labels
            CreateLabels(panel);
        }

        private void CreateLabels(Panel panel)
        {
            int x = 12345;
            int y = 54321;
            int n = 22222;
            int m = 33333;

            Label label1 = new Label()
            {
                Text = $"{x} * {y} = {x * y}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            Label label2 = new Label()
            {
                Text = $"{n} * {m} = {n * m}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            Label label3 = new Label()
            {
                Text = $"{x} * {y} > {n} * {m} = {(x * y) > (n * m)}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
        }
    }
}
