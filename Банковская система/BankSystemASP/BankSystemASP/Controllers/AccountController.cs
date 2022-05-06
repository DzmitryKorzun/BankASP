using BankSystemASP.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankSystemASP.Controllers
{    
    public class AccountController : Controller
    {
        public AccountController()
        {

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
