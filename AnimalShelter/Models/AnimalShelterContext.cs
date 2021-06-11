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

          new Pet { PetId = 3, Type = "Cat", Name = "Mango", Gender = "Female", Breed = "Maine Coon", Age = 1.2, Description = "Massive fat cat; looking to be ~25lbs when fully grown" },

          new Pet { PetId = 4, Type = "Dog", Name = "Taco", Gender = "Female", Breed = "Chiwawa", Age = 8.5, Description = "Mi quero Taco Bell" },

          new Pet { PetId = 5, Type = "Dog", Name = "Sebashian", Gender = "Male", Breed = "Great Dane", Age = 4, Description = "Long Haired; White/Orangish in color" },

          new Pet { PetId = 6, Type = "Dog", Name = "Doug", Gender = "Male", Breed = "Golden Retriever", Age = 12, Description = "Golden in color; great with kids" },

          new Pet { PetId = 7, Type = "Cat", Name = "Meow", Gender = "Female", Breed = "Calico", Age = 3.75, Description = "Long Haired; very fiesty; loves tuna treats" }
        );
    }
  }
}