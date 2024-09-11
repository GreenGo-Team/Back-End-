namespace GreenGo.Models
{
    public class Center
    {
        public int Center_ID { get; set; }
        public string? Name { get; set; }
        public string Location { get; set; }
        public ICollection<Process> Processes { get; set; }

    }
}
