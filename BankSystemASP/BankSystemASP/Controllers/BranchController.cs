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
        private readonly ICityService cityService;
        private List<BranchessAddress> branchessAddresses = new List<BranchessAddress>();

        public BranchController(IBranchServise branchService, IAddressService addressService, ICityService cityService)
        {
            this.branchService = branchService;
            this.addressService = addressService;
            this.cityService = cityService;
        }

        [HttpGet]
        public async Task<IActionResult> Branches()
        {
            var responseBranch = await branchService.GetBranchesWithAdress();
            BranchFilters filters = new BranchFilters() { branchessAddresses = responseBranch.Data };
            filters.branchessAddresses.ToList()[0].cities = null;
            if (responseBranch.Status == Domain.Enum.StatusCode.OK)
            {
                if (branchessAddresses.Count == 0) branchessAddresses.AddRange(responseBranch.Data);
                return View(filters);
            }
            else
            {
                return RedirectToAction(nameof(Error));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Branches(BranchFilters branchFilters)
        {
            bool isWorksOnWeekends = branchFilters.IsWorksOnWeekends;
            bool isElectronicQueue = branchFilters.IsElectronicQueue;
            bool isForInvalid = branchFilters.IsForInvalid;
            bool isHaveWiFi = branchFilters.IsHaveWiFi;
            bool isPreEntry = branchFilters.IsPreEntry;
            string AddreesRegion = branchFilters.AddreesRegion;
            var responseBranch = await branchService.GetBranchesWithAdress();
            var filtr = responseBranch.Data.ToList().Where(x => x.IsPreEntry == isPreEntry &&
                x.IsForInvalid == isForInvalid && x.IsHaveWiFi == isHaveWiFi && x.IsWorksOnWeekends == isWorksOnWeekends &&
                x.IsElectronicQueue == isElectronicQueue && x.AddreesRegion == AddreesRegion);
            if (filtr.ToList().Count != 0)
            {
                filtr.ToList()[0].cities = cityService.GetCityByRegion(AddreesRegion).Result.Data.ToArray();
            }

            var sortedFilter = filtr.ToList();
            if (branchFilters.SortedBy == "up")
            {
                sortedFilter = (from p in sortedFilter orderby p.Namber select p).ToList();
            }
            else
            {
                sortedFilter = (from p in sortedFilter orderby p.Namber descending select p ).ToList();
            }
            

            BranchFilters branchFiltersRes = new BranchFilters() { branchessAddresses = sortedFilter };            
            return View(branchFiltersRes);
        }

        [HttpPost]
        public async Task<IActionResult> SelectFilling(BranchFilters branchFilters)
        {

            return View(branchFilters);
        }


        public  IActionResult Error() => View();
    }
}
