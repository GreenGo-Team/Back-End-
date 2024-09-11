using DataAnnotationsExtensions;

namespace GreenGo.Models
{
    public class Customer
    {
        public int Customer_ID { get; set; }
        public string Fname { get; set;}
        public string Lname { get; set; }
        
        public string Password { get; set; }
        [Email]
        public string Email { get; set; }
        public int RewardPoints { get; set; }
        public ICollection<Reward>? Rewards { get; set; }
        public ICollection<Items>? Items { get; set; }
        public ICollection<CustomerContent>? CustomerContents { get; set; }
        public ICollection<Process> Processes { get; set; }
    }
}
