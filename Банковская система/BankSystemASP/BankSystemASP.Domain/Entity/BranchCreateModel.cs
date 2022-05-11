using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public  class Branch
    {
        [Key]
        public int IdBranch { get; set; }
        public int Namber { get; set; }
        public int IdAddress { get; set; }
        public byte IsPreEntry { get; set; }
        public byte IsWorksOnWeekends { get; set; }
        public byte IsForInvalid { get; set; }
        public byte IsHaveWiFi { get; set; }
        public byte IsHaveParking { get; set; }
        public byte IsElectronicQueue { get; set; }
    }
}
