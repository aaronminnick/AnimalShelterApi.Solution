using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Class> Classes {get; set;}
    public DbSet<ClassClass> ClassClass {get; set;}

    public AnimalShelterContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}