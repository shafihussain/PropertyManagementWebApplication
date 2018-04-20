using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace prjREMAX.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> Types { get; set; }
        public DbSet<PropertyStatus> Statuses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}