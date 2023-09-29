using Microsoft.EntityFrameworkCore;

namespace OfficersApp.Models
{
    public class OfficerDbContext:DbContext
    {

        public OfficerDbContext(DbContextOptions<OfficerDbContext> options):base(options) 
           
        {
            
        }

        public DbSet<Officer> Officers { get; set; }
    }
}
