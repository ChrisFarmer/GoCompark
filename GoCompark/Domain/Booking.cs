using System;

namespace Domain
{
    public class Booking
    {
        public Booking()
        {
            var tomorrow = DateTime.Now.AddDays(1).Date;
            From = new TimeSlot { Date = tomorrow };
            To = new TimeSlot { Date = tomorrow };
        }

        public int Id { get; set; }

        public Employee Booker { get; set; }

        public ParkingSpace ParkingSpace { get; set; }

        public TimeSlot From { get; set; }

        public TimeSlot To { get; set; }
    }
}