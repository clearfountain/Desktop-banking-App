using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppWithSQLiteAndTests.Models
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int newAccountNumber) : base(newAccountNumber)
        {
        }

        public CurrentAccount(string ownerId, int newAccountNumber) : base(newAccountNumber)
        {
            UserId = ownerId;
            AccountType = "current";
            MinimumBalance = 0.00m;
            Balance = 0.00m;
        }
    }
}
