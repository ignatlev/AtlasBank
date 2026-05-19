namespace Bank.UI.Controls
{
    partial class HomeMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTransactionsHeader = new Label();
            lblTotalBalance = new Label();
            lblWelcome = new Label();
            lblAccountsHeader = new Label();
            lblCardsHeader = new Label();
            dgvCards = new DataGridView();
            dgvAccounts = new DataGridView();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblTransactionsHeader
            // 
            lblTransactionsHeader.AutoSize = true;
            lblTransactionsHeader.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsHeader.Location = new Point(40, 289);
            lblTransactionsHeader.Name = "lblTransactionsHeader";
            lblTransactionsHeader.Size = new Size(290, 41);
            lblTransactionsHeader.TabIndex = 14;
            lblTransactionsHeader.Text = "Recent Transactions";
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBalance.Location = new Point(34, 61);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(225, 41);
            lblTotalBalance.TabIndex = 7;
            lblTotalBalance.Text = "lblTotalBalance";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(30, 2);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(255, 59);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "lblWelcome";
            // 
            // lblAccountsHeader
            // 
            lblAccountsHeader.AutoSize = true;
            lblAccountsHeader.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountsHeader.Location = new Point(568, 111);
            lblAccountsHeader.Name = "lblAccountsHeader";
            lblAccountsHeader.Size = new Size(195, 41);
            lblAccountsHeader.TabIndex = 19;
            lblAccountsHeader.Text = "My Accounts";
            // 
            // lblCardsHeader
            // 
            lblCardsHeader.AutoSize = true;
            lblCardsHeader.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardsHeader.Location = new Point(30, 111);
            lblCardsHeader.Name = "lblCardsHeader";
            lblCardsHeader.Size = new Size(146, 41);
            lblCardsHeader.TabIndex = 21;
            lblCardsHeader.Text = "My Cards";
            // 
            // dgvCards
            // 
            dgvCards.AllowUserToAddRows = false;
            dgvCards.AllowUserToDeleteRows = false;
            dgvCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCards.BackgroundColor = Color.White;
            dgvCards.BorderStyle = BorderStyle.None;
            dgvCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCards.GridColor = Color.Black;
            dgvCards.Location = new Point(40, 155);
            dgvCards.Name = "dgvCards";
            dgvCards.ReadOnly = true;
            dgvCards.RowHeadersWidth = 50;
            dgvCards.Size = new Size(501, 132);
            dgvCards.TabIndex = 22;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.BorderStyle = BorderStyle.None;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.GridColor = Color.Black;
            dgvAccounts.Location = new Point(568, 155);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 50;
            dgvAccounts.Size = new Size(379, 132);
            dgvAccounts.TabIndex = 23;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.GridColor = Color.Black;
            dgvTransactions.Location = new Point(41, 350);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 50;
            dgvTransactions.Size = new Size(890, 217);
            dgvTransactions.TabIndex = 24;
            // 
            // HomeMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 226, 230);
            Controls.Add(dgvTransactions);
            Controls.Add(dgvAccounts);
            Controls.Add(dgvCards);
            Controls.Add(lblCardsHeader);
            Controls.Add(lblAccountsHeader);
            Controls.Add(lblTransactionsHeader);
            Controls.Add(lblTotalBalance);
            Controls.Add(lblWelcome);
            Name = "HomeMain";
            Size = new Size(961, 602);
            ((System.ComponentModel.ISupportInitialize)dgvCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransactionsHeader;
        private Label lblTotalBalance;
        private Label lblWelcome;
        private Label lblAccountsHeader;
        private Label lblCardsHeader;
        private DataGridView dgvCards;
        private DataGridView dgvAccounts;
        private DataGridView dgvTransactions;
    }
}
