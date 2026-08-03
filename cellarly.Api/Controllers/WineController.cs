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
        public void CreateWine([FromBody] Wine wine)
        {
            Wines.Add(wine);
        }

        [HttpGet]
        public IEnumerable<Wine> GetAllWines()
        {
            return Wines;
        }

        [HttpGet("{id}")]
        public IActionResult GetWine(int id)
        {
            var wine = Wines.FirstOrDefault(w => w.id == id);

            if (wine == null)
            {
                return NotFound(id);
            }

            return Ok(wine);
        }
    }
}
