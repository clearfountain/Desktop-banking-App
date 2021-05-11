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
    public partial class SignupForm : Form
    {
        public bool UserSignupSuccessful = false;

        private readonly IAuthRepository _authRepository;
        public SignupForm(IAuthRepository authRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
        }

        private void backToHomeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string messageFromSignupServer = null;
            Dictionary<string, object> SignupInput = new Dictionary<string, object>()
            {
                {"FirstName", null },
                {"LastName", null },
                {"Email", null },
                {"Password", null },
                {"AccountType", null },
            };

            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                _ = MessageBox.Show("Enter your first name", "Error!");
                return;
            }

            SignupInput["FirstName"] = firstNameTextBox.Text;

            //Display error message if lastname textbox is empty or null
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                _ = MessageBox.Show("Enter your last name", "Error!");
                return;
            }

            SignupInput["LastName"] = lastNameTextBox.Text;

            //Display error message if email textbox is empty or null
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                _ = MessageBox.Show("Enter your email address", "Error!");
                return;
            }

            //Display error message if email format is incorrect
            if (!Utilities.IsValidEmail(emailTextBox.Text))
            {
                _ = MessageBox.Show("Invalid email address", "Error!");
                return;
            }

            SignupInput["Email"] = emailTextBox.Text;

            //Display error message if password length is less than 8
            if (passwordTextBox.Text.Length < 8)
            {
                _ = MessageBox.Show("Enter password with at least 8 characters");
                return;
            }

            //Display error message if re-enter password textbox is empty
            if (reenterPasswordTextBox.Text.Length < 1)
            {
                _ = MessageBox.Show("Please re-enter password in the textbox provided");
                return;
            }

            //Display error message if password is not the same as re-entered password
            if (passwordTextBox.Text.Length != reenterPasswordTextBox.Text.Length)
            {
                _ = MessageBox.Show("Passwords do not match, please re - enter");
                return;
            }

            SignupInput["Password"] = passwordTextBox.Text;

            //Display error message if no account choice was picked
            if ((!savingsAccRadioButton.Checked) && (!currentAccRadioButton.Checked))
            {
                _ = MessageBox.Show("Please select a bank account type", "Error!");
                return;
            }

            if (savingsAccRadioButton.Checked)
            {
                SignupInput["AccountType"] = "savings";
            }
            else if (currentAccRadioButton.Checked)
            {
                SignupInput["AccountType"] = "current";
            }

           //Sign up user

            messageFromSignupServer = _authRepository.Signup(SignupInput);

            if(messageFromSignupServer == "UserAlreadyExists")
            {
                MessageBox.Show("User exists with the email entered", "User exists");
            }
            else if(messageFromSignupServer == "ServerError")
            {
                MessageBox.Show("Server error, try again later", "Server error");
            }
            else if(messageFromSignupServer == "SignupSuccess")
            {
                /*SessionData = new Dictionary<string, string>
            {
                {"FirstName", null },
                {"LastName", null },
                {"Email", null },
                {"UserId", null }
            };*/
                GlobalConfig.SessionData["FirstName"] = SignupInput["FirstName"].ToString();
                GlobalConfig.SessionData["LastName"] = SignupInput["LastName"].ToString();
                GlobalConfig.SessionData["Email"] = SignupInput["Email"].ToString();

                UserSignupSuccessful = true;

                this.DialogResult = DialogResult.OK;
            }



        }
    }
}
