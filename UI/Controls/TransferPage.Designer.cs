namespace Bank.UI.Controls
{
    partial class TransferPage
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
            btnConfirm = new Button();
            lblDailyLimit = new Label();
            label2 = new Label();
            cmbAccount = new ComboBox();
            cmbPaymentType = new ComboBox();
            txtBeneficiaryAccount = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAmount = new TextBox();
            label8 = new Label();
            txtDetails = new TextBox();
            label4 = new Label();
            dgvAccounts = new DataGridView();
            lblAccountsHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(288, 59);
            label1.TabIndex = 1;
            label1.Text = "Transfer Page";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(47, 47, 47);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(15, 389);
            btnConfirm.Margin = new Padding(2, 3, 2, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(437, 45);
            btnConfirm.TabIndex = 22;
            btnConfirm.Text = "Confrim";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblDailyLimit
            // 
            lblDailyLimit.AutoSize = true;
            lblDailyLimit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailyLimit.Location = new Point(15, 151);
            lblDailyLimit.Name = "lblDailyLimit";
            lblDailyLimit.Size = new Size(83, 25);
            lblDailyLimit.TabIndex = 23;
            lblDailyLimit.Text = "Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 224);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 25;
            label2.Text = "Payment Type";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.Font = new Font("Segoe UI", 14F);
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(15, 179);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(437, 33);
            cmbAccount.TabIndex = 27;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.Font = new Font("Segoe UI", 14F);
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(15, 252);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(244, 33);
            cmbPaymentType.TabIndex = 28;
            // 
            // txtBeneficiaryAccount
            // 
            txtBeneficiaryAccount.Font = new Font("Segoe UI", 14F);
            txtBeneficiaryAccount.Location = new Point(15, 322);
            txtBeneficiaryAccount.Name = "txtBeneficiaryAccount";
            txtBeneficiaryAccount.Size = new Size(244, 32);
            txtBeneficiaryAccount.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 289);
            label6.Name = "label6";
            label6.Size = new Size(184, 25);
            label6.TabIndex = 33;
            label6.Text = "Beneficiary Account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(279, 292);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 34;
            label7.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 14F);
            txtAmount.Location = new Point(279, 322);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(173, 32);
            txtAmount.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(279, 219);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 36;
            label8.Text = "Details";
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 14F);
            txtDetails.Location = new Point(279, 252);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(173, 32);
            txtDetails.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(565, 40);
            label4.TabIndex = 38;
            label4.Text = "Manage your transfers quickly and securely";
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
            dgvAccounts.Location = new Point(556, 179);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 50;
            dgvAccounts.Size = new Size(379, 255);
            dgvAccounts.TabIndex = 40;
            // 
            // lblAccountsHeader
            // 
            lblAccountsHeader.AutoSize = true;
            lblAccountsHeader.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountsHeader.Location = new Point(556, 151);
            lblAccountsHeader.Name = "lblAccountsHeader";
            lblAccountsHeader.Size = new Size(162, 25);
            lblAccountsHeader.TabIndex = 39;
            lblAccountsHeader.Text = "All Your Accounts";
            // 
            // TransferPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAccounts);
            Controls.Add(lblAccountsHeader);
            Controls.Add(label4);
            Controls.Add(txtDetails);
            Controls.Add(label8);
            Controls.Add(txtAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtBeneficiaryAccount);
            Controls.Add(cmbPaymentType);
            Controls.Add(cmbAccount);
            Controls.Add(label2);
            Controls.Add(lblDailyLimit);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Name = "TransferPage";
            Size = new Size(961, 602);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConfirm;
        private Label lblDailyLimit;
        private Label label2;
        private ComboBox cmbAccount;
        private ComboBox cmbPaymentType;
        private TextBox txtBeneficiaryAccount;
        private Label label6;
        private Label label7;
        private TextBox txtAmount;
        private Label label8;
        private TextBox txtDetails;
        private Label label4;
        private DataGridView dgvAccounts;
        private Label lblAccountsHeader;
    }
}
