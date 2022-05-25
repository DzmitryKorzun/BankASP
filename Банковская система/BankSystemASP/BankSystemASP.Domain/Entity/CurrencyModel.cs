using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public class Currency
    {
        [Key]
        public int IdCurrency { get; set; }
        public string Name { get; set; }
        public string CurrencySign { get; set; } 
        public List<ExchangeRates> ExchangeRates { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}
