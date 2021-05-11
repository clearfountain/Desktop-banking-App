using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BankAppWithSQLiteAndTests.Data;
using BankAppWithSQLiteAndTests.Models;

namespace BankAppWithSQLiteAndTests.Core
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankAppContext _ctx;

        private readonly IUserRepository _userRepository;

        private readonly ITransactionRepository _transactionRepository;

        private readonly int AccountPrefix = 4_531__000;

        public AccountRepository(BankAppContext ctx, IUserRepository userRepository, ITransactionRepository transactionRepository)
        {
            _ctx = ctx;
            _userRepository = userRepository;
            _transactionRepository = transactionRepository;
        }

        //public ulong GetTotalNumberOfUsers()
        //{
        //    ulong TotalNumberOfUsers = (ulong)_userRepository.GetTotalNumberOfUsers();
        //    return TotalNumberOfUsers;
        //}

        public int GenerateAccountNumber()
        {
            var accounts = _ctx.Accounts.ToList();
            int newAccountNumber = 0;
            if (accounts != null)
            {
                newAccountNumber = accounts.Count + AccountPrefix + 1;

            }
            return newAccountNumber;
        }

        public string RegisterNewAccount(string ownerId, string type)
        {
            bool newAccRegistered = true;
            string newAccountNumber = "";
            int newAccNumber = GenerateAccountNumber();

            if(type == "savings")
            {
                Account newAcc = new Account(ownerId, newAccNumber);
                newAccountNumber = newAcc.AccountNumber;
                /*try
                {*/
                _ctx.Accounts.Add(newAcc);
                    newAccRegistered = true;
                //}
                /*catch (Exception)
                {
                    newAccRegistered = false;
                }*/

            }
            if (type == "current")
            {
                CurrentAccount newCurrAcc = new CurrentAccount(ownerId, newAccNumber);
                newAccountNumber = newCurrAcc.AccountNumber;

                //try
                //{
                _ctx.Accounts.Add(newCurrAcc);
                    newAccRegistered = true;
                /*}
                catch (Exception)
                {
                    newAccRegistered = false;
                }*/
            }

            return newAccNumber.ToString();
            //return newAccRegistered;
        }

        public List<Account> GetAllUserAccounts(string email)
        {
            List<Account> allUserAccounts = new List<Account>();

            string userId = GetUserIdFromEmail(email);

            allUserAccounts = (from a in _ctx.Accounts
                               where a.UserId == userId
                               select a)
                              .ToList();

            return allUserAccounts;
        }

        public string GetUserIdFromEmail(string email)
        {
            string userId = "";

            userId = (from u in _ctx.Users
                          where u.Email == email
                          select u.UserId)
                         .FirstOrDefault();

            return userId;
        }

        public string CreateAccountFromDashboard(string email)
        {
            string retMessage = "";
            var allUserAccounts = GetAllUserAccounts(email);

            var accTypeOwnedByUser = allUserAccounts[0].AccountType;
            var ownerId = GetUserIdFromEmail(email);

            var accTypeToCreate = "";


            if(allUserAccounts.Count == 2)
            {
                retMessage = "MaximumNumberOfAccounts";
            }
            else if(allUserAccounts.Count == 1)
            {
                string registeredAccNum = "";

                if (accTypeOwnedByUser == "savings")
                    accTypeToCreate = "current";

                if (accTypeOwnedByUser == "current")
                    accTypeToCreate = "savings";

                using var transaction = _ctx.Database.BeginTransaction();
                try
                {
                    registeredAccNum = RegisterNewAccount(ownerId, accTypeToCreate);

                    _ctx.SaveChanges();

                    if (accTypeToCreate == "savings")
                    {
                        _transactionRepository.RegisterTransaction(registeredAccNum, 1000.00m, "deposit");
                        _ctx.SaveChanges();

                    }

                    transaction.Commit();
                    retMessage = accTypeToCreate + "AccountCreated";
                }
                catch (Exception)
                {
                    retMessage = "ServerError";
                }
            }

            return retMessage;
        }

        public void IncreaseBalance(string accNumber, decimal amount)
        {
            var accToIncreaseBalance = (from a in _ctx.Accounts
                 where a.AccountNumber == accNumber
                 select a).SingleOrDefault();

            accToIncreaseBalance.Balance += amount;
        }

        public bool CheckIfAccountExists(string accNumber)
        {
            bool exists = false;
            var acc = (from a in _ctx.Accounts
                       where a.AccountNumber == accNumber
                       select a)
                      .FirstOrDefault();

            if (acc != null)
                exists = true;

            return exists;
        }
        
        public Account GetAccount(string accNumber)
        {
            var acc = (from a in _ctx.Accounts
                       where a.AccountNumber == accNumber
                       select a)
                      .FirstOrDefault();

            return acc;
        }
    
    }
}
