using Bank.Models;
using Bank.Repositories;
using Bank.Services;

namespace Bank.UI.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            var notificationService = new NotificationService(new NotificationRepository());
            _userService = new UserService(new UserRepository(), notificationService);
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _userService.Login(txtUsername.Text, txtPassword.Text);
                ShowSuccess(string.Format("Welcome back, {0}!", user.Username));
                NavigateTo(new MainForm(user));
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateTo(new SignUp());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateTo(new RessetPassword());
        }
    }
}