using Bank.Models;
using Bank.Repositories;
using Bank.Services;

namespace Bank.UI.Forms
{
    public partial class SignUp : BaseForm
    {
        private readonly UserService _userService;

        public SignUp()
        {
            InitializeComponent();

            var notificationService = new NotificationService(new NotificationRepository());
            _userService = new UserService(new UserRepository(), notificationService);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _userService.Register(
                    txtRegUsername.Text,
                    txtRegName.Text,
                    txtRegSurname.Text,
                    txtRegEmail.Text,
                    txtRegPassword.Text,
                    txtRegConfirm.Text
                );
                ShowSuccess(string.Format("Account created! Welcome, {0}.", user.Name));
                NavigateTo(new LoginForm());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtRegPassword.UseSystemPasswordChar = false;
                txtRegConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtRegPassword.UseSystemPasswordChar = true;
                txtRegConfirm.UseSystemPasswordChar = true;
            }
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateTo(new LoginForm());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}