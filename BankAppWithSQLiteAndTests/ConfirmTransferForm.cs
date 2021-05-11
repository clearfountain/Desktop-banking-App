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
    public partial class ConfirmTransferForm : Form
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;

        public string _outAccNum;
        public string _inAccNum;
        public decimal _amountToTransfer;
        public ConfirmTransferForm(ITransactionRepository transactionRepository, IAccountRepository accountRepository, IUserRepository userRepository, string outAccNumber, string inAccNumber, decimal amountToTransfer)
        {
            _transactionRepository = transactionRepository;
            _accountRepository = accountRepository;
            _userRepository = userRepository;
            _outAccNum = outAccNumber;
            _inAccNum = inAccNumber;
            _amountToTransfer = amountToTransfer;
            InitializeComponent();
        }

        private void ConfirmTransferForm_Load(object sender, EventArgs e)
        {
            Account receivingAcc = _accountRepository.GetAccount(_inAccNum);
            User receivingAccOwner = _userRepository.GetUser(receivingAcc.UserId);

            label1.Text = $"Transfer '{_amountToTransfer}' to '{receivingAccOwner.FirstName} {receivingAccOwner.LastName}' with account number {_inAccNum}?";
        }

        private void confirmTransferBtn_Click(object sender, EventArgs e)
        {
            string messageFromTransferServer = "";
            messageFromTransferServer = _transactionRepository.TransferMoney(_amountToTransfer, _outAccNum, _inAccNum);

            if (messageFromTransferServer == "SameAccount")
            {
                MessageBox.Show("Cannot transfer between same account", "Invalid transfer");
            }
            else if (messageFromTransferServer == "ReceivingAccountDoesNotExist")
            {
                MessageBox.Show("Account to transfer to does not exist", "Invalid account");
            }
            else if (messageFromTransferServer == "NoAccount")
            {
                MessageBox.Show("Transferring account does not exist", "Unavailable transferring account");
            }
            else if (messageFromTransferServer == "Overwithdrawal")
            {
                MessageBox.Show("Error, your balance after this transfer will be more than the allowed minimum balance", "Overwithdrawal");
            }
            else if (messageFromTransferServer == "TransferSuccess")
            {
                MessageBox.Show($"Successfully transferred {_amountToTransfer} from {_outAccNum} to {_inAccNum}");
            }
            else if (messageFromTransferServer == "ServerError")
            {
                MessageBox.Show("Server error, try again later", "Server Error");
            }
        }
    }
}
