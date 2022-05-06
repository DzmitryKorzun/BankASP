using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankSystemASP.Data.Models;
using BankSystemASP.Data;

namespace BankSystemASP.Controllers
{
    public class UsersController: Controller
    {
        private ApplicationDbContext db;
        public UsersController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult MoneyTransaction()
        {
            return View();
        }

    }
}
