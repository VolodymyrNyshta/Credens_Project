using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebApplication2.Models
{
    public class MyDBContext : IdentityDbContext<User>
    {
       public MyDBContext(DbContextOptions<MyDBContext> option) : base(option) { }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

         

            builder.ApplyConfiguration(new MyConfig());

            builder.Entity<Project>().HasOne(d => d.Manager).WithMany(p => p.ManagerProjects)
                   .HasForeignKey(d => d.ManagerId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Manager")
                   .OnDelete(DeleteBehavior.Restrict);

           builder.Entity<Project>().HasOne(d => d.Customer).WithMany(p => p.CustomerProjects)
                        .HasForeignKey(d => d.CustomerId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Customer")
                        .OnDelete(DeleteBehavior.Restrict);

          builder.Entity<Project>().HasOne(d => d.Designer).WithMany(p => p.DesignerProjects)
             .HasForeignKey(d => d.DesignerId)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_Designer")
             .OnDelete(DeleteBehavior.Restrict);

        }


        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Contact> Contacts { get; set; }

    }

    public class MyConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstrName).HasMaxLength(255);

    }
    }
}
