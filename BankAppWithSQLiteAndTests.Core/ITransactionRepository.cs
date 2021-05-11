using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppWithSQLiteAndTests.Core
{
    public interface ITransactionRepository
    {
        public void RegisterTransaction(string accNumber, decimal amount, string type);
        public string DepositMoney(decimal amountForDeposit, object accNumber);
        string WithdrawMoney(decimal amountToWithdraw, string accNum);

        public string TransferMoney(decimal amountToTransfer, string transferringAccNum, string receivingAccNum);
    }
}
