using BankAppWithSQLiteAndTests.Core;
using BankAppWithSQLiteAndTests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

using BankAppWithSQLiteAndTests.Models;
using System.Linq;

namespace BankAppTests
{
    [TestClass]
    public class TestAccountRepository
    {
        protected BankAppContext context = new BankAppContext();

        public List<User> TestUsers = new List<User>
        {
            new User{ Email = "a@b.c", FirstName = "John", LastName = "Doe", Password = "12345678", UserId = "1"},
            new User{ Email = "d@e.f", FirstName = "Jane", LastName = "Doe", Password = "12345678", UserId = "2"}
        };

        public List<Account> TestAccounts = new List<Account>
        {
            new Account{ AccountId = "1", AccountNumber = "453001", AccountType = "savings", Balance = 1000, MinimumBalance = 1000, UserId = "1"},
            new Account{ AccountId = "2", AccountNumber = "453002", AccountType = "current", Balance = 0, MinimumBalance = 0, UserId = "2"}
        };
        public TestAccountRepository()
        {
            if(context.Users.Count() < 1)
            {
                context.Users.Add(TestUsers[0]);
                context.Users.Add(TestUsers[1]);
                context.Accounts.Add(TestAccounts[0]);
                context.Accounts.Add(TestAccounts[1]);

                context.SaveChanges();
            }
            
        }

        [TestMethod]
        public void TestGenerateAccountNumber()
        {

            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));
            //TransactionRepository trans = new TransactionRepository(context);

            int expected = 4_531__003;

            int actual = acc.GenerateAccountNumber();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRegisterNewAccountWithValidInput()
        {
            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));

            string expected = "4531003";

            string actual = acc.RegisterNewAccount(Guid.NewGuid().ToString(), "savings");

            Assert.AreEqual(expected, actual);
        }

        public void TestRegisterNewAccountWithInvalidAccountType()
        {
            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));

            string expected = "InvalidAccountType";

            string actual = acc.RegisterNewAccount(Guid.NewGuid().ToString(), "domiciliary");

            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void TestGetUserIdFromEmail()
        {
            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));

            context.Users.Add(TestUsers[0]);

            string expected = "1";

            string actual = acc.GetUserIdFromEmail("a@b.c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUserIdFromEmailWithEmailNotInDB()
        {
            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));

            string expected = null;

            string actual = acc.GetUserIdFromEmail("not@in.db");

            Assert.AreEqual(expected, actual);
        }

       /* [TestMethod]
        public void TestGetAllUserAccounts()
        {
            context = new BankAppContext();
            AccountRepository acc = new AccountRepository(context, new UserRepository(context), new TransactionRepository(context));

            List<Account> expected = new List<Account>()
            {
                new Account{ AccountId = "1", AccountNumber = "453001", AccountType = "savings", Balance = 1000, MinimumBalance = 1000, Transactions = null, UserId = "1" }
            };

            List<Account> actual = acc.GetAllUserAccounts("a@b.c");

            var a = 0;
            Assert.AreEqual(expected, actual);
        }*/
    }
}
