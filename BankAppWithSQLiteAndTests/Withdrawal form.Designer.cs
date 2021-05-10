
namespace BankAppWithSQLiteAndTests.UI
{
    partial class WithdrawalForm
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
            this.withdrawalAmountBox = new System.Windows.Forms.NumericUpDown();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawalAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawalAmountBox
            // 
            this.withdrawalAmountBox.Location = new System.Drawing.Point(129, 202);
            this.withdrawalAmountBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.withdrawalAmountBox.Name = "withdrawalAmountBox";
            this.withdrawalAmountBox.Size = new System.Drawing.Size(180, 31);
            this.withdrawalAmountBox.TabIndex = 12;
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.Location = new System.Drawing.Point(541, 283);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(112, 34);
            this.withdrawalBtn.TabIndex = 11;
            this.withdrawalBtn.Text = "Enter";
            this.withdrawalBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter amount to withdraw (minimum of 1 and maximum of 1,000,000: ";
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withdrawalAmountBox);
            this.Controls.Add(this.withdrawalBtn);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawalForm";
            this.Text = "Amount to withdraw";
            ((System.ComponentModel.ISupportInitialize)(this.withdrawalAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown withdrawalAmountBox;
        private System.Windows.Forms.Button withdrawalBtn;
        private System.Windows.Forms.Label label1;
    }
}