namespace GreenGo.Models
{
    public class CustomerContent
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ContentId { get; set; }
        public Content Content { get; set; }
    }
}
