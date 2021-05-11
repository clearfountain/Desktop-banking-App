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
    public partial class TransferForm : Form
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IAccountRepository _accountRepository;

        public string _outAccNum;

        public string accountTotransferTo = "";
        public decimal amountForTransfer = 0;
        public bool validInputs = false;
        public TransferForm(ITransactionRepository transactionRepository, IAccountRepository accountRepository, string outAccNum)
        {
            _transactionRepository = transactionRepository;
            _accountRepository = accountRepository;
            _outAccNum = outAccNum;
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            amountForTransfer = amountToTransferTextbox.Value;
            accountTotransferTo = accountNumberTextbox.Value.ToString();

            string messageFromTransferServer = "";

            bool accountTotransferToExists = _accountRepository.CheckIfAccountExists(accountTotransferTo);

            if (amountForTransfer < 1 || amountForTransfer > 1_000_000)
            {
                MessageBox.Show("Enter an amount between 1 and 1,000,000");
            }
            //else if (accountTotransferTo < 3_799_999 || accountTotransferTo > 3_790_000)
            else if (_outAccNum == accountTotransferTo)
            {
                MessageBox.Show("Cannot perform transfer into same account");
            }
            else if (!accountTotransferToExists)
            {
                MessageBox.Show("Account number does not exist");
            }
            else
            {
                validInputs = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void amountToTransferTextbox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
