using Bank.Models;

namespace Bank.Repositories.Interfaces
{
    public interface ICardRepository
    {
        Card Save(Card card);
        List<Card> GetByUserId(int userId);
        Card? GetById(int cardId);
        void ChangePin(int cardId, string newPin);
        void BlockCard(int cardId);
        void UnblockCard(int cardId);
        void Delete(int cardId);
        void ToggleInternetPayments(int cardId, bool enabled);
    }
}