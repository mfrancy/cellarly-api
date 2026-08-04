using cellarly.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;



namespace cellarly.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        public static List<Wine> Wines = new List<Wine>();

        [HttpPost]
        public IActionResult CreateWine([FromBody] Wine wine)
        {
            if (wine == null)
            {
                return BadRequest();
            }
            wine.Id = wine.Id++;
            Wines.Add(wine);
            return CreatedAtAction(nameof(GetWine), new { id = wine.Id }, wine);
        }

        [HttpGet]
        public IEnumerable<Wine> GetAllWines([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            return Wines.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetWine(int id)
        {
            var wine = Wines.FirstOrDefault(wine => wine.Id == id);

            if (wine == null)
            {
                return NotFound(id);
            }

            return Ok(wine);
        }
    }
}
