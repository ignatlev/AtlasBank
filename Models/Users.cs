using System.Text.RegularExpressions;

namespace Bank.Models
{
    public class User : BaseModel
    {
        private string _username = string.Empty;
        public string Username { get { return _username; } }

        private string _name = string.Empty;
        public string Name { get { return _name; } }

        private string _surname = string.Empty;
        public string Surname { get { return _surname; } }

        private string _email = string.Empty;
        public string Email { get { return _email; } }

        private string _passwordHash = string.Empty;
        public string PasswordHash { get { return _passwordHash; } }

        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required.");
            if (username.Trim().Length < 3)
                throw new ArgumentException("Username must be at least 3 characters.");
            _username = username.Trim();
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("First name is required.");
            if (!Regex.IsMatch(name.Trim(), @"^[a-zA-Z]+$"))
                throw new ArgumentException("First name can only contain letters.");
            _name = name.Trim();
        }

        public void SetSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("Last name is required.");
            if (!Regex.IsMatch(surname.Trim(), @"^[a-zA-Z]+$"))
                throw new ArgumentException("Last name can only contain letters.");
            _surname = surname.Trim();
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.");
            if (!Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Please enter a valid email address.");
            _email = email.Trim().ToLower();
        }

        public void SetPasswordHash(string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password hash cannot be empty.");
            _passwordHash = passwordHash;
        }
    }
}