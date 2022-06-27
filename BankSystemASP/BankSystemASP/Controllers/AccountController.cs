using BankSystemASP.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankSystemASP.Service.Interfaces;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using BankSystemASP.Domain.AuxiliaryModel;

namespace BankSystemASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICustomerService customerService;
        private readonly ICurrencyService currencyService;
        public AccountController(ICustomerService customerService, ICurrencyService currencyService)
        {
            this.customerService = customerService;
            this.currencyService = currencyService;
        }
        [HttpGet]
        public async Task<IActionResult> CustomerAccount()
        {
            var model = new UserAccountModel();
            var allCurrency = await currencyService.GetAllCurrency();
            model.Currencies = allCurrency.Data;         


            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CustomerAccount(UserAccountModel userAccountModel)
        {
            var allCurrency = await currencyService.GetAllCurrency();
            userAccountModel.Currencies = allCurrency.Data;
            
            return View(userAccountModel);
        }


        [HttpGet]
        public async Task<IActionResult> AdminPanel()
        {
            var model = new AdminViewModel();
            model.AllUsersEmails = customerService.GetUsersEmails().Result.Data;
            return View(model);
        }

        [HttpPost]
        public IActionResult AdminPanel(AdminViewModel adminViewModel)
        {
            int selectedId = adminViewModel.SelectedIDBankAccount;
            return View(adminViewModel);
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
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(response.Data));
                if (response.Data.RoleClaimType == "Admin")
                {
                    return RedirectToAction("CustomerAccount", "Account", model);
                }
                if (model.EmailPerson == "admin@gmail.com")
                {
                    return RedirectToAction("adminPanel", "Account", model);
                }
                return RedirectToAction("CustomerAccount", "Account");
            }
            return RedirectToAction("Index", "Home", model); 
        }
    }
}
