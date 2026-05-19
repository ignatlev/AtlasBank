namespace Bank.UI.Controls
{
    partial class NotificationPage
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
            btnMarkAllRead = new Button();
            lblUnread = new Label();
            dgvNotifications = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(364, 59);
            label1.TabIndex = 1;
            label1.Text = "Notification Page";
            // 
            // btnMarkAllRead
            // 
            btnMarkAllRead.BackColor = Color.FromArgb(47, 47, 47);
            btnMarkAllRead.FlatAppearance.BorderSize = 0;
            btnMarkAllRead.FlatStyle = FlatStyle.Flat;
            btnMarkAllRead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnMarkAllRead.ForeColor = Color.White;
            btnMarkAllRead.Location = new Point(723, 94);
            btnMarkAllRead.Name = "btnMarkAllRead";
            btnMarkAllRead.Size = new Size(166, 40);
            btnMarkAllRead.TabIndex = 3;
            btnMarkAllRead.Text = "Mark As Read";
            btnMarkAllRead.UseVisualStyleBackColor = false;
            btnMarkAllRead.Click += btnMarkAllRead_Click_1;
            // 
            // lblUnread
            // 
            lblUnread.AutoSize = true;
            lblUnread.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnread.ForeColor = Color.DarkOrange;
            lblUnread.Location = new Point(28, 91);
            lblUnread.Name = "lblUnread";
            lblUnread.Size = new Size(324, 40);
            lblUnread.TabIndex = 4;
            lblUnread.Text = "x unread notification(s)";
            // 
            // dgvNotifications
            // 
            dgvNotifications.AllowUserToAddRows = false;
            dgvNotifications.AllowUserToDeleteRows = false;
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotifications.BackgroundColor = Color.White;
            dgvNotifications.BorderStyle = BorderStyle.None;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.GridColor = Color.Black;
            dgvNotifications.Location = new Point(28, 173);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.ReadOnly = true;
            dgvNotifications.RowHeadersWidth = 50;
            dgvNotifications.Size = new Size(861, 356);
            dgvNotifications.TabIndex = 14;
            // 
            // NotificationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNotifications);
            Controls.Add(lblUnread);
            Controls.Add(btnMarkAllRead);
            Controls.Add(label1);
            Name = "NotificationPage";
            Size = new Size(961, 602);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMarkAllRead;
        private Label lblUnread;
        private DataGridView dgvNotifications;
    }
}
