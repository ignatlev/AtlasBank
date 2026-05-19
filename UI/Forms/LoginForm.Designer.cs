namespace Bank.UI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLoggin = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            RegisterLink = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            WelcomeBack = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(50, 245);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(325, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 306);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(324, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLoggin
            // 
            btnLoggin.BackColor = Color.FromArgb(47, 47, 47);
            btnLoggin.Cursor = Cursors.Hand;
            btnLoggin.FlatAppearance.BorderSize = 0;
            btnLoggin.FlatStyle = FlatStyle.Flat;
            btnLoggin.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoggin.ForeColor = Color.White;
            btnLoggin.Location = new Point(53, 363);
            btnLoggin.Margin = new Padding(2, 3, 2, 3);
            btnLoggin.Name = "btnLoggin";
            btnLoggin.Size = new Size(327, 38);
            btnLoggin.TabIndex = 2;
            btnLoggin.Text = "LOGIN";
            btnLoggin.UseVisualStyleBackColor = false;
            btnLoggin.Click += btnLoggin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RegisterLink);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLoggin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(WelcomeBack);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 652);
            panel1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.FlatAppearance.BorderColor = Color.Black;
            checkBox1.ForeColor = SystemColors.ButtonShadow;
            checkBox1.Location = new Point(354, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(92, 620);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 14;
            label3.Text = "Don't have an account?";
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLink.LinkBehavior = LinkBehavior.NeverUnderline;
            RegisterLink.LinkColor = Color.Black;
            RegisterLink.Location = new Point(239, 620);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(83, 15);
            RegisterLink.TabIndex = 13;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register here";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(156, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget My Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 284);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 223);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // WelcomeBack
            // 
            WelcomeBack.AutoSize = true;
            WelcomeBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeBack.Location = new Point(129, 177);
            WelcomeBack.Margin = new Padding(2, 0, 2, 0);
            WelcomeBack.Name = "WelcomeBack";
            WelcomeBack.Size = new Size(158, 30);
            WelcomeBack.TabIndex = 5;
            WelcomeBack.Text = "Welcome Back!";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 252);
            panel2.TabIndex = 34;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(434, 650);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLoggin;
        private Panel panel1;
        private Label label1;
        private Label WelcomeBack;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private LinkLabel RegisterLink;
        private Label label4;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel2;
    }
}
