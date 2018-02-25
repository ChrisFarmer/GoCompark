namespace Domain
{
    public class ParkingSpaceAvailability
    {
        public int Id { get; set; }

        public ParkingSpace ParkingSpace { get; set; }

        public TimeSlot From { get; set; }

        public TimeSlot To { get; set; }
    }
}