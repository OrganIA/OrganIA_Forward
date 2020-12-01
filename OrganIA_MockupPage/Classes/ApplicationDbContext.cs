using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OrganIA_MockupPage.Classes
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        //public DbSet<Donor> Donors { get; set; }
        //public DbSet<Receiver> Receivers { get; set; }
    }
}