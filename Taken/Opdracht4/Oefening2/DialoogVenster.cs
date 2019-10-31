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
    public partial class DialoogVenster : Form
    {
        public string Waarde { get; set; }
        public DialoogVenster()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Waarde = waardeField.Text;
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void waardeField_Hover(object sender, EventArgs e)
        {
            var textbox = (TextBox) sender;
            var VisibleTime = 1000;
            var tooltip = new ToolTip();
            tooltip.Show("Voer een geheel getal in", textbox, 0, -20, VisibleTime);
        }
    }
}
