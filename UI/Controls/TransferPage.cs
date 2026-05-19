using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;

namespace Bank.UI.Controls
{
    public partial class TransferPage : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private List<BankAccount> _accounts = new List<BankAccount>();
        private readonly TransactionService _transactionService;
        private readonly AccountService _accountService;


        public TransferPage()
        {
            InitializeComponent();
            GridHelper.SetupAccountsGrid(dgvAccounts);

            var notificationService = new NotificationService(new NotificationRepository());
            _accountService = new AccountService(new AccountRepository(), notificationService);
            _transactionService = new TransactionService(new TransactionRepository(), _accountService, notificationService);


            cmbPaymentType.Items.AddRange(new string[]
            {
                "Standard Transfer",
                "Instant Transfer",
                "Standing Order",
                "Bill Payment"
            });
            cmbPaymentType.SelectedIndex = 0;
        }

        public void SetUser(User user)
        {
            _currentUser = user;
        }

        public void LoadData()
        {
            if (_currentUser == null)
            {
                return;
            }

            _accounts = _accountService.GetByUserId(_currentUser.Id);
            GridHelper.LoadAccounts(dgvAccounts, _accounts);

            cmbAccount.Items.Clear();

            if (_accounts.Count == 0)
            {
                cmbAccount.Items.Add("No accounts available");
                btnConfirm.Enabled = false;
                return;
            }

            btnConfirm.Enabled = true;

            foreach (BankAccount acc in _accounts)
            {
                cmbAccount.Items.Add(string.Format("{0} | {1} | {2:N2}€", acc.AccountName, acc.AccountNumber, acc.Balance));
            }

            cmbAccount.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                return;
            }

            if (cmbAccount.SelectedIndex < 0 || cmbAccount.SelectedIndex >= _accounts.Count)
            {
                MessageBox.Show("Please select an account to transfer from.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPaymentType.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment type.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BankAccount fromAccount = _accounts[cmbAccount.SelectedIndex];

            string? paymentType = cmbPaymentType.SelectedItem.ToString();

            if (paymentType == null)
            {
                throw new Exception("Please select a payment type.");
            }

            string summary =
                "From:        " + fromAccount.AccountName + " (" + fromAccount.AccountNumber + ")\n" +
                "To:          " + txtBeneficiaryAccount.Text.Trim().ToUpper() + "\n" +
                "Amount:      " + txtAmount.Text.Trim() + "€" + "\n" +
                "Type:        " + paymentType + "\n" +
                "Details:     " + txtDetails.Text.Trim() + "\n\n" +
                "Confirm this transfer?";

            if (MessageBox.Show(summary, "Confirm Transfer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Transaction transaction = _transactionService.Transfer(
                    _currentUser.Id,
                    fromAccount.Id,
                    paymentType,
                    txtBeneficiaryAccount.Text,
                    txtAmount.Text,
                    txtDetails.Text
                );

                MessageBox.Show(
                    "✓ Transfer of €" + txtAmount.Text.Trim() + " completed successfully!\n\n" +
                    "To: " + txtBeneficiaryAccount.Text.Trim().ToUpper() + "\n" +
                    "Reference: " + txtDetails.Text.Trim(),
                    "Transfer Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transfer Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtBeneficiaryAccount.Clear();
            txtAmount.Clear();
            txtDetails.Clear();
            cmbPaymentType.SelectedIndex = 0;
        }
    }
}