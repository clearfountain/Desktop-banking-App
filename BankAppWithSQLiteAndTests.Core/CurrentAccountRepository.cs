using System;
using System.Collections.Generic;
using System.Text;

using BankAppWithSQLiteAndTests.Models;
using BankAppWithSQLiteAndTests.Data;
using System.Linq;

namespace BankAppWithSQLiteAndTests.Core
{
    public class CurrentAccountRepository : IAccountRepository
    {
        private readonly BankAppContext _ctx;

        public CurrentAccountRepository(BankAppContext ctx)
        {
            _ctx = ctx;
        }

        private readonly IUserRepository _userRepository;
        public int GetTotalNumberOfUsers()
        {
            var TotalNumberOfUsers = _ctx.Users.Count();
            return TotalNumberOfUsers;
        }
        public int GenerateAccountNumber()
        {
            int newAccountNumber = GetTotalNumberOfUsers() + 1;
            return newAccountNumber;
        }

        public bool RegisterNewAccount(string ownerId)
        {
            bool newAccRegistered = true;
            int newAccNumber = GenerateAccountNumber();

            Account newAcc = new Account(ownerId, newAccNumber);

            try
            {
                _ctx.Accounts.Add(newAcc);
                newAccRegistered = true;
            }
            catch (Exception)
            {
                newAccRegistered = false;
            }

            return newAccRegistered;
        }

        public string RegisterNewAccount(string ownerId, string type)
        {
            //throw new NotImplementedException();
            return "";
        }

        List<Account> IAccountRepository.GetAllUserAccounts(string email)
        {
            throw new NotImplementedException();
        }

        string IAccountRepository.CreateAccountFromDashboard(string email)
        {
            throw new NotImplementedException();
        }

        public void IncreaseBalance(string accNumber, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfAccountExists(string accNumber)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(string accNumber)
        {
            throw new NotImplementedException();
        }
    }
}
