using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BankSystemASP.Helpers
{
    public class InitDataBase
    {
        public InitDataBase(ModelBuilder mb)
        {
            this.mb = mb;
        }

        private readonly ModelBuilder mb;
        private readonly List<Region> regions = new List<Region>();
        private readonly List<City> cities = new List<City>();


        private readonly Addrees[] addrees = new Addrees[]
        {
                new Addrees(1,1,"Бауманская", "50", "224001", 1),
                new Addrees(2,1,"Боброва", "122", "224001", 1),
                new Addrees(3,1,"Вересковая", "130", "224005", 1),
                new Addrees(4,1,"Вишневая", "14", "224005", 1),
                new Addrees(5,1,"Вольная", "7", "224005", 1),
                new Addrees(6,1,"Генерала Попова", "40", "224001", 1),
                new Addrees(7,1,"Гоздецкого", "6", "224001", 1),
                new Addrees(8,1,"Горького", "116", "224005", 1),
                new Addrees(9,1,"Дворникова", "114", "224007", 1),
                new Addrees(10,1,"Дубровская", "109", "224005", 1),
                new Addrees(11,1,"Зубачева", "67", "224013", 1),
                new Addrees(12,1,"Калинина", "45", "224001", 1),
                new Addrees(13,1,"Карбышева", "122", "224001", 1),
                new Addrees(14,1,"Кирова", "117", "224005", 1),
                new Addrees(15,1,"Кобринская", "56", "224016", 1),
                new Addrees(16,1,"Коммунистическая", "97", "224025", 1),
                new Addrees(17,1,"Кошевого", "63", "224007", 1),
                new Addrees(18,1,"Лактионова", "2", "224001", 1),
                new Addrees(19,1,"Луцкая", "6", "224005", 1),
                new Addrees(20,1,"Машерова", "134", "224001", 1),
                new Addrees(21,1,"Межевая", "7", "224005", 1),
                new Addrees(22,1,"Мичурина", "8", "224005", 1),
                new Addrees(23,1,"Ореховая", "43", "224005", 1),
                new Addrees(24,1,"Папанина", "90", "224007", 1),
                new Addrees(25,1,"Подгородская", "12", "224005", 1),
                new Addrees(26,1,"Сальникова", "1", "224016", 1),
                new Addrees(27,1,"Сказочная", "34", "224025", 1),
                new Addrees(28,1,"Костюшко", "55", "224025", 1),
                new Addrees(29,1,"Железнодорожная", "12", "224025", 1),
                new Addrees(30,1,"Изумрудная", "7", "224007", 1),
                new Addrees(31,1,"Гагарина", "90", "224005", 1),
                new Addrees(32,1,"Космонавтов", "23", "224005", 4),
                new Addrees(33,1,"Шевченко", "12", "224006", 4),
                new Addrees(34,1,"1 Мая", "59", "224006", 3),
                new Addrees(35,1,"2-й Минский", "22", "224003", 3),
                new Addrees(36,1,"Брестских Дивизий", "17", "224007", 3),
                new Addrees(37,1,"Фортечный", "95", "224007", 3),
                new Addrees(38,1,"Сосновый", "11", "224007", 3),
                new Addrees(39,1,"Я. Купалы", "72", "224016", 3),
                new Addrees(40,1,"Донского", "15", "224016", 3),
                new Addrees(41,1,"Энгельса", "32", "224025", 1),
                new Addrees(42,1,"Шоссейная", "79", "224025", 1),
                new Addrees(43,1,"Шафрановая", "30", "224016", 1),
                new Addrees(44,1,"Чернянская", "45", "224005", 1),
                new Addrees(45,1,"Халтурина", "30", "224005", 1),
                new Addrees(46,1,"Фортечная", "123", "224007", 1),
                new Addrees(47,1,"Успенская", "45", "224007", 1),
                new Addrees(48,1,"Тришинская", "95", "224005", 1),
                new Addrees(49,1,"Тереспольская", "55", "224001", 1),
                new Addrees(50,1,"Старозадворская", "31", "224025", 1),
                new Addrees(51,2,"Аксановская", "43", "2100", 1),
                new Addrees(52,2,"Белобородова", "12", "2100", 1),
                new Addrees(53,2,"Воинов-Интернационалистов", "87", "2100", 1),
                new Addrees(54,2,"Генерала Белобородова", "59", "2100", 1),
                new Addrees(55,2,"Гончарная", "95", "2100", 1),
                new Addrees(56,2,"ГСП", "32", "2100", 1),
                new Addrees(57,2,"Жесткова", "33", "2100", 1),
                new Addrees(58,2,"Зеленогурская", "65", "2100", 1),
                new Addrees(59,2,"Калинина", "37", "2100", 1),
                new Addrees(60,2,"Коммунистическия", "12", "2100", 1),
                new Addrees(61,2,"Красного Партизана", "75", "2100", 1),
                new Addrees(62,2,"Лагерно-Набережная", "42", "2100", 1),
                new Addrees(63,2,"Ломоносова", "9", "2100", 1),
                new Addrees(64,2,"Минская", "1", "2100", 1),
                new Addrees(65,2,"Мовзона", "6", "2100", 1),
                new Addrees(66,2,"Народная", "7", "2100", 1),
                new Addrees(67,2,"Орджоникидзе", "7", "2100", 1),
                new Addrees(68,2,"Пионерская", "31", "2100", 1),
                new Addrees(69,2,"Пороховая", "64", "2100", 1),
                new Addrees(70,2,"Промзона Билево", "79", "2100", 1),
                new Addrees(71,2,"Рижская", "10", "2100", 1),
                new Addrees(72,2,"Смоленская", "5", "2100", 1),
                new Addrees(73,2,"Стадионная", "8", "2100", 1),
                new Addrees(74,2,"Транспортная", "1", "2100", 1),
                new Addrees(75,2,"Хоружей", "9", "2100", 1),
                new Addrees(76,2,"Чкалова", "12", "2100", 1),
                new Addrees(77,2,"Швейников", "43", "2100", 1),
                new Addrees(78,2,"Щербакова-Набережная", "22", "2100", 1),
                new Addrees(79,2,"", "", "2100", 2),
                new Addrees(80,2,"", "", "2100", 2),
                new Addrees(81,2,"", "", "2100", 2),
                new Addrees(82,2,"", "", "2100", 2),
                new Addrees(83,2,"", "", "2100", 2),
                new Addrees(84,2,"", "", "2100", 2),
                new Addrees(85,2,"", "", "2100", 2),
                new Addrees(86,2,"", "", "2100", 2),
                new Addrees(87,2,"", "", "2100", 2),
                new Addrees(88,2,"", "", "2100", 2),
                new Addrees(89,2,"", "", "2100", 2),
                new Addrees(90,2,"", "", "2100", 2),
                new Addrees(91,2,"", "", "2100", 2),
                new Addrees(92,2,"", "", "2100", 2),
                new Addrees(93,2,"", "", "2100", 2),
                new Addrees(94,2,"", "", "2100", 2),
                new Addrees(95,2,"", "", "2100", 2),
                new Addrees(96,2,"", "", "2100", 2),
                new Addrees(97,2,"", "", "2100", 2),
                new Addrees(98,2,"", "", "2100", 2),
                new Addrees(99,2,"", "", "2100", 2),
                new Addrees(100,2,"", "", "2100", 2),
        };


        private string[] regionsString = new string[] { "Брестская", "Витебская", "Гомельская", "Гродненская", "Минская", "Могилевская" };
        private string[] cityString = new string[] { "Брест", "Витебск", "Гомель", "Гродно", "Могилев", "Минск" };
        private string[] SreetType = new string[] { "Улица", "Проспект", "Переулок", "Бульвар", "Площадь", "Проезд", "Тракт" }; 

        public void AddRegion()
        {
            for (int i = 0; i < regionsString.Length; i++)
            {
                regions.Add(new Region(i+1, regionsString[i]));
            }
            mb.Entity<Region>().HasData(regions);            
        }

        public void AddCity()
        {
            for (int i = 0; i < cityString.Length; i++)
            {
                var newCity = new City(i + 1, cityString[i], regions[i].IdRegion);
                cities.Add(newCity);
            }
            mb.Entity<City>().HasData(cities);
        }

        public void AddStreetType()
        {
            mb.Entity<StreetType>().HasData(
            new StreetType[]
            {
                new StreetType { IdStreetType = 1, name = "Улица"},
                new StreetType { IdStreetType = 2, name = "Проспект"},
                new StreetType { IdStreetType = 3, name = "Переулок"},
                new StreetType { IdStreetType = 4, name = "Бульвар"},
                new StreetType { IdStreetType = 5, name = "Площадь"},
                new StreetType { IdStreetType = 6, name = "Проезд"},
                new StreetType { IdStreetType = 7, name = "Тракт"}
            });
        }

        public void AddAddress()
        {
            mb.Entity<Addrees>().HasData(addrees);
        }

        public void AddRole()
        {
            mb.Entity<Role>().HasData(
            new Role[]
            {
                new Role {IdRole = 1, RoleName = "User"},
                new Role {IdRole = 2, RoleName = "BankAdmin"}
            });
        }


        public void AddBranch()
        {
            mb.Entity<Branch>().HasData(
            new Branch[]
            {
                new Branch(1,654743,1,1,0,1,1,0,1,"Пн-Пт 8.00 - 17.00"),
                new Branch(2,756445,2,0,1,0,0,1,0,"Пн-Пт 8.00 - 17.00"),
                new Branch(3,926367,3,1,0,1,0,0,1,"Пн-Пт 8.00 - 17.00"),
                new Branch(4,324678,4,1,1,0,1,1,0,"Пн-Пт 8.00 - 17.00"),
                new Branch(5,314684,5,0,1,1,0,0,1,"Пн-Пт 8.00 - 17.00"),
                new Branch(6,557526,6,0,0,1,1,1,0,"Пн-Пт 8.00 - 17.00"),
                new Branch(7,757667,7,1,0,0,0,0,1,"Пн-Пт 8.00 - 17.00"),
                new Branch(8,246857,8,1,0,1,1,1,0,"Пн-Пт 8.00 - 17.00")
            });
        }


    }
}
