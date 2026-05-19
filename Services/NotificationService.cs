using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class NotificationService
    {
        private readonly INotificationRepository _repo;

        public NotificationService(INotificationRepository repo)
        {
            _repo = repo;
        }

        private void Push(int userId, string message, string type)
        {
            Notification notification = new Notification();
            notification.SetUserId(userId);
            notification.SetMessage(message);
            notification.SetType(type);
            notification.SetCreatedAt(DateTime.UtcNow);
            _repo.Save(notification);
        }

        public void AccountCreated(int userId, string accountName)
        {
            Push(userId, string.Format("A new account \"{0}\" has been successfully created.", accountName), "Account");
        }

        public void CardCreated(int userId, string cardNumber, string cardType)
        {
            Push(userId, string.Format("Your {0} card: {1} has been issued.", cardType, cardNumber), "Card");
        }

        public void CardBlocked(int userId, string cardNumber)
        {
            Push(userId, string.Format("Your card: {0} has been temporarily blocked.", cardNumber), "Card");
        }

        public void CardUnblocked(int userId, string cardNumber)
        {
            Push(userId, string.Format("Your card ending in {0} has been unblocked and is ready for use.", cardNumber), "Card");
        }

        public void CardClosed(int userId, string cardNumber)
        {
            Push(userId, string.Format("Your card: {0} has been permanently closed.", cardNumber), "Card");
        }

        public void CardPinChanged(int userId, string cardNumber)
        {
            Push(userId, string.Format("The PIN for your card: {0} has been successfully updated.", cardNumber), "Card");
        }

        public void TransferSent(int userId, decimal amount, string toAccount)
        {
            Push(userId, string.Format("A transfer of {0:N2}€ has been successfully sent to {1}.", amount, toAccount), "Transfer");
        }

        public void TransferReceived(int userId, decimal amount, string fromAccount)
        {
            Push(userId, string.Format("You have received {0:N2}€ from {1}.", amount, fromAccount), "Transfer");
        }

        public void UserLoggedIn(int userId, string username)
        {
            Push(userId, string.Format("A login to your account \"{0}\" was detected.", username), "Login");
        }

        public void PasswordChange(int userId)
        {
            Push(userId, string.Format("The password for your account has been changed."), "Change");
        }

        public List<Notification> GetAll(int userId)
        {
            return _repo.GetByUserId(userId);
        }

        public void MarkAllRead(int userId)
        {
            _repo.MarkAllRead(userId);
        }
    }
}