using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankSystemASP.Data.Models;
using BankSystemASP.Data;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace BankSystemASP.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index() => View(await db.Users.ToListAsync());

        [HttpGet]
        public IActionResult Registration() => View();
        [HttpPost]
        public async Task<IActionResult> Registration(User model)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }

        public IActionResult BranchOffices() => View();

    }
}
