using System.ComponentModel.DataAnnotations;

namespace AnimalShelter
{
  public class Pet
  {
    public int PetId { get; set; }
    [Required]
    [StringLength(3)]
    public string Type { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Gender { get; set; }
    public string Breed { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public string Description { get; set; }
  }
}
