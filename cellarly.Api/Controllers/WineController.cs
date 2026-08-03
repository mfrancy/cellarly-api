using cellarly.Api.Models;
using Microsoft.AspNetCore.Mvc;



namespace cellarly.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        public List<Wine> Wines = new List<Wine>();

        [HttpPost]
        public void CreateWine([FromBody] Wine wine)
        {
            Wines.Add(wine);
        }
    }
}
