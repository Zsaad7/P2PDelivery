namespace PTPDelivery.Server.Models.Carrier
{
    public class Document
    {
        public int IdDocument { get; set; }
        public string Type { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
    }
}
