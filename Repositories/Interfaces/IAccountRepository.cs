using Bank.Models;

namespace Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        List<BankAccount> GetByUserId(int userId);
        BankAccount? GetByAccountNumber(string accountNumber);
        void Save(BankAccount account);
        bool AccountNumberExists(string accountNumber);
        void Delete(int accountId);
        void Rename(int accountId, string newName);
    }
}