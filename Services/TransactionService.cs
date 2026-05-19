using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class TransactionService
    {
        private readonly ITransactionRepository _transactionRepo;
        private readonly AccountService _accountService;
        private readonly NotificationService _notificationService;

        public TransactionService(ITransactionRepository repo, AccountService accountService, NotificationService notificationService)
        {
            _transactionRepo = repo;
            _accountService = accountService;
            _notificationService = notificationService;
        }

        public List<Transaction> GetRecent(int userId)
        {
            return _transactionRepo.GetByUserId(userId);
        }

        public List<Transaction> GetByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            return _transactionRepo.GetByUserId(userId, startDate, endDate);
        }

        public Transaction Transfer(int userId, int fromAccountId, string paymentType, string beneficiaryAccount, string amountText, string details)
        {
            decimal amount = decimal.Parse(amountText);
            beneficiaryAccount = beneficiaryAccount.Trim().ToUpper();

            List<BankAccount> senderAccounts = _accountService.GetByUserId(userId);
            BankAccount? fromAccount = senderAccounts.FirstOrDefault(a => a.Id == fromAccountId);

            if (fromAccount == null)
                throw new Exception("Selected account not found.");

            if (fromAccount.AccountNumber.Equals(beneficiaryAccount, StringComparison.OrdinalIgnoreCase))
                throw new Exception("You cannot transfer to the same account.");

            BankAccount? toAccount = _accountService.GetByAccountNumber(beneficiaryAccount);

            if (toAccount == null)
                throw new Exception("Beneficiary account number does not exist.");

            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);

            Transaction transaction = new Transaction();
            transaction.SetAccountId(fromAccountId);
            transaction.SetToAccountId(toAccount.Id);
            transaction.SetToAccountNumber(beneficiaryAccount);
            transaction.SetDescription(string.Format("{0}: {1}", paymentType, details.Trim()));
            transaction.SetAmount(amount);
            transaction.SetType(TransactionType.Expense);
            transaction.SetCreatedAt(DateTime.UtcNow);

            _transactionRepo.SaveTransfer(transaction, fromAccount, toAccount, amount, beneficiaryAccount);
            _notificationService.TransferSent(userId, amount, beneficiaryAccount);
            _notificationService.TransferReceived(toAccount.UserId, amount, fromAccount.AccountNumber);

            return transaction;
        }
    }
}