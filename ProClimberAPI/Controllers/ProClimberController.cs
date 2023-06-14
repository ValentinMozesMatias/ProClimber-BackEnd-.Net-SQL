using Microsoft.AspNetCore.Mvc;

namespace ProClimberAPI.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class ProClimberController : Controller
    {
        [HttpGet]
        public async Task<List<ProClimber>> GetProClimber() 
        {
            return new List<ProClimber>
            {
                new ProClimber
                {
                    Name = "Magnus Mitbo",
                    FirstName = "Magnus",
                    LastName = "Mitbo",
                    Place = "Norway"
                }
            };
        }
    }
}
