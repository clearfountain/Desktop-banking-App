
namespace BankAppWithSQLiteAndTests.UI
{
    partial class ConfirmTransferForm
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
            this.confirmTransferBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmTransferBtn
            // 
            this.confirmTransferBtn.Location = new System.Drawing.Point(478, 268);
            this.confirmTransferBtn.Name = "confirmTransferBtn";
            this.confirmTransferBtn.Size = new System.Drawing.Size(193, 34);
            this.confirmTransferBtn.TabIndex = 3;
            this.confirmTransferBtn.Text = "Confirm transfer";
            this.confirmTransferBtn.UseVisualStyleBackColor = true;
            this.confirmTransferBtn.Click += new System.EventHandler(this.confirmTransferBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ConfirmTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmTransferBtn);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmTransferForm";
            this.Text = "Confirm transfer";
            this.Load += new System.EventHandler(this.ConfirmTransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmTransferBtn;
        private System.Windows.Forms.Label label1;
    }
}