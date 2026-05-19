namespace Bank.Models
{
    public enum TransactionType { Income, Expense }

    public class Transaction : BaseModel
    {
        private int _accountId;
        public int AccountId { get { return _accountId; } }

        private string _accountName = string.Empty;
        public string AccountName { get { return _accountName; } }

        private string _accountNumber = string.Empty;
        public string AccountNumber { get { return _accountNumber; } }

        private int? _toAccountId;
        public int? ToAccountId { get { return _toAccountId; } }

        private string _toAccountNumber = string.Empty;
        public string ToAccountNumber { get { return _toAccountNumber; } }

        private string _description = string.Empty;
        public string Description { get { return _description; } }

        private decimal _amount;
        public decimal Amount { get { return _amount; } }

        private TransactionType _type;
        public TransactionType Type { get { return _type; } }

        public void SetAccountId(int accountId) { _accountId = accountId; }
        public void SetAccountName(string name) { _accountName = name; }
        public void SetAccountNumber(string number) { _accountNumber = number; }
        public void SetToAccountId(int? toAccountId) { _toAccountId = toAccountId; }
        public void SetToAccountNumber(string number) { _toAccountNumber = number; }
        public void SetType(TransactionType type) { _type = type; }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty.");
            _description = description.Trim();
        }

        public void SetAmount(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Transaction amount must be positive.");
            _amount = amount;
        }
    }
}