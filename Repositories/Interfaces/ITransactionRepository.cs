using Bank.Models;

namespace Bank.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        List<Transaction> GetByUserId(int userId);
        List<Transaction> GetByUserId(int userId, DateTime startDate, DateTime endDate);
        Transaction SaveTransfer(Transaction transaction, BankAccount fromAccount, BankAccount? toAccount, decimal amount, string beneficiaryAccountNumber);
    }
}