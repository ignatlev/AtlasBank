using System.Text.RegularExpressions;

namespace Bank.Models
{
    public class BankAccount : BaseModel
    {
        private int _userId;
        public int UserId { get { return _userId; } }

        private string _accountNumber = string.Empty;
        public string AccountNumber { get { return _accountNumber; } }

        private string _accountName = string.Empty;
        public string AccountName { get { return _accountName; } }

        private decimal _balance;
        public decimal Balance { get { return _balance; } }

        public void SetUserId(int userId) { _userId = userId; }

        public void SetAccountNumber(string accountNumber)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be empty.");
            _accountNumber = accountNumber.Trim();
        }

        public void SetAccountName(string accountName)
        {
            if (string.IsNullOrWhiteSpace(accountName))
                throw new ArgumentException("Account name is required.");
            if (!Regex.IsMatch(accountName.Trim(), @"^[a-zA-Z0-9 ]+$"))
                throw new ArgumentException("Account name can only contain letters, numbers and spaces.");
            _accountName = accountName.Trim();
        }

        public void SetInitialBalance(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Initial balance cannot be negative.");
            _balance = amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");
            if (amount > _balance)
                throw new Exception(string.Format("Error. Available balance: {0:N2}€", _balance));
            _balance -= amount;
        }
    }
}