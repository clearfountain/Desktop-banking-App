﻿using System;
using BankAppWithSQLiteAndTests.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite; // namespace that contains for SqliteConnectionStringBuilder and more classes

namespace BankAppWithSQLiteAndTests.Data
{
    public class BankAppContext : DbContext
    {
        /*public BankAppContext(DbContextOptions<BankAppContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }*/
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source = WinformBankAppDB.db");
            optionsBuilder.UseInMemoryDatabase("TempDB");
        }

    }
}
