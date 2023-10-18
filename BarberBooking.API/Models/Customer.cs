using System;
using System.Collections.Generic;

namespace BarberBooking.API.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<Purchase> Purchases { get; set; }

        public Customer() { }

        public Customer(int customerID, string name, string phone, List<Purchase> purchases)
        {
            CustomerID = customerID;
            Name = name;
            Phone = phone;
            Purchases = purchases;
        }
    }
}
