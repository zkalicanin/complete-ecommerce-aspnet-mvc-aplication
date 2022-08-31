using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinamasController : Controller
    {
        private readonly AppDbContext context;

        public CinamasController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await context.Cinemas.ToListAsync();
            return View();
        }

    }
}
