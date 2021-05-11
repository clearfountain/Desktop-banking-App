using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using BankAppWithSQLiteAndTests.Commons;

namespace BankAppWithSQLiteAndTests.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(25)]
        public string FirstName {
            get;
            set;
        }

        [Required]
        [MaxLength(25)]
        public string LastName {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password {
            get;
            set;
        }

        public ICollection<Account> Accounts { get; set; }

        public User() //Empty constructor added for migration to use when creating table
        {
            UserId = Guid.NewGuid().ToString();
        }

        public User(string firstName, string lastName, string email, string password) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
