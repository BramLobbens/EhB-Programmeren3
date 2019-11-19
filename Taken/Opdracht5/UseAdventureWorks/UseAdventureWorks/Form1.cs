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
        private string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
        
        public CurrencyLookupForm()
        {
            InitializeComponent();
        }

        // TODO: populate countrySelection with rows from datatable
        // DataReader

        // TODO: get user selection
        private void countrySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set selection and lookup and set currency in the textbox output
        }

        private SqlConnection GetDbConnection()
        {
            ConnectionString = UseAdventureWorks.Properties.Settings.Default.AdventureWorks2016CTP3ConnectionString;
            return new SqlConnection(_connectionString);
        }

        // TO-DO read data with ADO.net (no use of ORM like entity)
        // DataReader
    }
}
