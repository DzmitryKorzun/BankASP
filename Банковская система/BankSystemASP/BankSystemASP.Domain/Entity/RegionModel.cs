using System.ComponentModel.DataAnnotations;

namespace BankSystemASP.Domain.Entity
{
    public class Region
    {
        [Key]
        public int IdRegion { get; set; }
        
        public string name { get; set; }

    }
}
