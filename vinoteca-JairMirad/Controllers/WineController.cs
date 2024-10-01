using Microsoft.AspNetCore.Mvc;
using vinoteca_JairMirad.Models;
using vinoteca_JairMirad.Services;

namespace vinoteca_JairMirad.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class WineController : ControllerBase
    {
        private readonly InventoryService _service;

        public WineController(InventoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Wine>> GetWines() => Ok(_service.GetAllWines());

        [HttpGet("{name}")]
        public ActionResult<Wine> GetWine(string name)
        {
            var wine = _service.GetWineByName(name);
            return wine != null ? Ok(wine) : NotFound();
        }

        [HttpPost]
        public IActionResult AddWine(Wine wine)
        {
            _service.AddWine(wine);
            return CreatedAtAction(nameof(GetWine), new { name = wine.Name }, wine);
        }

        [HttpPut("{id}/stock")]
        public IActionResult UpdateStock(int id, [FromBody] int amount)
        {
            _service.UpdateWineStock(id, amount);
            return NoContent();
        }
    }
}
