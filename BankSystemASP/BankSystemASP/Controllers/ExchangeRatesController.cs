using BankSystemASP.Domain.AuxiliaryModel;
using BankSystemASP.Domain.Entity;
using BankSystemASP.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystemASP.Controllers
{
    public class ExchangeRatesController : Controller
    {
        private readonly IExchangeRatesService exchangeRatesService;
        private readonly IBranchServise branchServise;
        private readonly ICurrencyService currencyService;
        private readonly IAddressService addressService;
        private const int defaultIdCurrency = 1;
        public ExchangeRatesController(IExchangeRatesService exchangeRatesService, IBranchServise branchServise,
            ICurrencyService currencyService, IAddressService addressService)
        {
            this.exchangeRatesService = exchangeRatesService;
            this.branchServise = branchServise;
            this.currencyService = currencyService;
            this.addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> ExchangeRatesView()
        {
            ExchangeViewModel exchangeViewModel = new ExchangeViewModel();
            var allCurrecies = currencyService.GetAllCurrency();
            
            exchangeViewModel.AllCurrency = allCurrecies.Result.Data;
            var allBranches = branchServise.GetAllBranches();
            foreach (var branch in allBranches.Result.Data)
            {
                branch.Addrees = addressService.GetAddressByID(branch.IdAddress).Result.Data;
                exchangeViewModel.adreesDictionary.Add(branch.Namber, branchServise.GetStringAddress(branch).Result.Data);
            }

            return View(exchangeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ExchangeRatesView(ExchangeViewModel exchangeViewModel)
        {
            var result = await branchServise.GetBranchByNumber(Convert.ToInt32(exchangeViewModel.SelectedBranchNumber));
            var address = await addressService.GetAddressByID(result.Data.IdAddress);
            result.Data.Addrees = address.Data;
            var sellectedAdress = branchServise.GetStringAddress(result.Data).Result.Data;
            var exchancheRates = await exchangeRatesService.GetExchangeRatesByNumberOfBranch(Convert.ToInt32(exchangeViewModel.SelectedBranchNumber), exchangeViewModel.IdSelectedCurrency);
            exchangeViewModel.Exchange = exchancheRates.Data;
            exchangeViewModel.Branch = result.Data;
            exchangeViewModel.selectedBranchAdressReturn = sellectedAdress;
            var allCurrecies = currencyService.GetAllCurrency();
            exchangeViewModel.AllCurrency = allCurrecies.Result.Data;
            var allBranches = branchServise.GetAllBranches();
            foreach (var branch in allBranches.Result.Data)
            {
                branch.Addrees = addressService.GetAddressByID(branch.IdAddress).Result.Data;
                exchangeViewModel.adreesDictionary.Add(branch.Namber, branchServise.GetStringAddress(branch).Result.Data);
            }


            var currencyName = await currencyService.GetNameCurrencyById(exchangeViewModel.IdSelectedCurrency);
            exchangeViewModel.SelectedCurrencyName = currencyName.Data;/// Изменить
            return View(exchangeViewModel);
        }
    }
}