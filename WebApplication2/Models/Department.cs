namespace WebApplication2.Models
{
    public class Department
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
