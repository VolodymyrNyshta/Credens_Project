using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }  

    }
}
