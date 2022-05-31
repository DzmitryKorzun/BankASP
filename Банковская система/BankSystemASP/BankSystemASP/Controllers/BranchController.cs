using BankSystemASP.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankSystemASP.Domain.AuxiliaryModel;
using System.Collections.Generic;
using System.Linq;

namespace BankSystemASP.Controllers
{
    public class BranchController : Controller
    {

        private readonly IBranchServise branchService;
        private readonly IAddressService addressService;
        private List<BranchessAddress> branchessAddresses = new List<BranchessAddress>();

        public BranchController(IBranchServise branchService, IAddressService addressService)
        {
            this.branchService = branchService;
            this.addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> Branches()
        {
            var responseBranch = await branchService.GetBranchesWithAdress();
            if (responseBranch.Status == Domain.Enum.StatusCode.OK)
            {
                if (branchessAddresses.Count == 0) branchessAddresses.AddRange(responseBranch.Data);
                return View(responseBranch.Data);
            }
            else
            {
                return RedirectToAction(nameof(Error));
            }
        }

        [HttpPost]
        public async Task<IActionResult> FiltrationBranches(BranchessAddress branchessAddress)
        {
            byte isWorksOnWeekends = branchessAddress.IsWorksOnWeekends;
            byte isElectronicQueue = branchessAddress.IsElectronicQueue;
            byte isForInvalid = branchessAddress.IsForInvalid;
            byte isHaveWiFi = branchessAddress.IsHaveWiFi;
            byte isPreEntry = branchessAddress.IsPreEntry;


            return View(branchessAddresses.Where(p => p.IsPreEntry == isPreEntry && p.IsHaveWiFi == isHaveWiFi));

        }

        public  IActionResult Error() => View();
       
        
    }
}
