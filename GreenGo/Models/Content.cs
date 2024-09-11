namespace GreenGo.Models
{
    public class Content
    {
        public int Content_ID { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set;}
        public ICollection<CustomerContent>? CustomerContents { get; set; }
    }
}
