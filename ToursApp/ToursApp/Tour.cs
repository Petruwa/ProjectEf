namespace ToursApp
{
    internal class Tour
    {
        internal object Types;

        public string Name { get; set; }
        public int TicketCount { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}