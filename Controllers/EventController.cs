using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RegisterApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly DatabaseContext _db;

        public EventController(DatabaseContext db)
        {
            _db = db;
        }
        // GET: api/event
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }

        [HttpPost]
        public async Task<IActionResult> Add(Event eventObj)  // using event identifier will throw error
        {
            await _db.Events.AddAsync(eventObj);
            await _db.SaveChangesAsync();
            return Json(eventObj);
        }
    }
}