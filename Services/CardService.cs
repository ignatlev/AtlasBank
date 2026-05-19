using Bank.Models;
using Bank.Repositories;
using Bank.Repositories.Interfaces;

namespace Bank.Services
{
    public class CardService
    {
        private readonly ICardRepository _cardRepo;
        private readonly NotificationService _notificationService;

        public CardService(ICardRepository cardRepo, NotificationService notificationService)
        {
            _cardRepo = cardRepo;
            _notificationService = notificationService;
        }

        public Card Create(int userId, int accountId, string cardType, string cardBrand, string dailyLimitText, bool internetEnabled)
        {
            decimal dailyLimit = decimal.Parse(dailyLimitText);
            Card card = new Card();
            card.SetAccountId(accountId);
            card.SetUserId(userId);
            card.SetExpiryDate(DateTime.Now.AddYears(4));
            card.SetCardType(cardType);
            card.SetCardBrand(cardBrand);
            card.SetCreatedAt(DateTime.UtcNow);
            card.Activate();
            card.SetDailyLimit(dailyLimit);

            if (internetEnabled)
            {
                card.EnableInternet();
            }
            else
            {
                card.DisableInternet();
            }   

            card = _cardRepo.Save(card);
            _notificationService.CardCreated(userId, card.CardNumber, card.CardType);

            return card;
        }

        public void BlockCard(int cardId)
        {
            Card? card = _cardRepo.GetById(cardId);

            if (card == null)
            {
                throw new Exception("Card not found.");
            }

            card.Block();
            _cardRepo.BlockCard(cardId);
        }

        public void UnblockCard(int cardId)
        {
            Card? card = _cardRepo.GetById(cardId);

            if (card == null)
            {
                throw new Exception("Card not found.");
            }

            card.Unblock();
            _cardRepo.UnblockCard(cardId);
        }

        public void CloseCard(int cardId)
        {
            Card? card = _cardRepo.GetById(cardId);

            if (card == null)
            {
                throw new Exception("Card not found.");
            }

            _cardRepo.Delete(cardId);
            _notificationService.CardClosed(card.UserId, card.CardNumber);
        }

        public void ChangePin(int cardId, string currentPin, string newPin, string confirmPin)
        {
            bool allDigits = true;
            foreach (char c in newPin)
            {
                if (!char.IsDigit(c))
                {
                    allDigits = false;
                    break;
                }
            }

            if (newPin.Length != 4 || !allDigits)
                throw new Exception("PIN must be exactly 4 digits.");

            if (newPin != confirmPin)
            {
                throw new Exception("Passwords do not match.");
            }

            Card? card = _cardRepo.GetById(cardId);

            if (card == null)
                throw new Exception("Card not found.");

            if (card.PinHash != currentPin)
                throw new Exception("Current PIN is incorrect.");

            _cardRepo.ChangePin(cardId, newPin);
            _notificationService.CardPinChanged(card.UserId, card.CardNumber);
        }
        public List<Card> GetByUserId(int userId)
        {
            return _cardRepo.GetByUserId(userId);
        }

        public void ToggleInternetPayments(int cardId, bool enabled)
        {
            _cardRepo.ToggleInternetPayments(cardId, enabled);
        }
    }
}