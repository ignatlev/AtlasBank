using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class UserService
    {
        private readonly IUserRepository _repo;
        private readonly NotificationService _notificationService;

        public UserService(IUserRepository repo, NotificationService notificationService)
        {
            _repo = repo;
            _notificationService = notificationService;
        }

        public User Register(string username, string name, string surname, string email, string password, string confirmPassword)
        {
            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");

            User user = new User();
            user.SetUsername(username.Trim());
            user.SetName(name.Trim());
            user.SetSurname(surname.Trim());
            user.SetEmail(email.Trim().ToLower());
            user.SetPasswordHash(BCrypt.Net.BCrypt.HashPassword(password));
            user.SetCreatedAt(DateTime.UtcNow);

            _repo.Save(user);

            return user;
        }

        public User Login(string username, string password)
        {
            User? user = _repo.FindByUsername(username.Trim());

            if (user == null)
            {
                throw new Exception("No account found with that username.");
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                throw new Exception("Wrong password.");
            _notificationService.UserLoggedIn(user.Id, user.Username);

            return user;
        }
        public User? GetByEmail(string email)
        {
            return _repo.GetByEmail(email);
        }

        public void UpdatePassword(int userId, string newHashedPassword)
        {
            _repo.UpdatePassword(userId, newHashedPassword);
        }
    }
}