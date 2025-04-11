using System;

namespace MuseumTourManagement. Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int ExpeditionID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan TimeSlot { get; set; }
    }



    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Exhibition
    {
        public int ExhibitionID { get; set; }
        public string Name { get; set; }
        public int TicketsAvailable { get; set; }
    }


}
