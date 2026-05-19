namespace Bank.Models
{
    public class Card : BaseModel
    {
        private int _accountId;
        public int AccountId { get { return _accountId; } }

        private int _userId;
        public int UserId { get { return _userId; } }

        private string _cardNumber = string.Empty;
        public string CardNumber { get { return _cardNumber; } }

        private string _cardholderName = string.Empty;
        public string CardholderName { get { return _cardholderName; } }

        private DateTime _expiryDate;
        public DateTime ExpiryDate { get { return _expiryDate; } }

        private string _pinHash = string.Empty;
        public string PinHash { get { return _pinHash; } }

        private string _cvvHash = string.Empty;
        public string CvvHash { get { return _cvvHash; } }

        private bool _isActive;
        public bool IsActive { get { return _isActive; } }

        private decimal _dailyLimit;
        public decimal DailyLimit { get { return _dailyLimit; } }

        private bool _internetEnabled;
        public bool InternetEnabled { get { return _internetEnabled; } }

        private string _cardType = string.Empty;
        public string CardType { get { return _cardType; } }

        private string _cardBrand = string.Empty;
        public string CardBrand { get { return _cardBrand; } }

        public void SetAccountId(int accountId) { _accountId = accountId; }
        public void SetUserId(int userId) { _userId = userId; }
        public void SetCardNumber(string number) { _cardNumber = number; }
        public void SetCardholderName(string name) { _cardholderName = name; }
        public void SetExpiryDate(DateTime date) { _expiryDate = date; }
        public void SetPinHash(string pin) { _pinHash = pin; }
        public void SetCvvHash(string cvv) { _cvvHash = cvv; }

        public void SetCardType(string cardType)
        {
            if (string.IsNullOrWhiteSpace(cardType))
                throw new ArgumentException("Card type cannot be empty.");
            _cardType = cardType.Trim();
        }

        public void SetCardBrand(string cardBrand)
        {
            if (string.IsNullOrWhiteSpace(cardBrand))
                throw new ArgumentException("Card brand cannot be empty.");
            _cardBrand = cardBrand.Trim();
        }

        public void SetDailyLimit(decimal limit)
        {
            if (limit < 10) throw new ArgumentException("Daily limit must be at least 10€.");
            if (limit > 50000) throw new ArgumentException("Daily limit cannot exceed 50,000€.");
            _dailyLimit = limit;
        }

        public void Activate() { _isActive = true; }
        public void Block()
        {
            if (!_isActive) throw new InvalidOperationException("Card is already blocked.");
            _isActive = false;
        }

        public void Unblock()
        {
            if (_isActive) throw new InvalidOperationException("Card is already active.");
            _isActive = true;
        }

        public void EnableInternet() { _internetEnabled = true; }
        public void DisableInternet() { _internetEnabled = false; }
    }
}