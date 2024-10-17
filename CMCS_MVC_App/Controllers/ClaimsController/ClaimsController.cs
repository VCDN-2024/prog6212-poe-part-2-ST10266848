using Microsoft.AspNetCore.Mvc;
using CMCS_MVC_App.Models;
using CMCS_MVC_App.Data;
using Microsoft.EntityFrameworkCore;

namespace CMCS_MVC_App.Controllers.ClaimsController
{
    public class ClaimsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ClaimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //This essentially serves as the index view for Lecturers
        //to view the claims they have submitted throughout the year
        public async Task<IActionResult> LecturerClaim()
        {
            //var appDbContext = _context.Claims.Include(p => p.User);
            //return View(await appDbContext.ToListAsync());
            return View(_context.Claims);
        }



    }
}
