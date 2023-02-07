namespace WebApplication2.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ManagerId { get; set; }
        public string CustomerId { get; set; }
        public string DesignerId { get; set; }

        public virtual User Manager { get; set; } = null!;
        public virtual User Customer { get; set; } = null!;
        public virtual User Designer { get; set; } = null!;
    }
}
