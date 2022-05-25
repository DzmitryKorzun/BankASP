using BankSystemASP.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankSystemASP.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchServise branchService;

        public BranchController(IBranchServise branchService)
        {
            this.branchService = branchService;
        }

        [HttpGet]
        public async Task<IActionResult> Branches()
        {
           // var response2 = await branchService.Create(new Domain.Entity.Branch(2, 654743, 1, 1, 0, 1, 1, 0, 1, "Пн-Пт 8.00 - 17.00"));
            var response = await branchService.GetAllBranches();
            if (response.Status == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            else
            {
                return RedirectToAction(nameof(Error));
            }
        }

        public  IActionResult Error() => View();
       
        
    }
}
