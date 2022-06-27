using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class BankAccount
    {
        [Key]
        public int IdBankAccount { get; set; }
        [ForeignKey("IdCurrency")]
        public int IdCurrency { get; set; }
        public float Balance { get; set; }
        public string CardNumber { get; set; }
        public string Validity { get; set; }
        [ForeignKey("IdBranch")]
        public int IdBranch { get; set; }

        public Currency Currency { get; set; }  
        public Branch Branch { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Transaction> Transactions2 { get; set; }
        public List<СustomerBankAccounts> СustomerBankAccounts { get; set; }
    }
}
