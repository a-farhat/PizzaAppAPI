using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAppAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public double Price { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
    }
}
