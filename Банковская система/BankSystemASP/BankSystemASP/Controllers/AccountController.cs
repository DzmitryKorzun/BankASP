using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankSystemASP.Helpers;
using BankSystemASP.Service.Interfaces;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BankSystemASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomerService customerService;
        public AccountController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult CustomerAccount()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                var res = await customerService.Registration(model);
                if (res.Status == Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(res.Data));
                    return RedirectToAction("CustomerAccount", "Account");
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Customer customerLog = new Customer() { Email = model.EmailPerson, HASHED_PASSWORD = model.Password };
            var response = await customerService.Login(customerLog);
            if (response.Status == Domain.Enum.StatusCode.OK)
            {
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(response.Data));

                return RedirectToAction("CustomerAccount", "Account", model);
            }
            ModelState.AddModelError("", response.Description);
            return RedirectToAction("CustomerAccount", "Account", model); 
        }


    }
}
