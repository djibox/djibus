using Djibus.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Djibus.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<TypeDemande> TypeDemandes { get; set; }
        public DbSet<Demande> Demandes { get; set; }
        public DbSet<OrgUnit> OrgUnits { get; set; }
    }
}