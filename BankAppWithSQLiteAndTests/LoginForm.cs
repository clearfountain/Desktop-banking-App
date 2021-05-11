using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BankAppWithSQLiteAndTests.Commons;
using BankAppWithSQLiteAndTests.Core;

namespace BankAppWithSQLiteAndTests.UI
{
    public partial class LoginForm : Form
    {
        public bool UserLoginSuccessful = false;
        private readonly IAuthRepository _authRepository;
        public LoginForm(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string messageFromLoginServer = "";
            Dictionary<string, object> loginData = new Dictionary<string, object>
            {
                {"Email", null },
                {"Password", null }
            };

            //Display error message if email textbox is empty or null
            if (string.IsNullOrEmpty(loginEmailTextBox.Text))
            {
                _ = MessageBox.Show("Enter your email address", "Error!");
                return;
            }

            //Display error message if email format is incorrect
            if (!Utilities.IsValidEmail(loginEmailTextBox.Text))
            {
                _ = MessageBox.Show("Invalid email address", "Error!");
                return;
            }

            loginData["Email"] = loginEmailTextBox.Text;

            //Display error message if password textbox is empty or null
            if (string.IsNullOrEmpty(loginPasswordTextBox.Text))
            {
                _ = MessageBox.Show("Enter your password", "Error!");
                return;
            }

            loginData["Password"] = loginPasswordTextBox.Text;

            messageFromLoginServer = _authRepository.Login(loginData);

            if(messageFromLoginServer == "UserDoesNotExist")
            {
                MessageBox.Show("User does not exist with the email inputted");
            }
            else if(messageFromLoginServer == "PasswordMismatch")
            {
                MessageBox.Show("Incorrect password");
            }
            else if(messageFromLoginServer == "LoginSuccess")
            {
                UserLoginSuccessful = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void backToHomePageBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
