using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PTPDelivery.Server.Models.Carrier
{
    public class Carrier
    {
        [Key]
        public int IdCarrier { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        //peut avoir plusieurs docuemtns 
        public ICollection<Document>? Documents { get; set; } = new HashSet<Document>();
        public ICollection<Review>? Reviews { get; set; } = new List<Review>();
        // chhal mn Item delivra 
        public ICollection<Item>? Items { get; set; } = new List<Item>();
        // chhal mn payements daze lih ca reste confidential 
        public ICollection<Payment>? payments { get; set; } = new List<Payment>();
        // chhal aando mn trip 
        public ICollection<Trip>? trips { get; set; } = new List<Trip>();

    }
}
