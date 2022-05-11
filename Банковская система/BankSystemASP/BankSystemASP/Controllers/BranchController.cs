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
            var response = await branchService.GetAllBranches();
            if (response.Status == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        
    }
}
