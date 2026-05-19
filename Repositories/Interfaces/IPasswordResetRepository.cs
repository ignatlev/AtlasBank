namespace Bank.Repositories.Interfaces
{
    public interface IPasswordResetRepository
    {
        void Save(int userId, string code, DateTime expiresAt);
        bool IsValid(int userId, string code);
        void MarkUsed(int userId, string code);
    }
}