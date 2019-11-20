using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomerOrders
{
    public partial class Form1 : Form
    {
        private List<Order> currentDisplayed;
        public Form1()
        {
            InitializeComponent();
            currentDisplayed = new List<Order>();
        }

        // The data.
        private Order[] AllOrders;

        // Make some data.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create some Persons.
            Person person1 = new Person { Name="Alice" };
            Person person2 = new Person { Name="Ben" };
            Person person3 = new Person { Name="Carla" };

            // Create some Orders.
            AllOrders = new Order[]
            {
                new Order { OrderId=1, Customer = person1, OrderItems = new List<OrderItem>()
                    {
                        new OrderItem() { Description="Pencil", Quantity=12, UnitPrice=0.10m},
                        new OrderItem() { Description="Pen", Quantity=3, UnitPrice=1.75m},
                        new OrderItem() { Description="Notepad", Quantity=6, UnitPrice=1.15m},
                    } },
                new Order { OrderId=2, Customer=person2, OrderItems=new List<OrderItem>()
                    {
                        new OrderItem() { Description="Paper", Quantity=1, UnitPrice=5.49m},
                        new OrderItem() { Description="Toner", Quantity=3, UnitPrice=17.50m},
                    } },
                new Order { OrderId=3, Customer=person3, OrderItems=new List<OrderItem>()
                    {
                        new OrderItem() { Description="Cookies", Quantity=2, UnitPrice=0.49m},
                        new OrderItem() { Description="Pen", Quantity=3, UnitPrice=1.75m},
                        new OrderItem() { Description="Pencil", Quantity=6, UnitPrice=0.10m},
                    } },
                new Order { OrderId=4, Customer=person1, OrderItems=new List<OrderItem>()
                    {
                        new OrderItem() { Description="Cookies", Quantity=12, UnitPrice=0.49m},
                        new OrderItem() { Description="Paper", Quantity=1, UnitPrice=5.49m},
                        new OrderItem() { Description="Toner", Quantity=1, UnitPrice=17.50m},
                    } },
                new Order { OrderId=5, Customer=person2, OrderItems=new List<OrderItem>()
                    {
                        new OrderItem() { Description="Cookies", Quantity=4, UnitPrice=0.49m},
                    } },
                new Order { OrderId=6, Customer=person2, OrderItems=new List<OrderItem>()
                    {
                        new OrderItem() { Description="Pen", Quantity=1, UnitPrice=1.75m},
                        new OrderItem() { Description="Notepad", Quantity=1, UnitPrice=1.15m},
                    } },
            };

            // Set each order's TotalCost.
            foreach(var order in AllOrders)
            {
                decimal totCost = 0;
                foreach(var item in order.OrderItems)
                {
                    totCost += item.UnitPrice * item.Quantity;
                }
                order.TotalCost = totCost;
            }
        }

        // Display all orders' IDs, customers, and total costs.
        private void allOrdersButton_Click(object sender, EventArgs e)
        {
            // Clear output
            resultListBox.Items.Clear();
            // Clear current displayed list
            currentDisplayed.Clear();

            AllOrders.ToList().ForEach(a => currentDisplayed.Add(a));
            foreach (var order in currentDisplayed)
            {
                resultListBox.Items.Add($"{order.OrderId}\t{order.Customer.Name}\t{order.TotalCost:C2}");
            }
        }

        // Display all orders' IDs, customers, and total costs
        // ordered by costs.
        private void withCostsButton_Click(object sender, EventArgs e)
        {
            // Clear output
            resultListBox.Items.Clear();

            var results = from order in currentDisplayed
                          orderby order.TotalCost descending
                          select order;

            foreach (var order in results)
            {
                resultListBox.Items.Add($"{order.OrderId}\t{order.Customer.Name}\t{order.TotalCost:C2}");
            }
        }

        // List orders placed by the selected customer.
        private void customerButton_Click(object sender, EventArgs e)
        {
            // Clear output
            resultListBox.Items.Clear();

            var results = from order in AllOrders
                          where order.Customer.Name.Equals(customerComboBox.SelectedItem)
                          select order;

            currentDisplayed = results.ToList();

            foreach (var order in results)
            {
                resultListBox.Items.Add($"{order.OrderId}\t{order.Customer.Name}\t{order.TotalCost:C2}");
            }
        }

        // Display items with costs greater than the entered value.
        private void greaterThanButton_Click(object sender, EventArgs e)
        {
            // Clear output
            resultListBox.Items.Clear();

            // Clear currency formatting
            var numText = greaterThanTextBox.Text;
            var cultureInfo = new System.Globalization.CultureInfo("nl-BE");

            var regex = new Regex(@"([\d,.]+)");
            var match = regex.Match(numText);
            numText = match.Groups[1].Value;

            // Parse to decimal
            decimal num = 0;
            try
            {
                num = Decimal.Parse(numText, cultureInfo);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }

            var results = from order in currentDisplayed
                          where order.TotalCost > num
                          select order;

            if (!results.Any())
            {
                resultListBox.Items.Add("No result");
            }
            else
            {
                foreach (var order in results)
                {
                    resultListBox.Items.Add($"{order.OrderId}\t{order.Customer.Name}\t{order.TotalCost:C2}");
                }
            }
            
        }
    }
}
