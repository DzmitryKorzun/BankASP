using BankSystemASP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.AuxiliaryModel
{
    public class BranchessAddress
    {
        public int IdBranch { get; set; }
        public int Namber { get; set; }
        public int IdAddress { get; set; }
        public string AddreesStreet { get; set; }
        public string AddreesCity { get; set; }
        public string AddreesRegion { get; set; }
        public string Building { get; set; }
        public bool IsPreEntry { get; set; }
        public bool IsWorksOnWeekends { get; set; }
        public bool IsForInvalid { get; set; }
        public bool IsHaveWiFi { get; set; }
        public bool IsHaveParking { get; set; }
        public bool IsElectronicQueue { get; set; }
        public string WorkTime { get; set; }
        public string StreetType { get; set; }

        public List<PhoneNumber> phoneNumbers { get; set; }

        public Addrees[] addrees { get; set; }
        public City[] cities { get; set; }
        public Region[] regions { get; set; }

    }
}
