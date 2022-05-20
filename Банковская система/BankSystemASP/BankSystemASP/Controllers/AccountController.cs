using BankSystemASP.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankSystemASP.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() => View();

        //[HttpPost]
        //public async Task<IActionResult> Register(User model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }
        //}


    }


}
