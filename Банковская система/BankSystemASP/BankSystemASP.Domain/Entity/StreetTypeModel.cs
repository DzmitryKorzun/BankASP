using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class StreetType
    {
        [Key]
        public int IdStreetType { get; set; }
        public string name { get; set; }
        public List<Addrees> addrees { get; set; }
    }
}
