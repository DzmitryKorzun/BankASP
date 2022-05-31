using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemASP.Domain.Entity
{
    public class Region
    {
        public Region(int IdRegion, string name)
        {
            this.IdRegion = IdRegion;
            this.name = name;
        }

        [Key]
        public int IdRegion { get; set; }
        public string name { get; set; }

        public List<City> cities { get; set; }
    }
}
