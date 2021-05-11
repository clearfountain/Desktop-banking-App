using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using BankAppWithSQLiteAndTests.Data;
using BankAppWithSQLiteAndTests.Models;
using BankAppWithSQLiteAndTests.Commons;

namespace BankAppWithSQLiteAndTests.Core
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BankAppContext _ctx;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRepository _transactionRepository;
        public AuthRepository(BankAppContext ctx, IUserRepository userRepository, IAccountRepository accountRepository, ITransactionRepository transactionRepository)
        {
            _ctx = ctx;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _transactionRepository = transactionRepository;
        }

        //public int GetTotalNumberOfUsers()
        //{
        //    var TotalNumberOfUsers = _userRepository.GetTotalNumberOfUsers();
        //    return TotalNumberOfUsers;
        //}
        public bool CheckIfUserExists(string email)
        {
            bool userExists = false;

            var userIfExists = (from u in _ctx.Users
                               where u.Email == email
                               select u)
                               .FirstOrDefault();

            if (userIfExists != null)
            {
                userExists = true;
            }

            return userExists;
        }

        public string Signup(Dictionary<string, object> signupData)
        {
            var retMessage = "";

            bool signupSuccessful = false;

            string userIdToBeReturned = "";

            bool UserExists = CheckIfUserExists(signupData["Email"].ToString());

            if (UserExists)
            {
                retMessage = "UserAlreadyExists";
            }
            else
            {
                using var transaction = _ctx.Database.BeginTransaction();

                try
                {
                    bool newUserRegistered = true;

                    User newUser = new User(signupData["FirstName"].ToString(), signupData["LastName"].ToString(), signupData["Email"].ToString().Trim().ToLower(), signupData["Password"].ToString());

                    userIdToBeReturned = newUser.UserId;

                    //_ctx.Users.Add(newUser);

                    _userRepository.RegisterNewUser(newUser);

                    _ctx.SaveChanges();

                    string accTypeToRegister = "";

                    string registeredAccNum = _accountRepository.RegisterNewAccount(newUser.UserId, signupData["AccountType"].ToString());

                    _ctx.SaveChanges();


                    //_accountRepository.RegisterNewAccount(newUser.UserId, accTypeToRegister);

                    accTypeToRegister = signupData["AccountType"].ToString();

                    if(accTypeToRegister == "savings")
                    {
                        _transactionRepository.RegisterTransaction(registeredAccNum,1000.00m,"deposit");
                        _ctx.SaveChanges();

                    }


                    transaction.Commit();

                    retMessage = "SignupSuccess";
                }
                catch (Exception)
                {
                    retMessage = "ServerError";
                }
            }
            return retMessage;
        }

        public string Login(Dictionary<string, object> loginData)
        {
            string email = loginData["Email"].ToString().Trim().ToLower();
            string password = loginData["Password"].ToString();
            string retMessage = "";

            bool userExists = CheckIfUserExists(email);

            if (!userExists)
            {
                retMessage = "UserDoesNotExist";
            }
            else
            {
                var userWithEmail = (from u in _ctx.Users
                                      where u.Email == email
                                      select u)
                                      .FirstOrDefault();

                if( !SecurePasswordHasher.Verify(password, userWithEmail.Password))
                {
                    retMessage = "PasswordMismatch";
                }
                else
                {
                    GlobalConfig.SessionData["FirstName"] = userWithEmail.FirstName;
                    GlobalConfig.SessionData["LastName"] = userWithEmail.LastName;
                    GlobalConfig.SessionData["Email"] = userWithEmail.Email;

                    retMessage = "LoginSuccess";
                }
            }

            return retMessage;
        }
    }
}
