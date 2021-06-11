using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pet>()
        .HasData(
          new Pet { AnimalId = 1, Type = "Cat", Name = "Tiffany", Gender = "Female", Breed = "RagaMuffin", Age = 3, Description = "Long Haired; White/Orangish in color" }
        );
    }
  }
}