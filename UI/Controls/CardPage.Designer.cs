namespace Bank.UI.Controls
{
    partial class CardPage
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
            label1 = new Label();
            panel1 = new Panel();
            btnCreateCard = new Button();
            internet = new Label();
            cmbInternetEnabled = new ComboBox();
            txtDailyLimit = new TextBox();
            lblDailyLimit = new Label();
            cmbCardBrand = new ComboBox();
            lblCardBrand = new Label();
            cmbCardType = new ComboBox();
            label3 = new Label();
            lblAccount = new Label();
            cmbAccount = new ComboBox();
            label2 = new Label();
            dgvCards = new DataGridView();
            btnChangePin = new Button();
            btnBlockCard = new Button();
            btnCloseCard = new Button();
            btnCardInfo = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnUnblockCard = new Button();
            btnToggleInternetPayments = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCards).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(209, 59);
            label1.TabIndex = 2;
            label1.Text = "My Cards";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCreateCard);
            panel1.Controls.Add(internet);
            panel1.Controls.Add(cmbInternetEnabled);
            panel1.Controls.Add(txtDailyLimit);
            panel1.Controls.Add(lblDailyLimit);
            panel1.Controls.Add(cmbCardBrand);
            panel1.Controls.Add(lblCardBrand);
            panel1.Controls.Add(cmbCardType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblAccount);
            panel1.Controls.Add(cmbAccount);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 427);
            panel1.TabIndex = 4;
            // 
            // btnCreateCard
            // 
            btnCreateCard.BackColor = Color.FromArgb(47, 47, 47);
            btnCreateCard.Cursor = Cursors.Hand;
            btnCreateCard.FlatAppearance.BorderSize = 0;
            btnCreateCard.FlatStyle = FlatStyle.Flat;
            btnCreateCard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnCreateCard.ForeColor = Color.White;
            btnCreateCard.Location = new Point(27, 329);
            btnCreateCard.Margin = new Padding(2, 3, 2, 3);
            btnCreateCard.Name = "btnCreateCard";
            btnCreateCard.Size = new Size(308, 72);
            btnCreateCard.TabIndex = 23;
            btnCreateCard.Text = "Order Card";
            btnCreateCard.UseVisualStyleBackColor = false;
            btnCreateCard.Click += btnCreateCard_Click;
            // 
            // internet
            // 
            internet.AutoSize = true;
            internet.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            internet.Location = new Point(296, 68);
            internet.Name = "internet";
            internet.Size = new Size(81, 25);
            internet.TabIndex = 11;
            internet.Text = "Internet";
            // 
            // cmbInternetEnabled
            // 
            cmbInternetEnabled.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInternetEnabled.Font = new Font("Segoe UI", 14F);
            cmbInternetEnabled.FormattingEnabled = true;
            cmbInternetEnabled.Location = new Point(313, 96);
            cmbInternetEnabled.Name = "cmbInternetEnabled";
            cmbInternetEnabled.Size = new Size(58, 33);
            cmbInternetEnabled.TabIndex = 10;
            // 
            // txtDailyLimit
            // 
            txtDailyLimit.Font = new Font("Segoe UI", 14F);
            txtDailyLimit.Location = new Point(6, 255);
            txtDailyLimit.Name = "txtDailyLimit";
            txtDailyLimit.Size = new Size(365, 32);
            txtDailyLimit.TabIndex = 8;
            // 
            // lblDailyLimit
            // 
            lblDailyLimit.AutoSize = true;
            lblDailyLimit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailyLimit.Location = new Point(6, 218);
            lblDailyLimit.Name = "lblDailyLimit";
            lblDailyLimit.Size = new Size(132, 25);
            lblDailyLimit.TabIndex = 7;
            lblDailyLimit.Text = "Daily Limit (€)";
            // 
            // cmbCardBrand
            // 
            cmbCardBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCardBrand.Font = new Font("Segoe UI", 14F);
            cmbCardBrand.FormattingEnabled = true;
            cmbCardBrand.Location = new Point(253, 171);
            cmbCardBrand.Name = "cmbCardBrand";
            cmbCardBrand.Size = new Size(121, 33);
            cmbCardBrand.TabIndex = 6;
            // 
            // lblCardBrand
            // 
            lblCardBrand.AutoSize = true;
            lblCardBrand.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardBrand.Location = new Point(253, 143);
            lblCardBrand.Name = "lblCardBrand";
            lblCardBrand.Size = new Size(62, 25);
            lblCardBrand.TabIndex = 5;
            lblCardBrand.Text = "Brand";
            // 
            // cmbCardType
            // 
            cmbCardType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCardType.Font = new Font("Segoe UI", 14F);
            cmbCardType.FormattingEnabled = true;
            cmbCardType.Location = new Point(6, 171);
            cmbCardType.Name = "cmbCardType";
            cmbCardType.Size = new Size(189, 33);
            cmbCardType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 143);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Card Type";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(9, 68);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(83, 25);
            lblAccount.TabIndex = 2;
            lblAccount.Text = "Account";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.Font = new Font("Segoe UI", 14F);
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(6, 96);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(301, 33);
            cmbAccount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 7);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 0;
            label2.Text = "Order New Card";
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
            dgvCards.Location = new Point(15, 81);
            dgvCards.Name = "dgvCards";
            dgvCards.ReadOnly = true;
            dgvCards.RowHeadersWidth = 50;
            dgvCards.Size = new Size(550, 301);
            dgvCards.TabIndex = 11;
            // 
            // btnChangePin
            // 
            btnChangePin.BackColor = Color.FromArgb(47, 47, 47);
            btnChangePin.Cursor = Cursors.Hand;
            btnChangePin.FlatAppearance.BorderSize = 0;
            btnChangePin.FlatStyle = FlatStyle.Flat;
            btnChangePin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnChangePin.ForeColor = Color.White;
            btnChangePin.Location = new Point(211, 519);
            btnChangePin.Margin = new Padding(2, 3, 2, 3);
            btnChangePin.Name = "btnChangePin";
            btnChangePin.Size = new Size(125, 38);
            btnChangePin.TabIndex = 19;
            btnChangePin.Text = "Change PIN";
            btnChangePin.UseVisualStyleBackColor = false;
            btnChangePin.Click += btnChangePin_Click;
            // 
            // btnBlockCard
            // 
            btnBlockCard.BackColor = Color.FromArgb(47, 47, 47);
            btnBlockCard.Cursor = Cursors.Hand;
            btnBlockCard.FlatAppearance.BorderSize = 0;
            btnBlockCard.FlatStyle = FlatStyle.Flat;
            btnBlockCard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnBlockCard.ForeColor = Color.White;
            btnBlockCard.Location = new Point(386, 459);
            btnBlockCard.Margin = new Padding(2, 3, 2, 3);
            btnBlockCard.Name = "btnBlockCard";
            btnBlockCard.Size = new Size(125, 38);
            btnBlockCard.TabIndex = 20;
            btnBlockCard.Text = "Block Card";
            btnBlockCard.UseVisualStyleBackColor = false;
            btnBlockCard.Click += btnBlockCard_Click;
            // 
            // btnCloseCard
            // 
            btnCloseCard.BackColor = Color.FromArgb(47, 47, 47);
            btnCloseCard.Cursor = Cursors.Hand;
            btnCloseCard.FlatAppearance.BorderSize = 0;
            btnCloseCard.FlatStyle = FlatStyle.Flat;
            btnCloseCard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCloseCard.ForeColor = Color.White;
            btnCloseCard.Location = new Point(211, 459);
            btnCloseCard.Margin = new Padding(2, 3, 2, 3);
            btnCloseCard.Name = "btnCloseCard";
            btnCloseCard.Size = new Size(125, 38);
            btnCloseCard.TabIndex = 21;
            btnCloseCard.Text = "Close Card";
            btnCloseCard.UseVisualStyleBackColor = false;
            btnCloseCard.Click += btnCloseCard_Click;
            // 
            // btnCardInfo
            // 
            btnCardInfo.BackColor = Color.FromArgb(47, 47, 47);
            btnCardInfo.Cursor = Cursors.Hand;
            btnCardInfo.FlatAppearance.BorderSize = 0;
            btnCardInfo.FlatStyle = FlatStyle.Flat;
            btnCardInfo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCardInfo.ForeColor = Color.White;
            btnCardInfo.Location = new Point(33, 459);
            btnCardInfo.Margin = new Padding(2, 3, 2, 3);
            btnCardInfo.Name = "btnCardInfo";
            btnCardInfo.Size = new Size(125, 38);
            btnCardInfo.TabIndex = 23;
            btnCardInfo.Text = "Card Info";
            btnCardInfo.UseVisualStyleBackColor = false;
            btnCardInfo.Click += btnCardInfo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 602);
            panel2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(141, 385);
            label5.Name = "label5";
            label5.Size = new Size(274, 41);
            label5.TabIndex = 24;
            label5.Text = "Card Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(128, 425);
            label4.Name = "label4";
            label4.Size = new Size(303, 19);
            label4.TabIndex = 26;
            label4.Text = "Access and manage your card features securely";
            // 
            // btnUnblockCard
            // 
            btnUnblockCard.BackColor = Color.FromArgb(47, 47, 47);
            btnUnblockCard.Cursor = Cursors.Hand;
            btnUnblockCard.FlatAppearance.BorderSize = 0;
            btnUnblockCard.FlatStyle = FlatStyle.Flat;
            btnUnblockCard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnUnblockCard.ForeColor = Color.White;
            btnUnblockCard.Location = new Point(386, 519);
            btnUnblockCard.Margin = new Padding(2, 3, 2, 3);
            btnUnblockCard.Name = "btnUnblockCard";
            btnUnblockCard.Size = new Size(125, 38);
            btnUnblockCard.TabIndex = 27;
            btnUnblockCard.Text = "Unblock Card";
            btnUnblockCard.UseVisualStyleBackColor = false;
            btnUnblockCard.Click += btnUnblockCard_Click_1;
            // 
            // btnToggleInternetPayments
            // 
            btnToggleInternetPayments.BackColor = Color.FromArgb(47, 47, 47);
            btnToggleInternetPayments.Cursor = Cursors.Hand;
            btnToggleInternetPayments.FlatAppearance.BorderSize = 0;
            btnToggleInternetPayments.FlatStyle = FlatStyle.Flat;
            btnToggleInternetPayments.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnToggleInternetPayments.ForeColor = Color.White;
            btnToggleInternetPayments.Location = new Point(33, 519);
            btnToggleInternetPayments.Margin = new Padding(2, 3, 2, 3);
            btnToggleInternetPayments.Name = "btnToggleInternetPayments";
            btnToggleInternetPayments.Size = new Size(125, 38);
            btnToggleInternetPayments.TabIndex = 28;
            btnToggleInternetPayments.Text = "On/Off Payments";
            btnToggleInternetPayments.UseVisualStyleBackColor = false;
            btnToggleInternetPayments.Click += btnToggleInternetPayments_Click;
            // 
            // CardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnToggleInternetPayments);
            Controls.Add(btnUnblockCard);
            Controls.Add(label4);
            Controls.Add(btnChangePin);
            Controls.Add(btnCardInfo);
            Controls.Add(btnCloseCard);
            Controls.Add(btnBlockCard);
            Controls.Add(label5);
            Controls.Add(dgvCards);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "CardPage";
            Size = new Size(961, 602);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCards).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblAccount;
        private ComboBox cmbAccount;
        private Label label2;
        private TextBox txtDailyLimit;
        private Label lblDailyLimit;
        private ComboBox cmbCardBrand;
        private Label lblCardBrand;
        private ComboBox cmbCardType;
        private Label label3;
        private DataGridView dgvCards;
        private Label internet;
        private ComboBox cmbInternetEnabled;
        private Button btnChangePin;
        private Button btnBlockCard;
        private Button btnCloseCard;
        private Button btnCardInfo;
        private Panel panel2;
        private Button btnCreateCard;
        private Label label5;
        private Label label4;
        private Button btnUnblockCard;
        private Button btnToggleInternetPayments;
    }
}
