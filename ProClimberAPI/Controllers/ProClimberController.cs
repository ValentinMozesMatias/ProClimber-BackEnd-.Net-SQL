using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProClimberAPI.Data;
using ProClimberAPI.Models;

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

        [HttpPost]
        public async Task<ActionResult<List<ProClimber>>> AddProClimber([FromBody] ProClimber proClimberRequest)
        {
            _context.Add(proClimberRequest);
            await _context.SaveChangesAsync();
            return Ok(await _context.ProClimbers.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<ProClimber>>> UpdateProClimber([FromQuery] ProClimber proClimberRequest)
        {
            var updateProClimber = await _context.ProClimbers.FindAsync(proClimberRequest.Id);
            if (updateProClimber == null)
            {
                return BadRequest("Id was not found");
            }
            else if (updateProClimber != null)
            {
                updateProClimber.Name = proClimberRequest.Name;
                updateProClimber.FirstName = proClimberRequest.FirstName;
                updateProClimber.LastName = proClimberRequest.LastName;
                updateProClimber.Place = proClimberRequest.Place;
            }

            await _context.SaveChangesAsync();
            return Ok(await _context.ProClimbers.ToListAsync());
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<ProClimber>>> DeleteProClimber([FromQuery] int id)
        {
            var deleteProClimber = await _context.ProClimbers.FindAsync(id);
            if (deleteProClimber == null) 
            {
                return BadRequest("Id does not exist");
            }
            else if (deleteProClimber != null)
            {
               _context.ProClimbers.Remove(deleteProClimber);
            }
            await _context.SaveChangesAsync();
            return Ok(await _context.ProClimbers.ToListAsync());
        }
            
    }
}
