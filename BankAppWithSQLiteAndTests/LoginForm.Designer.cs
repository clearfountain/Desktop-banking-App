
namespace BankAppWithSQLiteAndTests.UI
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.backToHomePageBtn = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(560, 332);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 34);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // backToHomePageBtn
            // 
            this.backToHomePageBtn.AutoSize = true;
            this.backToHomePageBtn.Location = new System.Drawing.Point(128, 341);
            this.backToHomePageBtn.Name = "backToHomePageBtn";
            this.backToHomePageBtn.Size = new System.Drawing.Size(166, 25);
            this.backToHomePageBtn.TabIndex = 10;
            this.backToHomePageBtn.TabStop = true;
            this.backToHomePageBtn.Text = "Back to home page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(326, 185);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(346, 31);
            this.loginPasswordTextBox.TabIndex = 7;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Location = new System.Drawing.Point(326, 85);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(346, 31);
            this.loginEmailTextBox.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.backToHomePageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginEmailTextBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel backToHomePageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox loginEmailTextBox;
    }
}