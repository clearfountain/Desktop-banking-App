using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using BankAppWithSQLiteAndTests.Data;
using BankAppWithSQLiteAndTests.Models;

namespace BankAppWithSQLiteAndTests.Core
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankAppContext _ctx;

        public TransactionRepository(BankAppContext ctx)
        {
            _ctx = ctx;
        }

        public string DepositMoney(decimal amountForDeposit, object accNumber)
        {
            string retMessage = "";
            using var transaction = _ctx.Database.BeginTransaction();

            try
            {
                IncreaseAccountBalance(accNumber.ToString(), amountForDeposit);

                _ctx.SaveChanges();


                RegisterTransaction(accNumber.ToString(), amountForDeposit, "deposit");
        
                _ctx.SaveChanges();

                transaction.Commit();

                retMessage = "DepositSuccessful";
            }
            catch (Exception)
            {
                retMessage = "ServerError";
            }

            return retMessage;
        }

        public string WithdrawMoney(decimal amountForWithdrawal, string accNum)
        {
            string retMessage = "";

            using var transaction = _ctx.Database.BeginTransaction();

            var accToWithdrawFrom = (from a in _ctx.Accounts
                                     where a.AccountNumber == accNum
                                     select a)
                                    .FirstOrDefault();

            var availableBalance = accToWithdrawFrom.Balance;

            var minimumBalance = accToWithdrawFrom.MinimumBalance;

            var balanceAfterWithdrawal = availableBalance - amountForWithdrawal;

            if (accToWithdrawFrom == null)
            {
                retMessage = "NoAccount";
            }
            else if (balanceAfterWithdrawal < minimumBalance)
            {
                retMessage = "Overwithdrawal";
            }
            else
            {
                try
                {
                    DecreaseAccountBalance(accNum, amountForWithdrawal);

                    _ctx.SaveChanges();

                    RegisterTransaction(accNum, amountForWithdrawal, "withdrawal");

                    _ctx.SaveChanges();


                    transaction.Commit();

                    retMessage = "WithdrawalSuccessful";
                }
                catch (Exception)
                {
                    retMessage = "ServerError";
                }
            }
            
            return retMessage;
        }

        public string TransferMoney(decimal amountToTransfer, string transferringAccNum, string receivingAccNum)
        {
            string retMessage = "";

            //bool inAccNumberExists = CheckIfAccountExists(inAccNumber);

            bool inAccNumberExists = CheckIfAccountExists(receivingAccNum);

            if (receivingAccNum == transferringAccNum)
            {
                retMessage = "SameAccount";
            }
            else if (!inAccNumberExists)
            {
                retMessage = "ReceivingAccountDoesNotExist";
            }
            else
            {
                using var transaction = _ctx.Database.BeginTransaction();

                var accToWithdrawFrom = (from a in _ctx.Accounts
                                         where a.AccountNumber == transferringAccNum
                                         select a)
                                        .FirstOrDefault();

                var availableBalance = accToWithdrawFrom.Balance;

                var minimumBalance = accToWithdrawFrom.MinimumBalance;

                var balanceAfterWithdrawal = availableBalance - amountToTransfer;

                if (accToWithdrawFrom == null)
                {
                    retMessage = "NoAccount";
                }
                else if (balanceAfterWithdrawal < minimumBalance)
                {
                    retMessage = "Overwithdrawal";
                }
                else
                {
                    try
                    {
                        DecreaseAccountBalance(transferringAccNum, amountToTransfer);

                        _ctx.SaveChanges();

                        RegisterTransaction(transferringAccNum, amountToTransfer, "transfer out");

                        _ctx.SaveChanges();

                        IncreaseAccountBalance(receivingAccNum, amountToTransfer);

                        _ctx.SaveChanges();

                        RegisterTransaction(receivingAccNum, amountToTransfer, "transfer in");

                        _ctx.SaveChanges();
                        transaction.Commit();

                        retMessage = "TransferSuccess";

                    }
                    catch (Exception)
                    {
                        retMessage = "ServerError";
                    }
                }
            }
                return retMessage;
        }

        public void IncreaseAccountBalance(string accNumber, decimal amount)
        {
            var accToIncreaseBalance = (from a in _ctx.Accounts
                         where a.AccountNumber == accNumber
                         select a)
                        .FirstOrDefault();

            accToIncreaseBalance.Balance += amount;
        }

        public void DecreaseAccountBalance(string accNumber, decimal amount)
        {
            var accToIncreaseBalance = (from a in _ctx.Accounts
                                        where a.AccountNumber == accNumber
                                        select a)
                        .FirstOrDefault();

            accToIncreaseBalance.Balance -= amount;
        }
        public void RegisterTransaction(string accNumber, decimal amount, string type)
        {
            var newTran = new Transaction(accNumber, amount, type);
            var accWithAccNumber = (from a in _ctx.Accounts
                                     where a.AccountNumber == accNumber
                                     select a)
                           .FirstOrDefault();

            newTran.AccountId = accWithAccNumber.AccountId;

            _ctx.Transactions.Add(newTran);
        }

        public bool CheckIfAccountExists(string accNumber)
        {
            bool exists = false;
            var acc = (from a in _ctx.Accounts
                       where a.AccountNumber == accNumber
                       select a)
                      .FirstOrDefault();

            if (acc != null)
                exists = true;

            return exists;
        }
    }
}
