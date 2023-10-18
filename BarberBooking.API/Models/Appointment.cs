using System;

namespace BarberBooking.API
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int BarberID { get; set; }
        public int ServiceID { get; set; }
        public Barber Barber { get; set; }
        public Service Service { get; set; }

        public Appointment() { }

        public Appointment(int appointmentID, DateTime appointmentDate, DateTime appointmentTime, int customerID, Customer customer, int barberID, int serviceID, Barber barber, Service service)
        {
            AppointmentID = appointmentID;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            CustomerID = customerID;
            Customer = customer;
            BarberID = barberID;
            ServiceID = serviceID;
            Barber = barber;
            Service = service;
        }
    }
}