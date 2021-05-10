using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BankAppWithSQLiteAndTests.Models
{
    public class Account
    {
        //private readonly long AccountNumberSeed = 4_531_000_000;

        [Key]
        [MaxLength(10)]
        public string AccountNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [Required]
        public string AccountType { get; set; }

        [Required]
        public decimal MinimumBalance { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        public Account()
        {

        }

        //Constructor
        public Account(int newAccountNumber)
        {
            AccountNumber = newAccountNumber.ToString();
        }

        //Constructor with parameters and chaining
        public Account(string ownerId, int totalNumberOfAccounts) : this(totalNumberOfAccounts)
        {
            UserId = ownerId;
            AccountType = "savings";
        }
    }
}
