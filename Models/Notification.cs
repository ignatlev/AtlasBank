namespace Bank.Models
{
    public class Notification : BaseModel
    {
        private int _userId;
        public int UserId { get { return _userId; } }

        private string _message = string.Empty;
        public string Message { get { return _message; } }

        private string _type = string.Empty;
        public string Type { get { return _type; } }

        private bool _isRead;
        public bool IsRead { get { return _isRead; } }

        public void SetUserId(int userId) { _userId = userId; }

        public void SetMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message cannot be empty.");
            _message = message.Trim();
        }

        public void SetType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type cannot be empty.");
            _type = type.Trim();
        }

        public void MarkAsRead() { _isRead = true; ; }
    }
}