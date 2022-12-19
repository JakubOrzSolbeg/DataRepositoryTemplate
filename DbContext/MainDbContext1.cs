using DataRepository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataRepository.DbContext;

public class MainDbContext1 : DbContextBase
{
    private readonly IConfiguration _configuration;
    public MainDbContext1(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // public DbSet<T> T_sets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.ApplyConfiguration(new EntityTypeConfiguration);
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MainDb"), 
            b => b.MigrationsAssembly(_configuration["MigrationAssembly"]));
    }
}