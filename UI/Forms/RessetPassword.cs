using Bank.Repositories;
using Bank.Services;

namespace Bank.UI.Forms
{
    public partial class RessetPassword : BaseForm
    {
        private readonly PasswordResetService _resetService;
        private string _email = string.Empty;

        public RessetPassword()
        {
            InitializeComponent();

            var notificationService = new NotificationService(new NotificationRepository());
            var userService = new UserService(new UserRepository(), notificationService);
            _resetService = new PasswordResetService(new PasswordResetRepository(), new EmailService(), userService, notificationService);
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateTo(new LoginForm());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                _resetService.SendCode(txtEmail.Text.Trim());
                _email = txtEmail.Text.Trim();
                panelEmail.Visible = false;
                panelReset.Visible = true;
                MessageBox.Show("Code sent to your email.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    _resetService.ResetPassword(_email, txtCode.Text.Trim(),
                        txtNewPassword.Text, txtConfirmPassword.Text);
                    MessageBox.Show("Password reset successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigateTo(new LoginForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
