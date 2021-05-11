
namespace BankAppWithSQLiteAndTests.UI
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoutBtn = new System.Windows.Forms.Button();
            this.statementBtn = new System.Windows.Forms.Button();
            this.transferMoneyBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.getBalanceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(676, 98);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(112, 34);
            this.logoutBtn.TabIndex = 20;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // statementBtn
            // 
            this.statementBtn.Location = new System.Drawing.Point(339, 318);
            this.statementBtn.Name = "statementBtn";
            this.statementBtn.Size = new System.Drawing.Size(276, 34);
            this.statementBtn.TabIndex = 19;
            this.statementBtn.Text = "generate statement of account";
            this.statementBtn.UseVisualStyleBackColor = true;
            // 
            // transferMoneyBtn
            // 
            this.transferMoneyBtn.Location = new System.Drawing.Point(339, 190);
            this.transferMoneyBtn.Name = "transferMoneyBtn";
            this.transferMoneyBtn.Size = new System.Drawing.Size(276, 34);
            this.transferMoneyBtn.TabIndex = 18;
            this.transferMoneyBtn.Text = "transfer";
            this.transferMoneyBtn.UseVisualStyleBackColor = true;
            this.transferMoneyBtn.Click += new System.EventHandler(this.transferMoneyBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(339, 256);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(276, 34);
            this.withdrawBtn.TabIndex = 17;
            this.withdrawBtn.Text = "withdraw money";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(12, 256);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(276, 34);
            this.depositBtn.TabIndex = 16;
            this.depositBtn.Text = "deposit money";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(12, 190);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(276, 34);
            this.createAccountBtn.TabIndex = 15;
            this.createAccountBtn.Text = "create account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // getBalanceBtn
            // 
            this.getBalanceBtn.Location = new System.Drawing.Point(12, 318);
            this.getBalanceBtn.Name = "getBalanceBtn";
            this.getBalanceBtn.Size = new System.Drawing.Size(276, 34);
            this.getBalanceBtn.TabIndex = 14;
            this.getBalanceBtn.Text = "display balance";
            this.getBalanceBtn.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.statementBtn);
            this.Controls.Add(this.transferMoneyBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.getBalanceBtn);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button statementBtn;
        private System.Windows.Forms.Button transferMoneyBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Button getBalanceBtn;
    }
}