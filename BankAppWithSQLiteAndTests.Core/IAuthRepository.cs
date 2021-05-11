using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppWithSQLiteAndTests.Core
{
    public interface IAuthRepository
    {
        public bool CheckIfUserExists(string email);

        public string Signup(Dictionary<string, object> signupData);

        public string Login(Dictionary<string, object> loginData);
    }
}
