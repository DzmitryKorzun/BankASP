using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemASP.Domain.Entity
{
    public class City
    {
        [Key]
        public int idCity { get; set; }
        public string name { get; set; }
        public int idRegion { get; set; }
        [ForeignKey("idRegion")]
        public Region Region { get; set; }
        public List<Addrees> addrees { get; set; }
    }
}
