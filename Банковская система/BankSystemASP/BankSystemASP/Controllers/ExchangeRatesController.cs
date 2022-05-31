using Microsoft.AspNetCore.Mvc;

namespace BankSystemASP.Controllers
{
    public class ExchangeRatesController : Controller
    {
        public IActionResult ExchangeRatesView()
        {
            return View();
        }
    }
}
