using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberID { get; set; }
        [ForeignKey("IdBranch")]
        public int IdBranch { get; set; }
        public Branch Branch { get; set; }
        public string number { get; set; }

    }
}
