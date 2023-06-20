using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {  
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context=context;
            
        }
        public IActionResult Index()
        {
            List<eTickets.Models.Actor> data = _context.Actors.ToList();
            return View(data);
        }
    }
}
