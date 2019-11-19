using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerOrders
{
    class OrderItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
