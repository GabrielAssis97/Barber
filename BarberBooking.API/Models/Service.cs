using System;

namespace BarberBooking.API
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int BarberID { get; set; }
        public Barber Barber { get; set; }

        public Service() { }

        public Service(int serviceID, string name, decimal price, int barberID, Barber barber)
        {
            ServiceID = serviceID;
            Name = name;
            Price = price;
            BarberID = barberID;
            Barber = barber;
        }
    }
}
