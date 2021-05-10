using System;
using BankAppWithSQLiteAndTests.Models;
using Microsoft.Data.Sqlite; // namespace that contains for SqliteConnectionStringBuilder and more classes

using Microsoft.EntityFrameworkCore;

namespace BankAppWithSQLiteAndTests.Data
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = BankAppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Account>()
                .Property(p => p. )*/
        }
    }
}
