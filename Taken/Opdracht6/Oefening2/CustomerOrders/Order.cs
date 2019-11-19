using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerOrders
{
    class Order
    {
        public int OrderId { get; set; }
        public Person Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalCost;
    }
}
