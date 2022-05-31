
using BankSystemASP.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BankSystemASP;
using BankSystemASP.Helpers;


namespace BankSystemASP.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();            
        }
        #region DbSets
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Addrees> Addrees { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ExchangeRates> ExchangeRates { get; set; }
        public DbSet<СustomerBankAccounts>  CustomerBankAccounts { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasOne(p => p.region).WithMany(t => t.cities).HasForeignKey(p => p.idRegion);
            modelBuilder.Entity<Addrees>().HasOne(p => p.streetType).WithMany(t => t.addrees).HasForeignKey(p => p.idStreetType);
            modelBuilder.Entity<Addrees>().HasOne(p => p.city).WithMany(t => t.addrees).HasForeignKey(p => p.idCity);
            modelBuilder.Entity<Branch>().HasOne(p => p.Addrees).WithMany(t => t.branches).HasForeignKey(p => p.IdAddress);
            modelBuilder.Entity<PhoneNumber>().HasOne(p => p.Branch).WithMany(t => t.phoneNumbers).HasForeignKey(p => p.IdBranch);
            modelBuilder.Entity<ExchangeRates>().HasOne(p => p.Branch).WithMany(t => t.ExchangeRates).HasForeignKey(p => p.IdBranch);
            modelBuilder.Entity<ExchangeRates>().HasOne(p => p.Currency).WithMany(t => t.ExchangeRates).HasForeignKey(p => p.IdCurrency);
            modelBuilder.Entity<BankAccount>().HasOne(p => p.Currency).WithMany(t => t.BankAccounts).HasForeignKey(p => p.IdCurrency);
            modelBuilder.Entity<BankAccount>().HasOne(p => p.Branch).WithMany(t => t.BankAccounts).HasForeignKey(p => p.IdCurrency);
            modelBuilder.Entity<Transaction>().HasOne(p => p.BankAccount).WithMany(t => t.Transactions).HasForeignKey(p => p.IdBankAccount_Receiver);
            modelBuilder.Entity<Transaction>().HasOne(p => p.BankAccount).WithMany(t => t.Transactions).HasForeignKey(p => p.IdBankAccount_Sender);
            modelBuilder.Entity<СustomerBankAccounts>().HasOne(p => p.BankAccount).WithMany(t => t.СustomerBankAccounts).HasForeignKey(p => p.IdBankAccount);
            modelBuilder.Entity<СustomerBankAccounts>().HasOne(p => p.Customer).WithMany(t => t.СustomerBankAccounts).HasForeignKey(p => p.IdCustomer);
            modelBuilder.Entity<Customer>().HasOne(p => p.Role).WithMany(t => t.Customers).HasForeignKey(p => p.IdRole);

            InitDataBase initDataBase = new InitDataBase(modelBuilder);
            initDataBase.AddRegion();
            initDataBase.AddCity();
            initDataBase.AddStreetType();
            initDataBase.AddAddress();
            initDataBase.AddBranch();
            initDataBase.AddRole();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
