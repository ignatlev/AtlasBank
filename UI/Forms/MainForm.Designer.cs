namespace Bank.UI.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            btnNotifications = new Button();
            panel3 = new Panel();
            lblUsername = new Label();
            lblEmail = new Label();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnTransfer = new Button();
            btnTransactionHistory = new Button();
            btnCards = new Button();
            btnAccounts = new Button();
            btnHome = new Button();
            label4 = new Label();
            panel5 = new Panel();
            homeMain1 = new Bank.UI.Controls.HomeMain();
            transferPage1 = new Bank.UI.Controls.TransferPage();
            transactionPage1 = new Bank.UI.Controls.TransactionPage();
            notificationPage1 = new Bank.UI.Controls.NotificationPage();
            cardPage1 = new Bank.UI.Controls.CardPage();
            accountPage1 = new Bank.UI.Controls.AccountPage();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnNotifications);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnTransfer);
            panel2.Controls.Add(btnTransactionHistory);
            panel2.Controls.Add(btnCards);
            panel2.Controls.Add(btnAccounts);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 607);
            panel2.TabIndex = 1;
            // 
            // btnNotifications
            // 
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.Dock = DockStyle.Top;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotifications.Image = Properties.Resources.icon_notification;
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 185);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(192, 37);
            btnNotifications.TabIndex = 7;
            btnNotifications.Text = "          Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblUsername);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnLogout);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 507);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 100);
            panel3.TabIndex = 6;
            // 
            // lblUsername
            // 
            lblUsername.AccessibleRole = AccessibleRole.None;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(42, 63);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "username";
            // 
            // lblEmail
            // 
            lblEmail.AccessibleRole = AccessibleRole.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(85, 85, 85);
            lblEmail.Location = new Point(43, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(35, 13);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "email";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Sample_User_Icon;
            pictureBox2.Location = new Point(-7, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = Properties.Resources.User_Interface_Logout_icon1;
            btnLogout.Location = new Point(158, 56);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(29, 23);
            btnLogout.TabIndex = 1;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Cursor = Cursors.Hand;
            btnTransfer.Dock = DockStyle.Top;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.Image = Properties.Resources._131779_200_1_;
            btnTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransfer.Location = new Point(0, 148);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(192, 37);
            btnTransfer.TabIndex = 5;
            btnTransfer.Text = "          Transfer";
            btnTransfer.TextAlign = ContentAlignment.MiddleLeft;
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.Cursor = Cursors.Hand;
            btnTransactionHistory.Dock = DockStyle.Top;
            btnTransactionHistory.FlatAppearance.BorderSize = 0;
            btnTransactionHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnTransactionHistory.FlatStyle = FlatStyle.Flat;
            btnTransactionHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactionHistory.Image = Properties.Resources._8373545_1_;
            btnTransactionHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactionHistory.Location = new Point(0, 111);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(192, 37);
            btnTransactionHistory.TabIndex = 4;
            btnTransactionHistory.Text = "          Transaction history";
            btnTransactionHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactionHistory.UseVisualStyleBackColor = true;
            btnTransactionHistory.Click += btnTransactionHistory_Click;
            // 
            // btnCards
            // 
            btnCards.Cursor = Cursors.Hand;
            btnCards.Dock = DockStyle.Top;
            btnCards.FlatAppearance.BorderSize = 0;
            btnCards.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnCards.FlatStyle = FlatStyle.Flat;
            btnCards.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCards.Image = Properties.Resources._656975_1_;
            btnCards.ImageAlign = ContentAlignment.MiddleLeft;
            btnCards.Location = new Point(0, 74);
            btnCards.Name = "btnCards";
            btnCards.Size = new Size(192, 37);
            btnCards.TabIndex = 3;
            btnCards.Text = "          Cards";
            btnCards.TextAlign = ContentAlignment.MiddleLeft;
            btnCards.UseVisualStyleBackColor = true;
            btnCards.Click += btnCards_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.Cursor = Cursors.Hand;
            btnAccounts.Dock = DockStyle.Top;
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccounts.Image = Properties.Resources._1570887_1_;
            btnAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccounts.Location = new Point(0, 37);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(192, 37);
            btnAccounts.TabIndex = 2;
            btnAccounts.Text = "          Accounts";
            btnAccounts.TextAlign = ContentAlignment.MiddleLeft;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(192, 37);
            btnHome.TabIndex = 1;
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 22F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1123, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 41);
            label4.TabIndex = 30;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(homeMain1);
            panel5.Controls.Add(transferPage1);
            panel5.Controls.Add(transactionPage1);
            panel5.Controls.Add(notificationPage1);
            panel5.Controls.Add(cardPage1);
            panel5.Controls.Add(accountPage1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(192, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 607);
            panel5.TabIndex = 36;
            // 
            // homeMain1
            // 
            homeMain1.BackColor = SystemColors.ButtonHighlight;
            homeMain1.Dock = DockStyle.Fill;
            homeMain1.Location = new Point(0, 0);
            homeMain1.Name = "homeMain1";
            homeMain1.Size = new Size(970, 607);
            homeMain1.TabIndex = 0;
            // 
            // transferPage1
            // 
            transferPage1.Dock = DockStyle.Fill;
            transferPage1.Location = new Point(0, 0);
            transferPage1.Name = "transferPage1";
            transferPage1.Size = new Size(970, 607);
            transferPage1.TabIndex = 5;
            // 
            // transactionPage1
            // 
            transactionPage1.Dock = DockStyle.Fill;
            transactionPage1.Location = new Point(0, 0);
            transactionPage1.Name = "transactionPage1";
            transactionPage1.Size = new Size(970, 607);
            transactionPage1.TabIndex = 4;
            // 
            // notificationPage1
            // 
            notificationPage1.Dock = DockStyle.Fill;
            notificationPage1.Location = new Point(0, 0);
            notificationPage1.Name = "notificationPage1";
            notificationPage1.Size = new Size(970, 607);
            notificationPage1.TabIndex = 3;
            // 
            // cardPage1
            // 
            cardPage1.Dock = DockStyle.Fill;
            cardPage1.Location = new Point(0, 0);
            cardPage1.Name = "cardPage1";
            cardPage1.Size = new Size(970, 607);
            cardPage1.TabIndex = 2;
            // 
            // accountPage1
            // 
            accountPage1.Dock = DockStyle.Fill;
            accountPage1.Location = new Point(0, 0);
            accountPage1.Name = "accountPage1";
            accountPage1.Size = new Size(970, 607);
            accountPage1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 1;
            label1.Text = "tlas Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1162, 46);
            panel4.TabIndex = 35;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 653);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnHome;
        private Button btnTransactionHistory;
        private Button btnCards;
        private Button btnAccounts;
        private Button btnTransfer;
        private Panel panel3;
        private Label label4;
        private Button btnLogout;
        private Label lblUsername;
        private PictureBox pictureBox2;
        private Label lblEmail;
        private Button btnNotifications;
        private Panel panel5;
        private UI.Controls.HomeMain homeMain1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private UI.Controls.TransferPage transferPage1;
        private UI.Controls.TransactionPage transactionPage1;
        private UI.Controls.NotificationPage notificationPage1;
        private UI.Controls.CardPage cardPage1;
        private UI.Controls.AccountPage accountPage1;
    }
}