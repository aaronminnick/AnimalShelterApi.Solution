using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals {get; set;}

    public AnimalShelterContext(DbContextOptions options) : base(options) {}
  }
}