using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class СustomerBankAccounts
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("IdBankAccount")]
        public int IdBankAccount { get; set; }
        [ForeignKey("IdBankAccount")]
        public int IdCustomer { get; set; }

        public BankAccount BankAccount { get; set; }
        public Customer Customer { get; set; }

    }
}
