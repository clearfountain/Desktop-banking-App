
namespace BankAppWithSQLiteAndTests.UI
{
    partial class SignupForm
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
            this.signupBtn = new System.Windows.Forms.Button();
            this.backToHomeLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingsAccRadioButton = new System.Windows.Forms.RadioButton();
            this.currentAccRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(341, 372);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(112, 34);
            this.signupBtn.TabIndex = 29;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // backToHomeLabel
            // 
            this.backToHomeLabel.AutoSize = true;
            this.backToHomeLabel.Location = new System.Drawing.Point(95, 372);
            this.backToHomeLabel.Name = "backToHomeLabel";
            this.backToHomeLabel.Size = new System.Drawing.Size(166, 25);
            this.backToHomeLabel.TabIndex = 28;
            this.backToHomeLabel.TabStop = true;
            this.backToHomeLabel.Text = "Back to home page";
            this.backToHomeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backToHomeLabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Choose an account type : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingsAccRadioButton);
            this.groupBox1.Controls.Add(this.currentAccRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(341, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // savingsAccRadioButton
            // 
            this.savingsAccRadioButton.AutoSize = true;
            this.savingsAccRadioButton.Location = new System.Drawing.Point(0, 15);
            this.savingsAccRadioButton.Name = "savingsAccRadioButton";
            this.savingsAccRadioButton.Size = new System.Drawing.Size(364, 29);
            this.savingsAccRadioButton.TabIndex = 10;
            this.savingsAccRadioButton.TabStop = true;
            this.savingsAccRadioButton.Text = "Savings account(with 1000 initial deposit)";
            this.savingsAccRadioButton.UseVisualStyleBackColor = true;
            // 
            // currentAccRadioButton
            // 
            this.currentAccRadioButton.AutoSize = true;
            this.currentAccRadioButton.Location = new System.Drawing.Point(0, 45);
            this.currentAccRadioButton.Name = "currentAccRadioButton";
            this.currentAccRadioButton.Size = new System.Drawing.Size(162, 29);
            this.currentAccRadioButton.TabIndex = 11;
            this.currentAccRadioButton.TabStop = true;
            this.currentAccRadioButton.Text = "Current account";
            this.currentAccRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Reenter password : ";
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(341, 193);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.PasswordChar = '*';
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(296, 31);
            this.reenterPasswordTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter a password : ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(341, 156);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(296, 31);
            this.passwordTextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter your email : ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(341, 119);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(296, 31);
            this.emailTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter your last name : ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(341, 82);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(296, 31);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter yout first name :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(341, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(296, 31);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.backToHomeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reenterPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "SignupForm";
            this.Text = "Signup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.LinkLabel backToHomeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton savingsAccRadioButton;
        private System.Windows.Forms.RadioButton currentAccRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}