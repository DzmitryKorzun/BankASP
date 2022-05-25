using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemASP.Domain.Entity
{
    public class Customer
    {
        private const int MaxLineLen = 50;
        private const int MinLineLen = 3;

        private const string errorMaxLenString = "Длинна не должна превышать 50 символов";
        private const string errorMinLenString = "Длинна не должна быть меньше 3 символов";
        private const string nameEmptyErrorString = "Введите имя";
        private const string surnameEmptyErrorString = "Введите фамилию";
        private const string patronymicEmptyErrorString = "Введите отчество";
        private const string ageNumberErrorString = "Неверное значение возраста";
        private const string passwordEmptyErrorString = "Введите пароль";

        [Key]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = surnameEmptyErrorString)]
        [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
        [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string SurName { get; set; }

        [Required(ErrorMessage = nameEmptyErrorString)]
        [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
        [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string Name { get; set; }

        [Required(ErrorMessage = patronymicEmptyErrorString)]
        [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
        [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = passwordEmptyErrorString)]
        public string HASHED_PASSWORD { get; set; }
        [Required(ErrorMessage = passwordEmptyErrorString)]
        public string Email { get; set; }

        public string Salt { get; set; }

        [ForeignKey("IdRole")]
        public int IdRole { get; set; }


        public Role Role { get; set; }
        public List<СustomerBankAccounts> СustomerBankAccounts { get; set; }
    }
}
