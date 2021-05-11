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
    public partial class WithdrawalForm : Form
    {
        private readonly ITransactionRepository _transactionRepository;
        private string _accNum;
        public WithdrawalForm(ITransactionRepository transactionRepository, string accNUm)
        {
            _transactionRepository = transactionRepository;
            _accNum = accNUm;
            InitializeComponent();
        }

        private void WithdrawalForm_Load(object sender, EventArgs e)
        {

        }

        private void withdrawalBtn_Click(object sender, EventArgs e)
        {
            string messageFromWithdrawalServer = "";

            decimal amountToWithdraw = withdrawalAmountBox.Value;

            if (amountToWithdraw < 1 || amountToWithdraw > 1000000)
            {
                MessageBox.Show("Enter an amount between 1 and 1,000,000");
            }
            else
            {


                messageFromWithdrawalServer = _transactionRepository.WithdrawMoney(amountToWithdraw, _accNum);

                if(messageFromWithdrawalServer == "NoAccount")
                {
                    MessageBox.Show("Account number does not exist");
                }
                else if(messageFromWithdrawalServer == "Overwithdrawal")
                {
                    MessageBox.Show("Amount more than your account's minimum balance");
                }
                else if(messageFromWithdrawalServer == "WithdrawalSuccessful")
                {
                    MessageBox.Show("Withdrawal successful");
                }
                else if(messageFromWithdrawalServer == "ServerError")
                {
                    MessageBox.Show("Server error, try again later");
                }
                    
            }
        }
    }
}
