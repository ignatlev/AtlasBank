using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;

namespace Bank.UI.Controls
{
    public partial class CardPage : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private List<Card> _cards = new List<Card>();
        private List<BankAccount> _accounts = new List<BankAccount>();
        private readonly CardService _cardService;
        private readonly AccountService _accountService;

        public CardPage()
        {
            InitializeComponent();
            GridHelper.SetupCardsGrid(dgvCards);
            cmbCardType.Items.AddRange(new string[] { "Debit", "Credit" });
            cmbCardBrand.Items.AddRange(new string[] { "Visa", "Mastercard" });
            cmbInternetEnabled.Items.AddRange(new string[] { "Yes", "No" });
            txtDailyLimit.Text = "150";
            cmbCardType.SelectedIndex = 0;
            cmbCardBrand.SelectedIndex = 1;
            cmbInternetEnabled.SelectedIndex = 1;

            var notificationService = new NotificationService(new NotificationRepository());
            _accountService = new AccountService(new AccountRepository(), notificationService);
            _cardService = new CardService(new CardRepository(), notificationService);
        }

        public void SetUser(User user)
        {
            _currentUser = user;
        }

        public void LoadData()
        {
            if (_currentUser == null)
            {
                return;
            }

            _accounts = _accountService.GetByUserId(_currentUser.Id);
            _cards = _cardService.GetByUserId(_currentUser.Id);

            GridHelper.LoadCards(dgvCards, _cards);

            cmbAccount.Items.Clear();

            if (_accounts.Count == 0)
            {
                cmbAccount.Items.Add("No accounts available");
                return;
            }

            foreach (BankAccount acc in _accounts)
            {
                cmbAccount.Items.Add(string.Format("{0} | {1}", acc.AccountName, acc.AccountNumber));
            }

            cmbAccount.SelectedIndex = 0;

            if (_cards.Count == 0)
            {
                btnUnblockCard.Enabled = false;
                btnBlockCard.Enabled = false;
                btnCardInfo.Enabled = false;
                btnCloseCard.Enabled = false;
                btnChangePin.Enabled = false;
                btnToggleInternetPayments.Enabled = false;
            }
            else
            {
                btnUnblockCard.Enabled = true;
                btnBlockCard.Enabled = true;
                btnCardInfo.Enabled = true;
                btnCloseCard.Enabled = true;
                btnChangePin.Enabled = true;
                btnToggleInternetPayments.Enabled = true;
            }
        }

        private void btnCardInfo_Click(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");
            if (card == null) return;

            string statusText = card.IsActive ? "Active" : "Blocked";
            string internetText = card.InternetEnabled ? "Yes" : "No";

            string info =
                "Card Number:       " + card.CardNumber + "\n" +
                "Cardholder:        " + card.CardholderName + "\n" +
                "Brand:             " + card.CardBrand + "\n" +
                "Type:              " + card.CardType + "\n" +
                "Expires:           " + card.ExpiryDate.ToString("MM/yyyy") + "\n" +
                "Daily Limit:       " + string.Format("{0:N2}€", card.DailyLimit) + "\n" +
                "Status:            " + statusText + "\n" +
                "Internet Payments: " + internetText + "\n" +
                "PIN:               " + card.PinHash + "\n" +
                "CVV:               " + card.CvvHash + "\n" +
                "Created:           " + card.CreatedAt.ToString("dd MMM yyyy");

            MessageBox.Show(info, "Card Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBlockCard_Click(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");

            if (card == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Block card {0}?", card.CardNumber), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _cardService.BlockCard(card.Id);
                MessageBox.Show("Card blocked successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");

            if (card == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Permanently close card {0}? This cannot be undone.", card.CardNumber), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _cardService.CloseCard(card.Id);
                MessageBox.Show("Card closed successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");

            if (card == null)
            {
                return;
            }

            try
            {
                string currentPin = Microsoft.VisualBasic.Interaction.InputBox("Enter current PIN:", "Change PIN", "");

                if (string.IsNullOrWhiteSpace(currentPin))
                {
                    return;
                }

                string newPin = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new PIN (4 digits):", "Change PIN", "");

                if (string.IsNullOrWhiteSpace(newPin))
                {
                    return;
                }

                string confirmPin = Microsoft.VisualBasic.Interaction.InputBox(
                    "Confirm new PIN:", "Change PIN", "");

                if (string.IsNullOrWhiteSpace(confirmPin))
                {
                    return;
                }

                _cardService.ChangePin(card.Id, currentPin, newPin, confirmPin);

                MessageBox.Show("PIN changed successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                return;
            }

            try
            {
                if (_accounts.Count == 0 || cmbAccount.SelectedIndex < 0)
                {
                    throw new Exception("Please select an account.");
                }

                bool internetEnabled = false;
                if (cmbInternetEnabled.SelectedItem != null && cmbInternetEnabled.SelectedItem.ToString() == "Yes")
                {
                    internetEnabled = true;
                }

                string? cardType = null;
                string? cardBrand = null;

                if (cmbCardType.SelectedItem != null)
                {
                    cardType = cmbCardType.SelectedItem.ToString();
                }

                if (cmbCardBrand.SelectedItem != null)
                {
                    cardBrand = cmbCardBrand.SelectedItem.ToString();
                }

                if (cardType == null || cardBrand == null)
                {
                    throw new Exception("Please select a card type and brand.");
                }

                Card card = _cardService.Create(
                    _currentUser.Id,
                    _accounts[cmbAccount.SelectedIndex].Id,
                    cardType,
                    cardBrand,
                    txtDailyLimit.Text,
                    internetEnabled
                );

                string message =
                    "Card created successfully!\n\n" +
                    "Card Number: " + card.CardNumber + "\n" +
                    "Card Type:   " + card.CardType + "\n" +
                    "Brand:       " + card.CardBrand + "\n" +
                    "Expires:     " + card.ExpiryDate.ToString("MM/yyyy") + "\n\n" +
                    "YOUR PIN: " + card.PinHash + "\n" +
                    "YOUR CVV: " + card.CvvHash + "\n\n" +
                    "Keep these codes safe and secure.";

                MessageBox.Show(message, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUnblockCard_Click_1(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");

            if (card == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Unblock card {0}?", card.CardNumber), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _cardService.UnblockCard(card.Id);
                MessageBox.Show("Card unblocked successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToggleInternetPayments_Click(object sender, EventArgs e)
        {
            Card? card = GridHelper.GetSelectedItem(dgvCards, _cards, "Please select a card.");

            if (card == null)
            {
                return;
            }

            string action = card.InternetEnabled ? "disable" : "enable";

            if (MessageBox.Show(string.Format("Are you sure you want to {0} internet payments for card {1}?", action, card.CardNumber), "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _cardService.ToggleInternetPayments(card.Id, !card.InternetEnabled);
                MessageBox.Show(string.Format("Internet payments {0}d successfully.", action), "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}