using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace UseAdventureWorks
{
    public partial class CurrencyLookupForm : Form
    {
        
        public CurrencyLookupForm()
        {
            InitializeComponent();
        }

        // TODO: get user selection
        private void countrySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set selection and lookup and set currency in the textbox output
        }

        private void CurrencyLookupForm_Load(object sender, EventArgs e)
        {

            using (var con = new SqlConnection(UseAdventureWorks.Properties.Settings.Default.AdventureWorks2016CTP3ConnectionString))
            { 
                try
                {
                    var query = "select Name from Person.CountryRegion";
                    var da = new SqlDataAdapter(query, con);

                    con.Open();

                    var ds = new DataSet();
                    da.Fill(ds, "ResultTable");

                    countrySelection.DisplayMember = "Name";
                    countrySelection.ValueMember = "Name";
                    countrySelection.DataSource = ds.Tables["ResultTable"];
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}
