using BikeHub.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BikeHub.Web.DataLayer
{
    public class BikeHubDbContext : DbContext
    {
        public BikeHubDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
