using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace API.Controllers
{
    public class ActivitiesController: BaseApiController
    {
        private readonly DataContext _context;
      public ActivitiesController(DataContext context)
      {
            _context = context;
        
      }
    [HttpGet]
    //Asynic return task always
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        List<Activity> activities = await _context.Activities.ToListAsync();
        return activities;
    } 

    [HttpGet("{id}")] // api/activities/id
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
         return await _context.Activities.FindAsync(id);
    }

}
}