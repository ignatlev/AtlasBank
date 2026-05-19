using Bank.Models;

namespace Bank.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool UsernameExists(string username);
        bool EmailExists(string email);
        void Save(User user);
        User? FindByUsername(string username);
        User? GetByEmail(string email);
        void UpdatePassword(int userId, string newPasswordHash);
    }
}