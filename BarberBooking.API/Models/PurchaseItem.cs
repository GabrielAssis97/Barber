using System;

namespace BarberBooking.API
{
    public class PurchaseItem
    {
        public int PurchaseItemID { get; set; }
        public int Quantity { get; set; }

        public int PurchaseID { get; set; }
        public Purchase Purchase { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public PurchaseItem() { }

        public PurchaseItem(int purchaseItemID, int quantity, int purchaseID, Purchase purchase, int productID, Product product)
        {
            PurchaseItemID = purchaseItemID;
            Quantity = quantity;
            PurchaseID = purchaseID;
            Purchase = purchase;
            ProductID = productID;
            Product = product;
        }
    }
}