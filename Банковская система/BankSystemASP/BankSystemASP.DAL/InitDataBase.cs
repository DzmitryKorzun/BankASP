using BankSystemASP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BankSystemASP.Helpers
{
    public class InitDataBase
    {
        private readonly ModelBuilder mb;
        public InitDataBase(ModelBuilder mb)
        {
            this.mb = mb;
        }

        static private Region[] regions = new Region[]
        {
            new Region { IdRegion = 1, name = "Брестская"},
            new Region { IdRegion = 2, name = "Витебская"},
            new Region { IdRegion = 3, name = "Гомельская "},
            new Region { IdRegion = 4, name = "Гродненская "},
            new Region { IdRegion = 5, name = "Минская"},
            new Region { IdRegion = 6, name = "Могилевская "},
        };

        static private readonly City[] cities = new City[]
        {
            new City { idCity = 1, name = "Брест", idRegion = 1},
            new City { idCity = 2, name = "Витебск", idRegion = 2},
            new City { idCity = 3, name = "Гомель", idRegion = 3},
            new City { idCity = 4, name = "Гродно", idRegion = 4},
            new City { idCity = 5, name = "Заславль", idRegion = 5},
            new City { idCity = 6, name = "Могилев", idRegion = 6},
            new City { idCity = 7, name = "Минск", idRegion = 5},
        };


        public void AddRegion()
        {
            mb.Entity<Region>().HasData(regions);            
        }

        public void AddCity()
        {
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
            });
        }

        public void AddAddress()
        {
            mb.Entity<Addrees>().HasData(
            new Addrees[]
            {
                new Addrees(1,1,"Бауманская", "50", "224001", 1)

            });
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

            });
        }


    }
}
