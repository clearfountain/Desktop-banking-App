using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppWithSQLiteAndTests.Core
{
    public interface ICRUDRepository
    {
        public bool Add<T>(T model) where T : class;
    }
}
