using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter
{
  [Route("api/[controller]")]
  [ApiController]
  public class PetController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public PetController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> Get(string type, string name, string gender, string breed, int age, string description)
    {
      var query = _db.Pets.AsQueryable();

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Pet>> Post(Pet pet)
    {
      _db.Pets.Add(pet);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPet), new {id = pet.PetId}, pet);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
      var pet = await _db.Pets.FindAsync(id);

      if (pet == null)
      {
        return NotFound();
      }
      return pet;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Pet pet)
    {
      if (id != pet.PetId)
      {
        return BadRequest();
      }
      _db.Entry(pet).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PetExists(id))
        {
          return NotFound();
        }
        else{
          throw;
        }
      }
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePet(int id)
    {
      var pet = await _db.Pets.FindAsync(id);
      if (pet == null)
      {
        return NotFound();
      }

      _db.Pets.Remove(pet);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool PetExists(int id)
    {
      return _db.Pets.Any(e => e.PetId == id);
    }
  }
}