namespace BANKING_APPLICATION
{
    partial class BankForm
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
            btnCreate = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnTransfer = new Button();
            btnApply = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboAccounts = new ComboBox();
            txtAccountFrom = new TextBox();
            txtAmount = new TextBox();
            txtBalance = new TextBox();
            txtAccountTo = new TextBox();
            label7 = new Label();
            radChecking = new RadioButton();
            radSavings = new RadioButton();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(113, 428);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 49);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(321, 428);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(131, 49);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(563, 428);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(131, 49);
            btnWithdraw.TabIndex = 0;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(113, 551);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(131, 49);
            btnTransfer.TabIndex = 0;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(321, 551);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(131, 49);
            btnApply.TabIndex = 0;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(563, 551);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 49);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 137);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(138, 15);
            label1.TabIndex = 1;
            label1.Text = "Account Number (From)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 20);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 1;
            label2.Text = "Bank application";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 245);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 135);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 1;
            label4.Text = "Account Number (TO)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 245);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 1;
            label5.Text = "Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 72);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 1;
            label6.Text = "Select Account";
            label6.Click += label6_Click;
            // 
            // cboAccounts
            // 
            cboAccounts.AccessibleName = "";
            cboAccounts.FormattingEnabled = true;
            cboAccounts.Location = new Point(380, 69);
            cboAccounts.Name = "cboAccounts";
            cboAccounts.Size = new Size(121, 23);
            cboAccounts.TabIndex = 2;
            cboAccounts.SelectedIndexChanged += cboAccounts_SelectedIndexChanged;
            // 
            // txtAccountFrom
            // 
            txtAccountFrom.Location = new Point(191, 132);
            txtAccountFrom.Name = "txtAccountFrom";
            txtAccountFrom.Size = new Size(100, 23);
            txtAccountFrom.TabIndex = 3;
            txtAccountFrom.TextChanged += txtAccountFrom_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(191, 242);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(463, 242);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 3;
            // 
            // txtAccountTo
            // 
            txtAccountTo.Location = new Point(463, 129);
            txtAccountTo.Name = "txtAccountTo";
            txtAccountTo.Size = new Size(100, 23);
            txtAccountTo.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 334);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 1;
            label7.Text = "Select Account Type:";
            label7.Click += label6_Click;
            // 
            // radChecking
            // 
            radChecking.AutoSize = true;
            radChecking.Location = new Point(303, 334);
            radChecking.Name = "radChecking";
            radChecking.Size = new Size(116, 19);
            radChecking.TabIndex = 4;
            radChecking.TabStop = true;
            radChecking.Text = "Checking Accont";
            radChecking.UseVisualStyleBackColor = true;
            // 
            // radSavings
            // 
            radSavings.AutoSize = true;
            radSavings.Location = new Point(449, 334);
            radSavings.Name = "radSavings";
            radSavings.Size = new Size(113, 19);
            radSavings.TabIndex = 4;
            radSavings.TabStop = true;
            radSavings.Text = "Savings Account";
            radSavings.UseVisualStyleBackColor = true;
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 666);
            Controls.Add(radSavings);
            Controls.Add(radChecking);
            Controls.Add(txtAccountTo);
            Controls.Add(txtBalance);
            Controls.Add(txtAmount);
            Controls.Add(txtAccountFrom);
            Controls.Add(cboAccounts);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnApply);
            Controls.Add(btnWithdraw);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnCreate);
            Name = "BankForm";
            Text = "Bank application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnTransfer;
        private Button btnApply;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboAccounts;
        private TextBox txtAccountFrom;
        private TextBox txtAmount;
        private TextBox txtBalance;
        private TextBox txtAccountTo;
        private Label label7;
        private RadioButton radChecking;
        private RadioButton radSavings;
    }
}