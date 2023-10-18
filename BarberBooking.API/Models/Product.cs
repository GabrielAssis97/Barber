using System;

namespace BarberBooking.API
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public int BarberShopID { get; set; }
        public BarberShop BarberShop { get; set; }

        public Product() { }

        public Product(int productID, string name, decimal price, int stock, int barberShopID, BarberShop barberShop)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Stock = stock;
            BarberShopID = barberShopID;
            BarberShop = barberShop;
        }
    }
}