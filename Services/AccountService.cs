using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _repo;
        private readonly NotificationService _notificationService;

        public AccountService(IAccountRepository repo, NotificationService notificationService)
        {
            _repo = repo;
            _notificationService = notificationService;
        }

        public BankAccount Create(int userId, string accountName)
        {
            BankAccount account = new BankAccount();
            account.SetUserId(userId);
            account.SetAccountName(accountName.Trim());
            account.SetCreatedAt(DateTime.UtcNow);
            _repo.Save(account);
            _notificationService.AccountCreated(userId, account.AccountName);
            return account;
        }

        public BankAccount Create(int userId, string accountName, decimal startingBalance)
        {
            BankAccount account = new BankAccount();
            account.SetUserId(userId);
            account.SetAccountName(accountName.Trim());
            account.SetCreatedAt(DateTime.UtcNow);
            account.SetInitialBalance(startingBalance);
            _repo.Save(account);
            _notificationService.AccountCreated(userId, account.AccountName);
            return account;
        }

        public List<BankAccount> GetByUserId(int userId)
        {
            return _repo.GetByUserId(userId);
        }

        public BankAccount? GetByAccountNumber(string accountNumber)
        {
            return _repo.GetByAccountNumber(accountNumber);
        }

        public bool AccountNumberExists(string accountNumber)
        {
            return _repo.AccountNumberExists(accountNumber);
        }

        public void CloseAccount(int accountId)
        {
            _repo.Delete(accountId);
        }

        public void RenameAccount(int accountId, string newName)
        {
            newName = newName.Trim();
            _repo.Rename(accountId, newName);
        }
        public decimal GetTotalBalance(int userId)
        {
            List<BankAccount> accounts = _repo.GetByUserId(userId);

            decimal totalBalance = 0;
            foreach (BankAccount acc in accounts)
            {
                totalBalance += acc.Balance;
            }

            return totalBalance;
        }
    }
}