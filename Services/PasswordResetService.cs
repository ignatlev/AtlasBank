using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class PasswordResetService
    {
        private readonly IPasswordResetRepository _repo;
        private readonly EmailService _emailService;
        private readonly UserService _userService;
        private readonly NotificationService _notificationService;

        public PasswordResetService(IPasswordResetRepository repo, EmailService emailService, UserService userService, NotificationService notificationService)
        {
            _repo = repo;
            _emailService = emailService;
            _userService = userService;
            _notificationService = notificationService;
        }

        public void SendCode(string email)
        {
            User? user = _userService.GetByEmail(email);
            if (user == null) throw new Exception("No account found with that email.");
            string code = new Random().Next(100000, 999999).ToString();
            _repo.Save(user.Id, code, DateTime.UtcNow.AddMinutes(10));
            _emailService.SendResetCode(email, code);
        }

        public void ResetPassword(string email, string code, string newPassword, string confirmPassword)
        {
           if (newPassword != confirmPassword)
            {
                throw new Exception("Passwords do not match.");
            }
            User? user = _userService.GetByEmail(email);
            if (user == null) throw new Exception("User not found.");
            if (!_repo.IsValid(user.Id, code))
                throw new Exception("Invalid or expired reset code.");
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            _userService.UpdatePassword(user.Id, hashedPassword);
            _notificationService.PasswordChange(user.Id);
            _repo.MarkUsed(user.Id, code);
        }
    }
}