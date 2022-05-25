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
        private readonly ICustomerRepository userRepository;
        public HomeController(ICustomerRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index() => View();
        public IActionResult About() => View();

    }
}
