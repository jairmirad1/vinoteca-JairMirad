using Microsoft.AspNetCore.Mvc;
using vinoteca_JairMirad.Models;
using vinoteca_JairMirad.Services;

namespace vinoteca_JairMirad.Controllers { 

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
    private readonly InventoryService _service;

    public UserController(InventoryService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        _service.RegisterUser(user);
        return CreatedAtAction(nameof(RegisterUser), user);
    }
    }
}
