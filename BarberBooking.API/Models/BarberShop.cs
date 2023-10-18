using System;

namespace BarberBooking.API
{
   public class BarberShop
    {
        public int BarberShopID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Barber> Barbers { get; set; }
        public List<Product> Products { get; set; }

        // Construtor básico
        public BarberShop() { }

        // Construtor com todas as propriedades
        public BarberShop(int barberShopID, string name, string address, List<Barber> barbers, List<Product> products)
        {
            BarberShopID = barberShopID;
            Name = name;
            Address = address;
            Barbers = barbers;
            Products = products;
        }
    }
}
