using LCUP.Models;
using LCUP.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace LCUP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationFormDB> PersonalData { get; set; }
        public DbSet<ApplicationFormDB2>Family_Background { get; set; }
        public DbSet<ApplicationFormDB3> Emergency_Contact { get; set; }

        public DbSet<ReportCardDB> Report_Card { get; set; }
     
        }
    }
