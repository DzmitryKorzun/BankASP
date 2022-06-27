using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.AuxiliaryModel
{
    public class ExchangeViewModel
    {
        public Dictionary<int, string> adreesDictionary = new Dictionary<int, string>();
        public string SelectedBranchNumber { get; set; }
        public List<Currency> AllCurrency { get; set; }

        public Branch Branch { get; set; }
        public string selectedBranchAdressReturn { get; set; }
        public ExchangeRates Exchange { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public int IdSelectedCurrency { get; set; }
        public string SelectedCurrencyName { get; set; }

    }

    public class CoursePresentationTableModel
    {
        public Currency Currency { get; set; }
        public Branch Branch { get; set; }
        public ExchangeRates ExchangeRates { get; set; }
    }



}
