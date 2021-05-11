using System;
using System.Collections.Generic;

using BankAppWithSQLiteAndTests.Data;

namespace BankAppWithSQLiteAndTests.Core
{
    public static class GlobalConfig
    {
        public static IAuthRepository AuthRepositoryInstance { get; set; }
        public static IUserRepository UserRepositoryInstance { get; set; }
        public static IAccountRepository AccountRepositoryInstance { get; set; }
        public static ITransactionRepository TransactionRepository { get; set; }

        public static Dictionary<string,string> SessionData { get; set; }
        public static void AddInstances()
        {
            var ctx = new BankAppContext();
            UserRepositoryInstance = new UserRepository(ctx);
            TransactionRepository = new TransactionRepository(ctx);
            AccountRepositoryInstance = new AccountRepository(ctx, UserRepositoryInstance, TransactionRepository);
            AuthRepositoryInstance = new AuthRepository(ctx, UserRepositoryInstance, AccountRepositoryInstance, TransactionRepository);
            SessionData = new Dictionary<string, string>
            {
                {"FirstName", null },
                {"LastName", null },
                {"Email", null },
                {"UserId", null }
            };
        }
    }
}
