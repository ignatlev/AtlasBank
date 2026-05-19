namespace Bank.UI.Controls
{
    partial class AccountPage
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
            label4 = new Label();
            label3 = new Label();
            txtAccountName = new TextBox();
            dgvAccounts = new DataGridView();
            txtStartingBalance = new TextBox();
            lblStartingBalance = new Label();
            btnCloseAccount = new Button();
            btnRenameAccount = new Button();
            label7 = new Label();
            btnCreateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(205, 59);
            label1.TabIndex = 3;
            label1.Text = "Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(38, 71);
            label4.Name = "label4";
            label4.Size = new Size(550, 40);
            label4.TabIndex = 9;
            label4.Text = "Manage your bank accounts and balances";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(617, 85);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 8;
            label3.Text = "Account Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAccountName.Location = new Point(617, 113);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(302, 35);
            txtAccountName.TabIndex = 7;
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
            dgvAccounts.Location = new Point(42, 127);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 50;
            dgvAccounts.Size = new Size(502, 258);
            dgvAccounts.TabIndex = 10;
            // 
            // txtStartingBalance
            // 
            txtStartingBalance.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStartingBalance.Location = new Point(617, 189);
            txtStartingBalance.Name = "txtStartingBalance";
            txtStartingBalance.Size = new Size(302, 35);
            txtStartingBalance.TabIndex = 11;
            // 
            // lblStartingBalance
            // 
            lblStartingBalance.AutoSize = true;
            lblStartingBalance.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartingBalance.Location = new Point(617, 161);
            lblStartingBalance.Name = "lblStartingBalance";
            lblStartingBalance.Size = new Size(179, 25);
            lblStartingBalance.TabIndex = 12;
            lblStartingBalance.Text = "Starting Balance (€)";
            // 
            // btnCloseAccount
            // 
            btnCloseAccount.BackColor = Color.FromArgb(47, 47, 47);
            btnCloseAccount.Cursor = Cursors.Hand;
            btnCloseAccount.FlatAppearance.BorderSize = 0;
            btnCloseAccount.FlatStyle = FlatStyle.Flat;
            btnCloseAccount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCloseAccount.ForeColor = Color.White;
            btnCloseAccount.Location = new Point(617, 324);
            btnCloseAccount.Margin = new Padding(2, 3, 2, 3);
            btnCloseAccount.Name = "btnCloseAccount";
            btnCloseAccount.Size = new Size(125, 38);
            btnCloseAccount.TabIndex = 28;
            btnCloseAccount.Text = "Close Account";
            btnCloseAccount.UseVisualStyleBackColor = false;
            btnCloseAccount.Click += btnCloseAccount_Click;
            // 
            // btnRenameAccount
            // 
            btnRenameAccount.BackColor = Color.FromArgb(47, 47, 47);
            btnRenameAccount.Cursor = Cursors.Hand;
            btnRenameAccount.FlatAppearance.BorderSize = 0;
            btnRenameAccount.FlatStyle = FlatStyle.Flat;
            btnRenameAccount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRenameAccount.ForeColor = Color.White;
            btnRenameAccount.Location = new Point(794, 324);
            btnRenameAccount.Margin = new Padding(2, 3, 2, 3);
            btnRenameAccount.Name = "btnRenameAccount";
            btnRenameAccount.Size = new Size(125, 38);
            btnRenameAccount.TabIndex = 27;
            btnRenameAccount.Text = "Rename Account";
            btnRenameAccount.UseVisualStyleBackColor = false;
            btnRenameAccount.Click += btnRenameAccount_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(617, 31);
            label7.Name = "label7";
            label7.Size = new Size(323, 41);
            label7.TabIndex = 29;
            label7.Text = "Account Management";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(47, 47, 47);
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(617, 248);
            btnCreateAccount.Margin = new Padding(2, 3, 2, 3);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(302, 52);
            btnCreateAccount.TabIndex = 31;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click_1;
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreateAccount);
            Controls.Add(btnCloseAccount);
            Controls.Add(btnRenameAccount);
            Controls.Add(label7);
            Controls.Add(txtStartingBalance);
            Controls.Add(lblStartingBalance);
            Controls.Add(dgvAccounts);
            Controls.Add(txtAccountName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AccountPage";
            Size = new Size(961, 602);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button btnCreateAccount;
        private Label label3;
        private TextBox txtAccountName;
        private DataGridView dgvAccounts;
        private TextBox txtStartingBalance;
        private Label lblStartingBalance;
        private Button btnCloseAccount;
        private Button btnRenameAccount;
        private Label label7;
    }
}
