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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(GlobalConfig.AuthRepositoryInstance);
            loginForm.FormClosed += new FormClosedEventHandler(Form_Closed);

            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                bool loginSuccess = loginForm.UserLoginSuccessful;

                loginForm.Dispose();
                if (loginSuccess)
                {
                    DashboardForm dboard = new DashboardForm(GlobalConfig.AccountRepositoryInstance);
                    dboard.FormClosed += new FormClosedEventHandler(Form_Closed);

                    this.Hide();
                    if (dboard.ShowDialog(this) == DialogResult.OK)
                    {
                        dboard.Dispose();
                        this.Show();
                    }
                }
            }
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {

            this.Show();

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignupForm signupForm = new SignupForm(GlobalConfig.AuthRepositoryInstance);
            signupForm.FormClosed += new FormClosedEventHandler(Form_Closed);

            if (signupForm.ShowDialog(this) == DialogResult.OK)
            {
                bool signupSuccess = signupForm.UserSignupSuccessful;
                signupForm.Dispose();

                if (signupSuccess)
                {
                    DashboardForm dboard = new DashboardForm(GlobalConfig.AccountRepositoryInstance);
                    dboard.FormClosed += new FormClosedEventHandler(Form_Closed);

                    this.Hide();
                    if (dboard.ShowDialog(this) == DialogResult.OK)
                    {
                        dboard.Dispose();
                        this.Show();
                    }
                }
            }
        }
    }
}
