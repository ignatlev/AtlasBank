using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;

namespace Bank.UI.Controls
{
    public partial class HomeMain : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private readonly TransactionService _transactionService;
        private readonly AccountService _accountService;
        private readonly CardService _cardService;

        public HomeMain()
        {
            InitializeComponent();
            GridHelper.SetupAccountsGrid(dgvAccounts);
            GridHelper.SetupCardsGrid(dgvCards);
            GridHelper.SetupTransactionsGrid(dgvTransactions);

            var notificationService = new NotificationService(new NotificationRepository());
            _accountService = new AccountService(new AccountRepository(), notificationService);
            _cardService = new CardService(new CardRepository(), notificationService);
            _transactionService = new TransactionService(new TransactionRepository(), _accountService, notificationService);
        }

        public void SetUser(User user)
        {
            _currentUser = user;
        }

        public void LoadData()
        {
            if (_currentUser == null) return;
            List<BankAccount> accounts = _accountService.GetByUserId(_currentUser.Id);
            List<Card> cards = _cardService.GetByUserId(_currentUser.Id);
            List<Transaction> transactions = _transactionService.GetRecent(_currentUser.Id);

            lblWelcome.Text = string.Format("Welcome back, {0} {1}!", _currentUser.Name, _currentUser.Surname);
            lblTotalBalance.Text = string.Format("Total Balance: {0:N2}€", _accountService.GetTotalBalance(_currentUser.Id));
            GridHelper.LoadAccounts(dgvAccounts, accounts);
            GridHelper.LoadCards(dgvCards, cards);
            GridHelper.LoadTransactions(dgvTransactions, transactions);
        }
    }
}