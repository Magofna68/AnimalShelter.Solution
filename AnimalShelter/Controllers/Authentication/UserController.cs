using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using System.Threading.Tasks;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public async Task<IActionResult> Authenticate([FromBody]AuthenticateModel model)
    {
      var user = await _userService.Authenticate(model.UserName, model.Password);

      if (user == null)
      {
        return BadRequest(new{message = "Username of Password is incorrect" });
      }
      return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var users = await _userService.GetAll();
      return Ok(users);
    }
  }
}