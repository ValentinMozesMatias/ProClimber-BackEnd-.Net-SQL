using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProClimberAPI.Data;
using ProClimberAPI.Interface;
using ProClimberAPI.Models;

namespace ProClimberAPI.Service
{
    //public class ProClimberServices : IProClimberService
    //{
    //    public readonly DataContext _context;
    //    public ProClimberServices(DataContext dataContext)
    //    {
    //        _context = dataContext;
    //    }
    //    public async Task<List<ProClimber>> GetProClimbersAsync()
    //    {
    //        var proClimbers = await _context.ProClimbers.ToListAsync();
    //        return proClimbers;
    //    }

    //    public async Task<string> AddProClimbersAsync(ProClimberRequest proClimberRequest)
    //    {
    //        var newProClimber = new ProClimber
    //        {
    //            Name = proClimberRequest.Name,
    //            FirstName = proClimberRequest.FirstName,
    //            LastName = proClimberRequest.LastName,
    //            Place = proClimberRequest.Place,
    //        };

    //        _context.ProClimbers.Add(newProClimber);
    //        await _context.SaveChangesAsync();
    //        return "Added";
    //    }
    //}
}
