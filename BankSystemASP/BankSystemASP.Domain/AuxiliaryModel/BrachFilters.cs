using BankSystemASP.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.AuxiliaryModel
{
    public class BranchFilters
    {
        public IEnumerable<BranchessAddress> branchessAddresses { get; set; }
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
        public string SortedBy { get; set; }
    }
}
