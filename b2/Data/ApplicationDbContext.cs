using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using b2.Models;

namespace b2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<b2.Models.Voiture> Voiture { get; set; } = default!;
        public DbSet<b2.Models.Reparation> Reparation { get; set; } = default!;
        public DbSet<b2.Models.Intervention> Intervention { get; set; } = default!;
    }
}