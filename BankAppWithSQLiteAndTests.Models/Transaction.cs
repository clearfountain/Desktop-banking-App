using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BankAppWithSQLiteAndTests.Models
{
    public class Transaction
    {
        [Key]
        public string TransactionId { get; set; }

        [Required]
        public string AccountId { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string TransactionType { get; set; }

        [Required]
        public DateTime DateOfTransaction { get; set; }

        //empty constructor
        public Transaction()
        {
            TransactionId = Guid.NewGuid().ToString();
            DateOfTransaction = DateTime.Now;
        }

        //parameterized constructor and chaining
        public Transaction(string accNumber, decimal amt, string tranType) : this()
        {
            AccountNumber = accNumber;
            Amount = amt;
            TransactionType = tranType;
        }
    }
}
