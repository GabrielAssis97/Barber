using System;

 public class Barber
    {
        public int BarberID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        
        public int BarberShopID { get; set; }
        public BarberShop BarberShop { get; set; }

        public List<Service> Services { get; set; }

        public Barber() { }

        public Barber(int barberID, string name, string specialization, int barberShopID, BarberShop barberShop, List<Service> services)
        {
            BarberID = barberID;
            Name = name;
            Specialization = specialization;
            BarberShopID = barberShopID;
            BarberShop = barberShop;
            Services = services;
        }
    }