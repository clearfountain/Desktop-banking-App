
namespace BankAppWithSQLiteAndTests
{
    partial class ChooseAccountForDeposit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentBtn = new System.Windows.Forms.Button();
            this.savingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentBtn
            // 
            this.currentBtn.Location = new System.Drawing.Point(344, 256);
            this.currentBtn.Name = "currentBtn";
            this.currentBtn.Size = new System.Drawing.Size(112, 34);
            this.currentBtn.TabIndex = 5;
            this.currentBtn.Text = "current";
            this.currentBtn.UseVisualStyleBackColor = true;
            this.currentBtn.Visible = false;
            // 
            // savingsBtn
            // 
            this.savingsBtn.Location = new System.Drawing.Point(344, 161);
            this.savingsBtn.Name = "savingsBtn";
            this.savingsBtn.Size = new System.Drawing.Size(112, 34);
            this.savingsBtn.TabIndex = 4;
            this.savingsBtn.Text = "savings";
            this.savingsBtn.UseVisualStyleBackColor = true;
            this.savingsBtn.Visible = false;
            // 
            // ChooseAccountForDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentBtn);
            this.Controls.Add(this.savingsBtn);
            this.Name = "ChooseAccountForDeposit";
            this.Text = "Choose account for deposit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button currentBtn;
        private System.Windows.Forms.Button savingsBtn;
    }
}

