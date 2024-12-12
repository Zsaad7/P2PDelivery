namespace PTPDelivery.Server.Models.Carrier
{
    public class Trip
    {
        public int Id { get; set; }
        public string CurrentCity { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime date { get; set; }
        public string WayTravel { get; set; } = string.Empty;
        public string LuggageCapacity { get; set; } = string.Empty;



    }
}
