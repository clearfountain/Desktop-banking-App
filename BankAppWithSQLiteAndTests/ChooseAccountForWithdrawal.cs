using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BankAppWithSQLiteAndTests.Core;
using BankAppWithSQLiteAndTests.Models;

namespace BankAppWithSQLiteAndTests.UI
{
    public partial class ChooseAccountForWithdrawal : Form
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;

        public string accoutTypeChosen;
        public string accNumberForWithdrawal;
        public List<Account> customerAccounts;
        public ChooseAccountForWithdrawal(IAccountRepository accountRepository, IUserRepository userRepository)
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
            customerAccounts = _accountRepository.GetAllUserAccounts(GlobalConfig.SessionData["Email"]);
            InitializeComponent();
        }

        private void ChooseAccountForWithdrawal_Load(object sender, EventArgs e)
        {
            bool savingsPresent = false;
            bool currentPresent = false;

            foreach (Account acc in customerAccounts)
            {
                if (acc.AccountType == "savings")
                {
                    savingsPresent = true;
                }
                if (acc.AccountType == "current")
                {
                    currentPresent = true;
                }
            }

            if (savingsPresent)
            {
                savingsBtn.Visible = true;
            }
            if (currentPresent)
            {
                currentBtn.Visible = true;
            }

        }

        private void savingsBtn_Click(object sender, EventArgs e)
        {
            accoutTypeChosen = "savings";
            accNumberForWithdrawal = GetAccountNumber(accoutTypeChosen);
            this.DialogResult = DialogResult.OK;
        }

        private void currentBtn_Click(object sender, EventArgs e)
        {
            accoutTypeChosen = "current";
            accNumberForWithdrawal = GetAccountNumber(accoutTypeChosen);
            this.DialogResult = DialogResult.OK;
        }

        private string GetAccountNumber(string accType)
        {
            string accNumber = "";
            foreach (Account acc in customerAccounts)
            {
                if (acc.AccountType == accType)
                {
                    accNumber = acc.AccountNumber;
                    break;
                }

            }

            return accNumber;
        }
    }
}
