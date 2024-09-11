namespace GreenGo.Models
{
    public class Process
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ItemsId { get; set; }
        public Items Items { get; set; }
        public int CenterId { get; set; }
        public Center Center { get; set; }
        public int ContainerId { get; set; }
        public Container Container { get; set; }
        public int Process_ID { get; set; }
        public DateTime Recycling_Date { get; set; }
    }
}
