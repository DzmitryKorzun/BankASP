using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using BankSystemASP.DAL;
using BankSystemASP.DAL.Interfaces;

namespace BankSystemASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;
        public HomeController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index() => View();

    }
}
