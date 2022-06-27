using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.AuxiliaryModel
{
    public class AdminViewModel
    {
        public int SelectedIDBankAccount { get; set; }
        public Dictionary<int, string> AllUsersEmails { get; set; }
        public List<AdminBankAccountView> AdminBankAccountViews { get; set; }
        public List<AdminTrasactionView> AdminTrasactionViews { get; set; }
    }

    public class AdminBankAccountView
    {
        public string BankAccountNamber { get; set; }
        public string Owner { get; set;}
    }

    public class AdminTrasactionView
    {
        public string SenderAccountNamber { get; set; }
        public string BeneficiaryAccountNamber { get; set; }
        public float Summa { get; set; }
        public string CurrencyName { get; set; }
        public DateTime DateTrasaction { get; set; }
    }


}
