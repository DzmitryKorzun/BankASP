using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public class LoginViewModel
    {
        [Required]
        public int Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
