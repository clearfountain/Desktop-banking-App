using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using BankAppWithSQLiteAndTests.Data;
using BankAppWithSQLiteAndTests.Models;
using BankAppWithSQLiteAndTests.Commons;

namespace BankAppWithSQLiteAndTests.Core
{
    public class UserRepository : IUserRepository
    {
        private readonly BankAppContext _ctx;

        public UserRepository(BankAppContext ctx)
        {
            _ctx = ctx;
        }

        //public int GetTotalNumberOfUsers()
        //{
        //    if (_ctx.Users == null) return 0;
        //    var TotalNumberOfUsers = _ctx.Users.ToList().Count;
        //    return TotalNumberOfUsers;
        //}

        public void RegisterNewUser(User newUser)
        {
            /*bool newUserRegistered = false;

            try
            {*/
            newUser.FirstName = Utilities.FirstCharacterToUpper(newUser.FirstName);
            newUser.LastName = Utilities.FirstCharacterToUpper(newUser.LastName);
            newUser.Password = SecurePasswordHasher.Hash(newUser.Password);

            _ctx.Users.Add(newUser);
            /*}
            catch (Exception)
            {
                newUserRegistered = false;
            }

            return newUserRegistered;*/
        }

        public User GetUser(string UserId)
        {
            var user = (from u in _ctx.Users
                        where u.UserId == UserId
                        select u)
                       .FirstOrDefault();

            return user;
        }
    }
}
