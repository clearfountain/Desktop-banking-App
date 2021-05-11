
namespace BankAppWithSQLiteAndTests.UI
{
    partial class TransferForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountToTransferTextbox = new System.Windows.Forms.NumericUpDown();
            this.accountNumberTextbox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountToTransferTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter amount to transfer(not less than 1 and not greater than 1,000,000)";
            // 
            // amountToTransferTextbox
            // 
            this.amountToTransferTextbox.Location = new System.Drawing.Point(109, 252);
            this.amountToTransferTextbox.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.amountToTransferTextbox.Name = "amountToTransferTextbox";
            this.amountToTransferTextbox.Size = new System.Drawing.Size(180, 31);
            this.amountToTransferTextbox.TabIndex = 7;
            this.amountToTransferTextbox.ValueChanged += new System.EventHandler(this.amountToTransferTextbox_ValueChanged);
            // 
            // accountNumberTextbox
            // 
            this.accountNumberTextbox.Location = new System.Drawing.Point(109, 138);
            this.accountNumberTextbox.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.accountNumberTextbox.Name = "accountNumberTextbox";
            this.accountNumberTextbox.Size = new System.Drawing.Size(180, 31);
            this.accountNumberTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter account number to transfer to : ";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountToTransferTextbox);
            this.Controls.Add(this.accountNumberTextbox);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "Enter transfer details";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountToTransferTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountToTransferTextbox;
        private System.Windows.Forms.NumericUpDown accountNumberTextbox;
        private System.Windows.Forms.Label label1;
    }
}