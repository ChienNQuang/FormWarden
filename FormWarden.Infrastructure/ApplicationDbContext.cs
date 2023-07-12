using FormWarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FormWarden.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        DbSet<User> Users => Set<User>();
        DbSet<Identity> Identities => Set<Identity>();
        DbSet<Category> Categories => Set<Category>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = GetConnectionString() ?? throw new ArgumentNullException("ConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        private string? GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var connectionString = config.GetConnectionString("Default");
            return connectionString;
        }

        //
    }
}
