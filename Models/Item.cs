using System.ComponentModel.DataAnnotations;

namespace PTPDelivery.Server.Models
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string value { get; set; } = string.Empty; 
        public string PickupLocation { get; set; } = string.Empty;
        public string DeliveryLocation { get; set; } = string.Empty; 
        public string Deadline { get; set; } = string.Empty;
        public string DeliveryPriority { get; set; } = string.Empty;    
        public string SpecialInstructions { get; set; } = string.Empty;

    }
}
