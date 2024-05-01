namespace BANKING_APPLICATION
{
    public partial class BankForm : Form
    {

        private Bank bank;
        public BankForm()
        {
            InitializeComponent();

            bank = new Bank();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void txtAccountFrom_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            int accountNumber = 0;

            if (radChecking.Checked)
            {
                accountNumber = Bank.NextAccountNumber();
                Account account = new CheckingAccount(accountNumber);
                bank.AddAccount(account);


            }

            else
            {
                accountNumber = Bank.NextAccountNumber();
                Account account = new SavingsAccount(accountNumber);
                bank.AddAccount(account);
            }
            //add to combobox
            this.cboAccounts.Items.Clear();

            foreach (int number in bank.GetAccountNumbers())
            {
                this.cboAccounts.Items.Add(number);
            }
            MessageBox.Show($"Account has been created with id {accountNumber}");

            //46:15
        }

        /// <summary>
        /// Display Account details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cboAccounts.SelectedIndex;

            if (index >= 0)
            {
                int accountNumber = int.Parse(this.cboAccounts.SelectedItem.ToString());

                Account account = bank.GetAccount(accountNumber);

                txtAccountFrom.Text = $"{account.AccountNumber}";
                txtBalance.Text = account.Balance.ToString("C02");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // account must be selected, amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {
                //amount
                double amount = 0;

                if (double.TryParse(txtAmount.Text, out amount))
                {
                    int accountNumber = 0;
                    int.TryParse(txtAccountFrom.Text, out accountNumber);

                    if (bank.Deposit(accountNumber, amount))
                    {
                        MessageBox.Show("Deposit Transaction Successful!");
                        txtAmount.Text = "";
                        txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                    }
                    else
                    {
                        MessageBox.Show("Deposit Transaction failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You have entered an invalid amount.");
                }
            }
            else
            {
                MessageBox.Show("Please select an Account to perform a transaction");
            }
        }

        /// <summary>
        /// Withdraw amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // account must be selected, amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {
                //amount
                double amount = 0;

                if (double.TryParse(txtAmount.Text, out amount))
                {
                    int accountNumber = 0;
                    int.TryParse(txtAccountFrom.Text, out accountNumber);

                    if (bank.Withdraw(accountNumber, amount))
                    {
                        MessageBox.Show("Withdraw Transaction Successful!");
                        txtAmount.Text = "";
                        txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                    }
                    else
                    {
                        MessageBox.Show("Withdraw Transaction failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You have entered an invalid amount.");
                }
            }
            else
            {
                MessageBox.Show("Please select an Account to perform a transaction");
            }
        }

        /// <summary>
        /// Transfer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // account must be selected, amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {
                //need to get ToAccountNumber
                int toAccountNumber = 0;
                if (int.TryParse(txtAccountFrom.Text, out toAccountNumber))
                {
                    //amount
                    double amount = 0;

                    if (double.TryParse(txtAmount.Text, out amount))
                    {
                        int accountNumber = 0;
                        int.TryParse(txtAccountFrom.Text, out accountNumber);

                        if (bank.Transfer(accountNumber, toAccountNumber, amount))
                        {
                            MessageBox.Show("Transfer Transaction Successful!");
                            txtAmount.Text = "";
                            txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                        }
                        else
                        {
                            MessageBox.Show("Transfer Transaction failed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have entered an invalid amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Transfer account number");
                }

            }
            else
            {
                MessageBox.Show("Please select an Account to perform a transaction");
            }
        }

        /// <summary>
        /// apply interest to selected amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            // account must be selected, amount provided
            int idx = this.cboAccounts.SelectedIndex;

            if (idx >= 0)
            {

                int accountNumber = 0;
                int.TryParse(txtAccountFrom.Text, out accountNumber);
                double amount = bank.ApplyInterest(accountNumber);

                if (amount >= 0)
                {
                    MessageBox.Show($"Interest Added: {amount}");
                    txtAmount.Text = "";
                    txtBalance.Text = bank.GetAccount(accountNumber).Balance.ToString("C02");
                }
                else
                {
                    MessageBox.Show("Transaction failed!");
                }

            }
            else
            {
                MessageBox.Show("Please select an Account to perform a transaction");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64); // Dark gray
        }
    }
}//TRANSFER DOES NOT TRANSFER MONEY ONLY APPLIES TAX