using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppInsurance.Models;

namespace WebAppInsurance.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppInsurance.Models.Insurance> Insurance { get; set; } = default!;
        public DbSet<WebAppInsurance.Models.Insured> Insured { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;
    }
}