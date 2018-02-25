namespace Domain
{
    public class ParkingSpace
    {
        public int Id { get; set; }

        public Employee Owner { get; set; }

        public int Number { get; set; }
    }
}