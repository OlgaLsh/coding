using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public virtual List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public Customer Customer { get; set; }
    }

}
