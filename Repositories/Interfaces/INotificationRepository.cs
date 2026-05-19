using Bank.Models;

namespace Bank.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        void Save(Notification notification);
        List<Notification> GetByUserId(int userId);
        void MarkAllRead(int userId);
    }
}