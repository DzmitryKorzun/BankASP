using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("IdBankAccount_Sender")]
        public int IdBankAccount_Sender { get; set; }
        [ForeignKey("IdBankAccount_Receiver")]
        public int IdBankAccount_Receiver { get; set; }
        public DateTime TransactionDate { get; set; }
        public float Summa { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
