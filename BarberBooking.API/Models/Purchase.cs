using System;

namespace BarberBooking.API
{
 public class Purchase
    {
        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public List<PurchaseItem> PurchaseItems { get; set; }

        public Purchase() { }

        public Purchase(int purchaseID, DateTime purchaseDate, int customerID, Customer customer, List<PurchaseItem> purchaseItems)
        {
            PurchaseID = purchaseID;
            PurchaseDate = purchaseDate;
            CustomerID = customerID;
            Customer = customer;
            PurchaseItems = purchaseItems;
        }
    }
}