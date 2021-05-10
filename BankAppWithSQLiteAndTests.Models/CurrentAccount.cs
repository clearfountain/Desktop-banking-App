using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppWithSQLiteAndTests.Models
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int numOfAccounts) : base(numOfAccounts)
        {
        }

        public CurrentAccount(string ownerId, decimal bal, int totalNumberOfAccounts) : base(totalNumberOfAccounts)
        {
            UserId = ownerId;
            Balance = bal;
            AccountType = "savings";
        }
    }
}
