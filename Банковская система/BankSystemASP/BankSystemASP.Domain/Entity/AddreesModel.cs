using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BankSystemASP.Domain.Entity
{
    public class Addrees
    {
        public Addrees(int idAddress, int idCity, string street, string building, string index, int idStreetType)
        {
            this.idAddress = idAddress;
            this.idCity = idCity;
            this.street = street;
            this.building = building;
            this.index = index;
            this.idStreetType = idStreetType;
        }


        [Key]
        public int idAddress { get; set; }
        [ForeignKey("idCity")]
        public int idCity { get; set; }
        public string street { get; set; }
        public City city { get; set; }
        public string building { get; set; }
        public string index { get; set; }
        [ForeignKey("idStreetType")]
        public int idStreetType { get; set; }
        public StreetType streetType { get; set; }
        public List<Branch> branches { get; set; }
    }
}
