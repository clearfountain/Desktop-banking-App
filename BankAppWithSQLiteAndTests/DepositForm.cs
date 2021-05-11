using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BankAppWithSQLiteAndTests.Core;

namespace BankAppWithSQLiteAndTests.UI
{
    public partial class DepositForm : Form
    {
        IAccountRepository _accountRepository;
        ITransactionRepository _transactionRepository;
        string _accNum;
        public DepositForm(IAccountRepository accountRepository,ITransactionRepository transactionRepository, string accNum)
        {
            _accountRepository = accountRepository;
            _transactionRepository = transactionRepository;
            _accNum = accNum;
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }

        private void depositAmountBtn_Click(object sender, EventArgs e)
        {
            string messageFromServer = "";
            decimal amountForDeposit = depositAmountBox.Value;

            if (amountForDeposit < 1 || amountForDeposit > 1000000)
            {
                MessageBox.Show("Enter an amount between 1 and 1,000,000");
            }
            else
            {

                messageFromServer = _transactionRepository.DepositMoney(amountForDeposit, _accNum);

                if (messageFromServer == "DepositSuccessful")
                {
                    MessageBox.Show("Deposit successful");
                }
                else
                {
                    MessageBox.Show("Deposit unsuccessful");
                }
            }
        }
    }
}
