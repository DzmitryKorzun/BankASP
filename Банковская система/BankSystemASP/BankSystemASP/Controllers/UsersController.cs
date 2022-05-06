using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankSystemASP.Controllers
{
    public class UsersController: Controller
    {


        public IActionResult MoneyTransaction()
        {
            return View();
        }

    }
}
