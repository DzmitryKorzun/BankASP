using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public  class Branch
    {
        public Branch(int IdBranch, int Namber, int IdAddress, byte IsPreEntry, byte IsWorksOnWeekends, byte IsForInvalid, byte IsHaveWiFi, byte IsHaveParking, byte IsElectronicQueue, string WorkTime)
        {
            this.IdBranch = IdBranch;
            this.Namber = Namber;
            this.IdAddress = IdAddress;
            this.IsPreEntry = IsPreEntry;
            this.IsWorksOnWeekends = IsWorksOnWeekends;
            this.IsForInvalid = IsForInvalid;
            this.IsHaveWiFi = IsHaveWiFi;
            this.IsHaveParking = IsHaveParking;
            this.IsElectronicQueue = IsElectronicQueue;
            this.WorkTime = WorkTime;
        }


        [Key]
        public int IdBranch { get; set; }
        public int Namber { get; set; }
        [ForeignKey("IdAddress")]
        public int IdAddress { get; set; }
        public Addrees Addrees { get; set; }
        public byte IsPreEntry { get; set; }
        public byte IsWorksOnWeekends { get; set; }
        public byte IsForInvalid { get; set; }
        public byte IsHaveWiFi { get; set; }
        public byte IsHaveParking { get; set; }
        public byte IsElectronicQueue { get; set; }
        public string WorkTime  { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
        public List<ExchangeRates> ExchangeRates { get; set; }

        public List<BankAccount> BankAccounts { get; set; }
    }
}
