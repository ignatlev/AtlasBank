namespace Bank.UI.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label3 = new Label();
            LoginLink = new LinkLabel();
            btnRegister = new Button();
            label2 = new Label();
            txtRegEmail = new TextBox();
            label1 = new Label();
            Welcome = new Label();
            RegPassword = new Label();
            txtRegPassword = new TextBox();
            label4 = new Label();
            txtRegSurname = new TextBox();
            label5 = new Label();
            txtRegName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtRegConfirm = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtRegUsername = new TextBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label3.TabIndex = 26;
            label3.Text = "Already have an account?";
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLink.LinkBehavior = LinkBehavior.NeverUnderline;
            LoginLink.LinkColor = Color.Black;
            LoginLink.Location = new Point(239, 620);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(66, 15);
            LoginLink.TabIndex = 25;
            LoginLink.TabStop = true;
            LoginLink.Text = "Login here";
            LoginLink.LinkClicked += LoginLink_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(47, 47, 47);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(51, 544);
            btnRegister.Margin = new Padding(2, 3, 2, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(327, 38);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(51, 340);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 21;
            label2.Text = "Username";
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(50, 304);
            txtRegEmail.Margin = new Padding(2, 3, 2, 3);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(325, 23);
            txtRegEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(50, 282);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 18;
            label1.Text = "Email Address";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Segoe UI", 16F);
            Welcome.Location = new Point(154, 112);
            Welcome.Margin = new Padding(2, 0, 2, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(110, 30);
            Welcome.TabIndex = 17;
            Welcome.Text = "Welcome!";
            // 
            // RegPassword
            // 
            RegPassword.AutoSize = true;
            RegPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            RegPassword.Location = new Point(51, 401);
            RegPassword.Margin = new Padding(2, 0, 2, 0);
            RegPassword.Name = "RegPassword";
            RegPassword.Size = new Size(66, 17);
            RegPassword.TabIndex = 28;
            RegPassword.Text = "Password";
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(51, 423);
            txtRegPassword.Margin = new Padding(2, 3, 2, 3);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(324, 23);
            txtRegPassword.TabIndex = 4;
            txtRegPassword.UseSystemPasswordChar = true;
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
            label4.TabIndex = 29;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // txtRegSurname
            // 
            txtRegSurname.Location = new Point(51, 240);
            txtRegSurname.Margin = new Padding(2, 3, 2, 3);
            txtRegSurname.Name = "txtRegSurname";
            txtRegSurname.Size = new Size(325, 23);
            txtRegSurname.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(50, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 20;
            label5.Text = "Surname";
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(51, 179);
            txtRegName.Margin = new Padding(2, 3, 2, 3);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(325, 23);
            txtRegName.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(51, 157);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 30;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(50, 469);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 17);
            label7.TabIndex = 33;
            label7.Text = "Confirm password";
            // 
            // txtRegConfirm
            // 
            txtRegConfirm.Location = new Point(50, 491);
            txtRegConfirm.Margin = new Padding(2, 3, 2, 3);
            txtRegConfirm.Name = "txtRegConfirm";
            txtRegConfirm.Size = new Size(324, 23);
            txtRegConfirm.TabIndex = 5;
            txtRegConfirm.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(154, 49);
            label8.Name = "label8";
            label8.Size = new Size(180, 50);
            label8.TabIndex = 35;
            label8.Text = "tlas Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(50, 362);
            txtRegUsername.Margin = new Padding(2, 3, 2, 3);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(324, 23);
            txtRegUsername.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(355, 428);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(36, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 483);
            panel1.TabIndex = 36;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 652);
            Controls.Add(checkBox1);
            Controls.Add(txtRegConfirm);
            Controls.Add(txtRegPassword);
            Controls.Add(txtRegUsername);
            Controls.Add(txtRegEmail);
            Controls.Add(txtRegSurname);
            Controls.Add(txtRegName);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(RegPassword);
            Controls.Add(label3);
            Controls.Add(LoginLink);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Welcome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private LinkLabel LoginLink;
        private Button btnRegister;
        private Label label2;
        private TextBox txtRegEmail;
        private Label label1;
        private Label Welcome;
        private Label RegPassword;
        private TextBox txtRegPassword;
        private Label label4;
        private TextBox txtRegSurname;
        private Label label5;
        private TextBox txtRegName;
        private Label label6;
        private Label label7;
        private TextBox txtRegConfirm;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtRegUsername;
        private CheckBox checkBox1;
        private Panel panel1;
    }
}