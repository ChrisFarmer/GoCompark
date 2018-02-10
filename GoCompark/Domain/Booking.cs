using System;
using Domain.Enums;

namespace Domain
{
    public class Booking
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IncludesMorning { get; set; }

        public bool IncludesAfternoon { get; set; }
    }
}