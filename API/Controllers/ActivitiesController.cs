
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController 
    {   
        private readonly DataContext _context;
        
        public ActivitiesController (DataContext context){
            _context = context;
         
        }

        [HttpGet] // api/activities for get requests

        public async Task<ActionResult<List<Activity>>> getAtctivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] // it will use id for getting specific activity // api/activities/id

        public async Task <ActionResult<Activity>> GetActivity (Guid id){
            return await _context.Activities.FindAsync(id);
        }
        
    }
}