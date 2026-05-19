using Bank.Models;
using Bank.Services;

namespace Bank.Utils
{
    public static class GridHelper
    {

        public static void SetupAccountsGrid(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);

            DataGridViewTextBoxColumn accountName = new DataGridViewTextBoxColumn();
            accountName.Name = "AccountName";
            accountName.HeaderText = "Account Name";
            accountName.FillWeight = 25;
            dgv.Columns.Add(accountName);

            DataGridViewTextBoxColumn accountNumber = new DataGridViewTextBoxColumn();
            accountNumber.Name = "AccountNumber";
            accountNumber.HeaderText = "Account Number";
            accountNumber.FillWeight = 35;
            dgv.Columns.Add(accountNumber);

            DataGridViewTextBoxColumn balance = new DataGridViewTextBoxColumn();
            balance.Name = "Balance";
            balance.HeaderText = "Balance (€)";
            balance.FillWeight = 20;
            dgv.Columns.Add(balance);

            DataGridViewTextBoxColumn percentage = new DataGridViewTextBoxColumn();
            percentage.Name = "Percentage";
            percentage.HeaderText = "% of Total";
            percentage.FillWeight = 20;
            dgv.Columns.Add(percentage);
        }

        public static void SetupCardsGrid(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);

            DataGridViewTextBoxColumn cardNumber = new DataGridViewTextBoxColumn();
            cardNumber.Name = "CardNumber";
            cardNumber.HeaderText = "Card Number";
            cardNumber.FillWeight = 40;
            dgv.Columns.Add(cardNumber);

            DataGridViewTextBoxColumn expiry = new DataGridViewTextBoxColumn();
            expiry.Name = "Expiry";
            expiry.HeaderText = "Expires";
            expiry.FillWeight = 30;
            dgv.Columns.Add(expiry);

            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn();
            status.Name = "Status";
            status.HeaderText = "Status";
            status.FillWeight = 30;
            dgv.Columns.Add(status);
        }

        public static void SetupTransactionsGrid(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);

            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.Name = "Date";
            date.HeaderText = "Date";
            date.FillWeight = 18;
            dgv.Columns.Add(date);

            DataGridViewTextBoxColumn account = new DataGridViewTextBoxColumn();
            account.Name = "Account";
            account.HeaderText = "Account";
            account.FillWeight = 8;
            dgv.Columns.Add(account);

            DataGridViewTextBoxColumn accountNumber = new DataGridViewTextBoxColumn();
            accountNumber.Name = "AccountNumber";
            accountNumber.HeaderText = "Account Number";
            accountNumber.FillWeight = 20;
            dgv.Columns.Add(accountNumber);

            DataGridViewTextBoxColumn toAccount = new DataGridViewTextBoxColumn();
            toAccount.Name = "ToAccount";
            toAccount.HeaderText = "To/From";
            toAccount.FillWeight = 17;
            dgv.Columns.Add(toAccount);

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.Name = "Type";
            type.HeaderText = "Type";
            type.FillWeight = 12;
            dgv.Columns.Add(type);

            DataGridViewTextBoxColumn amount = new DataGridViewTextBoxColumn();
            amount.Name = "Amount";
            amount.HeaderText = "Amount";
            amount.FillWeight = 10;
            dgv.Columns.Add(amount);

            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            description.Name = "Description";
            description.HeaderText = "Description";
            description.FillWeight = 25;
            dgv.Columns.Add(description);
        }

        public static void SetupNotificationsGrid(DataGridView dgv)
        {
            dgv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);

            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.Name = "Date";
            date.HeaderText = "Date";
            date.FillWeight = 20;
            dgv.Columns.Add(date);

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.Name = "Type";
            type.HeaderText = "Type";
            type.FillWeight = 10;
            dgv.Columns.Add(type);

            DataGridViewTextBoxColumn message = new DataGridViewTextBoxColumn();
            message.Name = "Message";
            message.HeaderText = "Message";
            message.FillWeight = 75;
            dgv.Columns.Add(message);
        }


        public static void LoadAccounts(DataGridView dgv, List<BankAccount> accounts)
        {
            dgv.Rows.Clear();
            if (accounts.Count == 0)
            {
                dgv.Rows.Add("No accounts yet", "-", "-", "-");
                return;
            }

            decimal totalBalance = 0;
            foreach (BankAccount acc in accounts)
            {
                totalBalance += acc.Balance;
            }

            foreach (BankAccount acc in accounts)
            {
                string percent;
                if (totalBalance == 0)
                {
                    percent = "0%";
                }
                else
                {
                    percent = string.Format("{0}%", Math.Round((acc.Balance / totalBalance) * 100, 1));
                }
                dgv.Rows.Add(
                    acc.AccountName,
                    acc.AccountNumber,
                    string.Format("{0:N2}€", acc.Balance),
                    percent
                );
            }
            NumberRows(dgv);
        }

        public static void LoadCards(DataGridView dgv, List<Card> cards)
        {
            dgv.Rows.Clear();

            if (cards.Count == 0)
            {
                dgv.Rows.Add("-", "-", "No cards yet");
                return;
            }

            foreach (Card card in cards)
            {
                string expiry;
                if (card.ExpiryDate < DateTime.Now)
                {
                    expiry = "EXPIRED";
                }
                else
                {
                    expiry = card.ExpiryDate.ToString("MM/yyyy");
                }

                string status;
                if (card.IsActive)
                {
                    status = "Active";
                }
                else
                {
                    status = "Blocked";
                }

                dgv.Rows.Add(card.CardNumber, expiry, status);
            }

            ColorCardRows(dgv);
            NumberRows(dgv);
        }

        public static void LoadTransactions(DataGridView dgv, List<Transaction> transactions)
        {
            dgv.Rows.Clear();

            if (transactions.Count == 0)
            {
                dgv.Rows.Add("-", "-", "-", "-", "-", "-", "-");
                return;
            }

            foreach (Transaction tx in transactions)
            {
                string display;
                if (tx.Type == TransactionType.Income)
                {
                    display = string.Format("+{0:N2}€", tx.Amount);
                }
                else
                {
                    display = string.Format("-{0:N2}€", tx.Amount);
                }

                string toAccount;
                if (tx.ToAccountNumber != string.Empty)
                {
                    toAccount = tx.ToAccountNumber;
                }
                else
                {
                    toAccount = "-";
                }

                dgv.Rows.Add(
                    tx.CreatedAt.ToString("dd MMM yyyy HH:mm"),
                    tx.AccountName,
                    tx.AccountNumber,
                    toAccount,
                    tx.Type.ToString(),
                    display,
                    tx.Description
                );
            }

            ColorTransactionRows(dgv);
            NumberRows(dgv);
        }

        public static void LoadNotifications(DataGridView dgv, List<Notification> notifications)
        {
            dgv.Rows.Clear();

            if (notifications.Count == 0)
            {
                dgv.Rows.Add("-", "-", "No notifications yet");
                return;
            }

            foreach (Notification n in notifications)
            {
                dgv.Rows.Add(n.CreatedAt.ToString("dd MMM yyyy HH:mm"), n.Type, n.Message);
            }

            ColorNotificationRows(dgv);
            NumberRows(dgv);
        }

        public static void ColorCardRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string? status = row.Cells["Status"].Value != null ? row.Cells["Status"].Value.ToString() : "";
                if (status == "Active")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        public static void ColorTransactionRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string? amount = row.Cells["Amount"].Value != null ? row.Cells["Amount"].Value.ToString() : "";

                if (amount != null && amount.StartsWith("+"))
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        public static void ColorNotificationRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string? type = row.Cells["Type"].Value != null ? row.Cells["Type"].Value.ToString() : "";

                if (type == "Transfer")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
                else if (type == "Card")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                }
                else if (type == "Account")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                }
                else if (type == "Login")
                {
                    row.DefaultCellStyle.ForeColor = Color.Purple;
                }
                else if (type == "Change")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        public static void NumberRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        public static T? GetSelectedItem<T>(DataGridView dgv, List<T> items, string errorMessage = "Please select an item.")
    where T : class
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            int index = dgv.SelectedRows[0].Index;

            if (index >= items.Count)
            {
                return null;
            }

            return items[index];
        }
    }
}