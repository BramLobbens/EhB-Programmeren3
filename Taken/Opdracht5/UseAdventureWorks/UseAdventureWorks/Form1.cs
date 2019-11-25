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
        public string ConnectionString { get; set; }
        public CurrencyLookupForm()
        {
            InitializeComponent();
        }

        /* Get selected country region code item from drop-down list.
         * Use selection to retrieve currency name of country region code. 'Not available' if no such result.
         */
        private void countrySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected CountryRegionCode value
            var selection = countrySelection.SelectedValue.ToString();

            using (var connection = new SqlConnection(ConnectionString))
            {
                var sb = new StringBuilder();
                var adapter = new SqlDataAdapter();

                try
                {
                    // Select latest currency name in use of country as multiple results are possible.
                    var command = new SqlCommand("select top(1) currency.Name" +
                                                " from Sales.CountryRegionCurrency as region" +
                                                " join Sales.Currency as currency" +
                                                " on region.CurrencyCode = currency.CurrencyCode" +
                                                " where CountryRegionCode = @CountryRegionCode" +
                                                " order by region.ModifiedDate",
                                                connection);
                    // Parameterise the lookup
                    command.Parameters.AddWithValue("@CountryRegionCode", selection);

                    // Open connection
                    connection.Open();

                    // Read SelectQuery results and append to StringBuilder object
                    using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            sb.AppendLine(reader[0].ToString());
                        }
                    }

                    // Set the result in the form's textbox if found, else 'Not available'
                    currencyField.Text = (sb.Length > 0) ? sb.ToString() : "Not available";
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        /* Load region code and names of countries in the form's drop-down list.
         */
        private void CurrencyLookupForm_Load(object sender, EventArgs e)
        {

            using (var connection = new SqlConnection(ConnectionString))
            { 
                try
                {
                    // Select region code and names of all countries in CountryRegion
                    var query = "select CountryRegionCode, Name from Person.CountryRegion";
                    var adapter = new SqlDataAdapter(query, connection);

                    // Open connection
                    connection.Open();

                    // Fill results in dataset
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "ResultTable");

                    // Display the country names in the drop-down list. Set the region code as their value.
                    countrySelection.DisplayMember = "Name";
                    countrySelection.ValueMember = "CountryRegionCode";
                    countrySelection.DataSource = dataSet.Tables["ResultTable"];
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}
