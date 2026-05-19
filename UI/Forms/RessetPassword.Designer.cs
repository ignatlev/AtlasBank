namespace Bank.UI.Forms
{
    partial class RessetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RessetPassword));
            label3 = new Label();
            RegisterLink = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panelReset = new Panel();
            txtConfirmPassword = new TextBox();
            label9 = new Label();
            txtNewPassword = new TextBox();
            label8 = new Label();
            btnReset = new Button();
            txtCode = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            panelEmail = new Panel();
            label2 = new Label();
            btnSendCode = new Button();
            ResetWelc = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panelReset.SuspendLayout();
            panel1.SuspendLayout();
            panelEmail.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(92, 620);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 14;
            label3.Text = "Already have an account?";
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLink.LinkBehavior = LinkBehavior.NeverUnderline;
            RegisterLink.LinkColor = Color.Black;
            RegisterLink.Location = new Point(239, 620);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(68, 15);
            RegisterLink.TabIndex = 13;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Login Here";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(405, 9);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 33;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(171, 74);
            label5.Name = "label5";
            label5.Size = new Size(180, 50);
            label5.TabIndex = 32;
            label5.Text = "tlas Bank";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(400, 9);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 30;
            label4.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 153);
            panel4.TabIndex = 33;
            // 
            // panelReset
            // 
            panelReset.Controls.Add(txtConfirmPassword);
            panelReset.Controls.Add(label9);
            panelReset.Controls.Add(txtNewPassword);
            panelReset.Controls.Add(label8);
            panelReset.Controls.Add(btnReset);
            panelReset.Controls.Add(txtCode);
            panelReset.Controls.Add(label7);
            panelReset.Location = new Point(0, 141);
            panelReset.Name = "panelReset";
            panelReset.Size = new Size(433, 445);
            panelReset.TabIndex = 35;
            panelReset.Visible = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(46, 178);
            txtConfirmPassword.Margin = new Padding(2, 3, 2, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(325, 23);
            txtConfirmPassword.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(47, 156);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(118, 17);
            label9.TabIndex = 15;
            label9.Text = "Confrim password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(46, 122);
            txtNewPassword.Margin = new Padding(2, 3, 2, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(325, 23);
            txtNewPassword.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 100);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 17);
            label8.TabIndex = 13;
            label8.Text = "New password";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(47, 47, 47);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(44, 235);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(327, 38);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            
            
            // txtCode
            // 
            txtCode.Location = new Point(48, 62);
            txtCode.Margin = new Padding(2, 3, 2, 3);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(325, 23);
            txtCode.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 40);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 17);
            label7.TabIndex = 11;
            label7.Text = "Enter code from email";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelReset);
            panel1.Controls.Add(panelEmail);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RegisterLink);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 652);
            panel1.TabIndex = 6;
            // 
            // panelEmail
            // 
            panelEmail.Controls.Add(label2);
            panelEmail.Controls.Add(btnSendCode);
            panelEmail.Controls.Add(ResetWelc);
            panelEmail.Controls.Add(txtEmail);
            panelEmail.Controls.Add(label1);
            panelEmail.Location = new Point(0, 144);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(433, 445);
            panelEmail.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(67, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(287, 34);
            label2.TabIndex = 10;
            label2.Text = "Enter your email address and we’ll send you a\r\ncode to reset your password ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.FromArgb(47, 47, 47);
            btnSendCode.Cursor = Cursors.Hand;
            btnSendCode.FlatAppearance.BorderSize = 0;
            btnSendCode.FlatStyle = FlatStyle.Flat;
            btnSendCode.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(48, 160);
            btnSendCode.Margin = new Padding(2, 3, 2, 3);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(327, 38);
            btnSendCode.TabIndex = 7;
            btnSendCode.Text = "Reset password";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // ResetWelc
            // 
            ResetWelc.AccessibleRole = AccessibleRole.OutlineButton;
            ResetWelc.AutoSize = true;
            ResetWelc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetWelc.Location = new Point(110, 12);
            ResetWelc.Margin = new Padding(2, 0, 2, 0);
            ResetWelc.Name = "ResetWelc";
            ResetWelc.Size = new Size(212, 30);
            ResetWelc.TabIndex = 9;
            ResetWelc.Text = "Reset your password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 121);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 23);
            txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 99);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // RessetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 652);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RessetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RessetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelReset.ResumeLayout(false);
            panelReset.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private LinkLabel RegisterLink;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel1;
        private Panel panelReset;
        private Panel panelEmail;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button btnSendCode;
        private TextBox txtEmail;
        private Label label1;
        private Label ResetWelc;
        private Label label2;
        private Button btnReset;
        private TextBox txtCode;
        private Label label7;
        private TextBox txtConfirmPassword;
        private Label label9;
        private TextBox txtNewPassword;
        private Label label8;
    }
}