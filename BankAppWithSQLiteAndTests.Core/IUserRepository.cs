using BankAppWithSQLiteAndTests.Models;
using System;
using System.Collections.Generic;
using System.Text;

using BankAppWithSQLiteAndTests.Models;

namespace BankAppWithSQLiteAndTests.Core
{
    public interface IUserRepository
    {
        //public int GetTotalNumberOfUsers();
        public void RegisterNewUser(User newUser);

        public User GetUser(string UserId);
    }
}
