using System;
using System.Collections.Generic;
using System.Text;

using BankAppWithSQLiteAndTests.Models;

namespace BankAppWithSQLiteAndTests.Core
{
    public interface IAccountRepository
    {
        public int GenerateAccountNumber();

        public string RegisterNewAccount(string ownerId, string type);

        public List<Account> GetAllUserAccounts(string email);

        public string CreateAccountFromDashboard(string email);

        public void IncreaseBalance(string accNumber, decimal amount);

        public bool CheckIfAccountExists(string accNumber);

        public Account GetAccount(string accNumber);
    }
}
