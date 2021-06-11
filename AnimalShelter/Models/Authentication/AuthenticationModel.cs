using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class AuthenticateModel
  {
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
  }
}