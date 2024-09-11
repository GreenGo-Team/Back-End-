namespace GreenGo.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime ScanDate { get; set; }
        public bool RecyclabilityStatus { get; set; }
        //FK
        public int CustomerId { get; set; }
        //Navigation Propertey
        public Customer? Customer { get; set; }
        public ICollection<Process> Processes { get; set; }

    }
}
