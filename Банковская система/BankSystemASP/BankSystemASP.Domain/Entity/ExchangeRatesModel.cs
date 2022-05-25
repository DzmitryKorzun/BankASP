using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class ExchangeRates
    {
        [Key]
        public int IdExchangeRates { get; set; }
        [ForeignKey("IdBranch")]
        public int IdBranch { get; set; }
        [ForeignKey("IdCurrency")]
        public int IdCurrency { get; set; }
        public float NumberOfUnits { get; set; }
        public float BuyRate { get; set; }
        public float SalesRate { get; set; }
        public DateTime Date { get; set; }

        public Branch Branch { get; set; }
        public Currency Currency { get; set; }  
    }
}
