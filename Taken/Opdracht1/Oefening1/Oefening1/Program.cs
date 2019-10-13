using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get environment variables
            String gebruikersNaam = Environment.UserName;
            String tijd = DateTime.Now.ToShortTimeString();
            String datum = DateTime.Now.ToShortDateString();

            //Display message
            MessageBox.Show($"Hello {gebruikersNaam}. Het is {tijd} op {datum}");
        }
    }
}
