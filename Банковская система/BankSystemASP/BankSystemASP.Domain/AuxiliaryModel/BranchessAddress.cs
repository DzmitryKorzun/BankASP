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
        public byte IsPreEntry { get; set; }
        public byte IsWorksOnWeekends { get; set; }
        public byte IsForInvalid { get; set; }
        public byte IsHaveWiFi { get; set; }
        public byte IsHaveParking { get; set; }
        public byte IsElectronicQueue { get; set; }
        public string WorkTime { get; set; }
        public string StreetType { get; set; }

        public Addrees[] addrees { get; set; }
        public City[] cities { get; set; }
        public Region[] regions { get; set; }

    }
}
