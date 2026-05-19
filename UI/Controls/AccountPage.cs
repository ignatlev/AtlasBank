using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank.UI.Controls
{
    public partial class AccountPage : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private List<BankAccount> _accounts = new List<BankAccount>();
        private readonly AccountService _accountService;

        public AccountPage()
        {
            InitializeComponent();
            GridHelper.SetupAccountsGrid(dgvAccounts);

            var notificationService = new NotificationService(new NotificationRepository());
            _accountService = new AccountService(new AccountRepository(), notificationService);
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
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount? account = GridHelper.GetSelectedItem(dgvAccounts, _accounts, "Please select an account.");
                if (account == null) return;

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to close \"{account.AccountName}\"? This cannot be undone.",
                    "Confirm Close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                _accountService.CloseAccount(account.Id);
                MessageBox.Show("Account closed.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRenameAccount_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount? account = GridHelper.GetSelectedItem(dgvAccounts, _accounts, "Please select an account.");
                if (account == null) return;

                string? newName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter a new name for the account:",
                    "Rename Account",
                    account.AccountName);

                if (string.IsNullOrWhiteSpace(newName)) return;

                _accountService.RenameAccount(account.Id, newName);
                MessageBox.Show("Account renamed.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtStartingBalance.Text))
                {
                    _accountService.Create(_currentUser.Id, txtAccountName.Text);
                }
                else
                {
                    if (!decimal.TryParse(txtStartingBalance.Text, out decimal startingBalance))
                    {
                        throw new Exception("Starting balance must be a valid number.");
                    }

                    _accountService.Create(_currentUser.Id, txtAccountName.Text, startingBalance);
                }

                MessageBox.Show("Account created!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAccountName.Clear();
                txtStartingBalance.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}