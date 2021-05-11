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
    public partial class DashboardForm : Form
    {
        private readonly IAccountRepository _accountRepository;
        public DashboardForm(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            InitializeComponent();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string messageFromServer;
            
            messageFromServer = _accountRepository.CreateAccountFromDashboard(GlobalConfig.SessionData["Email"]);

            
            if(messageFromServer == "MaximumNumberOfAccounts")
            {
                MessageBox.Show("You have reached the maximum number of accounts");
            }
            else if (messageFromServer == "ServerError")
            {
                MessageBox.Show("Server error, try again later");
            }
            else if (messageFromServer == "savingsAccountCreated")
            {
                MessageBox.Show("Your savings account has been created");
            }
            else if (messageFromServer == "currentAccountCreated")
            {
                MessageBox.Show("Your current account has been created");
            }
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseAccountForDeposit chooseAccountForDeposit = new ChooseAccountForDeposit(GlobalConfig.AccountRepositoryInstance, GlobalConfig.UserRepositoryInstance);

            chooseAccountForDeposit.FormClosed += new FormClosedEventHandler(Form_Closed);

            if (chooseAccountForDeposit.ShowDialog(this) == DialogResult.OK)
            {
                //this.Show();

                string accountTypeChosen = chooseAccountForDeposit.accoutTypeChosen;
                string accNumber = chooseAccountForDeposit.accNumbeForDeposit;
                chooseAccountForDeposit.Dispose();

                if (accountTypeChosen == "savings" || accountTypeChosen == "current")
                {
                    DepositForm deposit_Form = new DepositForm(GlobalConfig.AccountRepositoryInstance,GlobalConfig.TransactionRepository, accNumber);

                    deposit_Form.FormClosed += new FormClosedEventHandler(Form_Closed);

                    this.Hide();
                    if (deposit_Form.ShowDialog(this) == DialogResult.OK)
                    {
                        deposit_Form.Dispose();
                        this.Show();
                    }
                }
            }
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {

            this.Show();

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseAccountForWithdrawal chooseAccountForWithdrawal = new ChooseAccountForWithdrawal(GlobalConfig.AccountRepositoryInstance, GlobalConfig.UserRepositoryInstance);

            chooseAccountForWithdrawal.FormClosed += new FormClosedEventHandler(Form_Closed);

            if (chooseAccountForWithdrawal.ShowDialog(this) == DialogResult.OK)
            {
                //this.Show();

                string accountTypeChosen = chooseAccountForWithdrawal.accoutTypeChosen;
                string accNumber = chooseAccountForWithdrawal.accNumberForWithdrawal;
                chooseAccountForWithdrawal.Dispose();

                if (accountTypeChosen == "savings" || accountTypeChosen == "current")
                {
                    WithdrawalForm deposit_Form = new WithdrawalForm(GlobalConfig.TransactionRepository, accNumber);

                    deposit_Form.FormClosed += new FormClosedEventHandler(Form_Closed);

                    this.Hide();
                    if (deposit_Form.ShowDialog(this) == DialogResult.OK)
                    {
                        deposit_Form.Dispose();
                        this.Show();
                    }
                }
            }
        }

        private void transferMoneyBtn_Click(object sender, EventArgs e)
        {
            string outAccNumber = "";
            string inAccNumber = "";
            decimal amountToTransfer = 0;
            string accountTypeChosen = "";
            this.Hide();
            ChooseAccountForTransfer chooseAccountForTransfer = new ChooseAccountForTransfer(GlobalConfig.AccountRepositoryInstance, GlobalConfig.UserRepositoryInstance);

            chooseAccountForTransfer.FormClosed += new FormClosedEventHandler(Form_Closed);

            if (chooseAccountForTransfer.ShowDialog(this) == DialogResult.OK)
            {
                //this.Show();

                accountTypeChosen = chooseAccountForTransfer.accoutTypeChosen;
                outAccNumber = chooseAccountForTransfer.accNumberToTransferFrom;
                chooseAccountForTransfer.Dispose();

                if (accountTypeChosen == "savings" || accountTypeChosen == "current")
                {
                    TransferForm transfer_Form = new TransferForm(GlobalConfig.TransactionRepository,GlobalConfig.AccountRepositoryInstance, outAccNumber);

                    transfer_Form.FormClosed += new FormClosedEventHandler(Form_Closed);

                    this.Hide();
                    if (transfer_Form.ShowDialog(this) == DialogResult.OK)
                    {
                        inAccNumber = transfer_Form.accountTotransferTo;
                        amountToTransfer = transfer_Form.amountForTransfer;
                        bool transferFormInputsAreValid = transfer_Form.validInputs;
                        transfer_Form.Dispose();

                        if (transferFormInputsAreValid)
                        {
                            this.Hide();
                            ConfirmTransferForm confirmTransfer = new ConfirmTransferForm(GlobalConfig.TransactionRepository, GlobalConfig.AccountRepositoryInstance, GlobalConfig.UserRepositoryInstance, outAccNumber, inAccNumber, amountToTransfer);
                            confirmTransfer.FormClosed += new FormClosedEventHandler(Form_Closed);

                            confirmTransfer.Show();
                        }

                        //this.Show();
                    }
                }
            }
        }
    }
}
