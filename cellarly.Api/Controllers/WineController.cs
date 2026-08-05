using cellarly.Api.Data;
using cellarly.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;



namespace cellarly.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WineController : ControllerBase
{

    private WineContext _context;
    
    public WineController(WineContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateWine([FromBody] Wine wine)
    {
        if (wine == null)
        {
            return BadRequest();
        }

        _context.Wines.Add(wine);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetWine), new { id = wine.Id }, wine);
    }

    [HttpGet]
    public IEnumerable<Wine> GetAllWines([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        return _context.Wines.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    [HttpGet("{id}")]
    public IActionResult GetWine(int id)
    {
        var wine = _context.Wines.FirstOrDefault(wine => wine.Id == id);

        if (wine == null)
        {
            return NotFound(id);
        }

        return Ok(wine);
    }
}
