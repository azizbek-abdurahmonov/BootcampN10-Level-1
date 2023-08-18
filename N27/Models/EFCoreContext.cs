using Microsoft.EntityFrameworkCore;
namespace N27.Models;

public class EFCoreContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Database=postgres;Password=postgres;");

    public DbSet<PersonDB> Person { get; set; }
}