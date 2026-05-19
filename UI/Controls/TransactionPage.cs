using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;

namespace Bank.UI.Controls
{
    public partial class TransactionPage : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private readonly TransactionService _transactionService;

        public TransactionPage()
        {
            InitializeComponent();
            GridHelper.SetupTransactionsGrid(dgvTransactions);

            var notificationService = new NotificationService(new NotificationRepository());
            var accountService = new AccountService(new AccountRepository(), notificationService);
            _transactionService = new TransactionService(new TransactionRepository(), accountService, notificationService);
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

            List<Transaction> transactions = _transactionService.GetRecent(_currentUser.Id);
            GridHelper.LoadTransactions(dgvTransactions, transactions);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                return;
            }

            try
            {
                List<Transaction> transactions = _transactionService.GetByDateRange(
                    _currentUser.Id,
                    dateTimePicker1.Value.Date,
                    dateTimePicker2.Value.Date);

                GridHelper.LoadTransactions(dgvTransactions, transactions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}