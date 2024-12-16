using System.ComponentModel.DataAnnotations;

namespace PTPDelivery.Server.Models
{
    public class Review
    {
        [Key]
        public int IdReview { get; set; }
        public string DescriptionReview { get; set; } = string.Empty;
    }
}
