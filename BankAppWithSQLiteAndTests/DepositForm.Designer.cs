
namespace BankAppWithSQLiteAndTests.UI
{
    partial class DepositForm
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
            this.depositAmountBox = new System.Windows.Forms.NumericUpDown();
            this.depositAmountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // depositAmountBox
            // 
            this.depositAmountBox.Location = new System.Drawing.Point(167, 224);
            this.depositAmountBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.depositAmountBox.Name = "depositAmountBox";
            this.depositAmountBox.Size = new System.Drawing.Size(180, 31);
            this.depositAmountBox.TabIndex = 10;
            // 
            // depositAmountBtn
            // 
            this.depositAmountBtn.Location = new System.Drawing.Point(561, 272);
            this.depositAmountBtn.Name = "depositAmountBtn";
            this.depositAmountBtn.Size = new System.Drawing.Size(112, 34);
            this.depositAmountBtn.TabIndex = 9;
            this.depositAmountBtn.Text = "Enter";
            this.depositAmountBtn.UseVisualStyleBackColor = true;
            this.depositAmountBtn.Click += new System.EventHandler(this.depositAmountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter deposit amount (minimum of 1 and maximum of 1,000,000: ";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositAmountBox);
            this.Controls.Add(this.depositAmountBtn);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "Input deposit amount";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositAmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown depositAmountBox;
        private System.Windows.Forms.Button depositAmountBtn;
        private System.Windows.Forms.Label label1;
    }
}