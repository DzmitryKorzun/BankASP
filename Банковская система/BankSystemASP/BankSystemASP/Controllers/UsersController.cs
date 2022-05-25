using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankSystemASP.DAL.Interfaces;
using BankSystemASP.Service.Interfaces;

namespace BankSystemASP.Controllers
{
    public class UsersController: Controller
    {
        private readonly ICustomerService userService;

        public UsersController(ICustomerService userService)
        {
            this.userService = userService;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUsers()
        //{
        //  //  var response = await userService.GetAllUsers();
        //    //if (response.Status == Domain.Enum.StatusCode.OK)
        //    //{
        //    //    return View(response.Data);
        //    //}
        //    //else
        //    //{
        //    //    return RedirectToAction("Error");
        //    //}            
        //}
    }
}
