using System.ComponentModel.DataAnnotations;
using BankSystemASP.Domain.Enum;

namespace BankSystemASP.Domain.Entity
{
    public class User
    {
        private const int MaxLineLen = 50;
        private const int MinLineLen = 3;
        private const int MaxAge = 110;
        private const int MinAge = 1;

        private const string errorMaxLenString = "Длинна не должна превышать 50 символов";
        private const string errorMinLenString = "Длинна не должна быть меньше 3 символов";
        private const string nameEmptyErrorString = "Введите имя";
        private const string surnameEmptyErrorString = "Введите фамилию";
        private const string patronymicEmptyErrorString = "Введите отчество";
        private const string ageEmptyErrorString = "Введите возраст";
        private const string ageNumberErrorString = "Неверное значение возраста";
        private const string passwordEmptyErrorString = "Введите пароль";


        public int Id { get; set; }

        [Required(ErrorMessage = surnameEmptyErrorString)]
    //    [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
    //    [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string SurName { get; set; }

        [Required(ErrorMessage = nameEmptyErrorString)]
      //  [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
     //   [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string Name { get; set; }

        [Required(ErrorMessage = patronymicEmptyErrorString)]
      //  [MaxLength(MaxLineLen, ErrorMessage = errorMaxLenString)]
   //     [MinLength(MinLineLen, ErrorMessage = errorMinLenString)]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = ageEmptyErrorString)]
//[MaxLength(MaxAge, ErrorMessage = ageNumberErrorString)]
   //     [MinLength(MinAge, ErrorMessage = ageNumberErrorString)]
        public int Age { get; set; }

        [Required(ErrorMessage = passwordEmptyErrorString)]
        public string Password { get; set; }
        [Required(ErrorMessage = passwordEmptyErrorString)]
        public string Email { get; set; }


    }
}
