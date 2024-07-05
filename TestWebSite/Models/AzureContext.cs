using Microsoft.EntityFrameworkCore;


namespace TestWebSite.Models
{
    public class AzureContext : DbContext
    {
        public DbSet<Newsletter> Newsletter { get; set; }
        public AzureContext(DbContextOptions<AzureContext> options) : base(options)
        { 

        }
    }
}
