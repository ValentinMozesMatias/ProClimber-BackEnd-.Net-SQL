using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProClimberAPI.Data;

namespace ProClimberAPI.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class ProClimberController : Controller
    {
        private readonly DataContext _context;

        public ProClimberController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProClimber>>> GetProClimber() 
        {
            return Ok(await _context.ProClimbers.ToListAsync());
        }
    }
}
