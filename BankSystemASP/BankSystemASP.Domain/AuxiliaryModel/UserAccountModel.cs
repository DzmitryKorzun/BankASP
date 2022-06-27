using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.AuxiliaryModel
{
    public class UserAccountModel
    {
        public string UserEmail { get; set; }
        public List<BankAccount>  UserBankAccounts {get; set;}
        public List<Currency> Currencies {get; set;}
        public string FullName { get; set; }
        public int IdSelectedCurrency { get; set; }
        public string CardNumberSender { get; set; }
        public string InputCVV { get; set; }
        public string ValidatySender { get; set; }
        public string CardNumberRecipient { get; set; }
        public string ValidatyRecipient { get; set; }
        public float Balance { get; set; }
        public float TransferAmount { get; set; }
    }
}
