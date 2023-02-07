using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;

namespace WebApplication2.Models
{
    public class User : IdentityUser
    {
        public string? FirstrName { get; set; }

        public virtual Contact Contact { get; set; } 
        public virtual Department? Department { get; set; }

        public virtual ICollection<Project> ManagerProjects { get; } = new List<Project>();
        public virtual ICollection<Project> CustomerProjects { get; } = new List<Project>();
        public virtual ICollection<Project> DesignerProjects { get; } = new List<Project>();
    }
}
