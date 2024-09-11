namespace GreenGo.Models
{
    public class Reward
    {
        public int Reward_ID { get; set; }
        public string? Description { get; set; }
        public int PointsRequied { get; set; }
        //FK
        public int CustomerId { get; set; }
        //Navigation Propertey
        public Customer? Customer { get; set; }
    }
}
