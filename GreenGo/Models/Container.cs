namespace GreenGo.Models
{
    public class Container
    {
        public int Container_ID { get; set; }
        public string? Type { get; set;}
        public ICollection<Process> Processes { get; set; }

    }
}
