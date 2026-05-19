using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.UI.Controls;

namespace Bank.UI.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly User _currentUser;
        private readonly System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private readonly NotificationService _notificationService;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            _notificationService = new NotificationService(new NotificationRepository());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text =  _currentUser.Username;
            lblEmail.Text = _currentUser.Email;
            InitializePages();
            homeMain1.LoadData();
            UpdateNotificationText();

            _timer.Interval = 5000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateNotificationText();
        }

        private void InitializePages()
        {
            foreach (IUserPage page in GetAllPages())
            {
                page.SetUser(_currentUser);
            }
        }

        private IEnumerable<IUserPage> GetAllPages()
        {
            yield return homeMain1;
            yield return accountPage1;
            yield return cardPage1;
            yield return transactionPage1;
            yield return transferPage1;
            yield return notificationPage1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeMain1.LoadData();
            homeMain1.BringToFront();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            accountPage1.LoadData();
            accountPage1.BringToFront();
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            cardPage1.LoadData();
            cardPage1.BringToFront();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            transactionPage1.LoadData();
            transactionPage1.BringToFront();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            transferPage1.LoadData();
            transferPage1.BringToFront();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            notificationPage1.LoadData();
            notificationPage1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Confirm("Are you sure you want to logout?"))
            {
                NavigateTo(new LoginForm());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateNotificationText()
        {
            List<Notification> notifications = _notificationService.GetAll(_currentUser.Id);

            int unread = 0;
            foreach (Notification n in notifications)
            {
                if (!n.IsRead)
                {
                    unread++;
                }
            }

            if (unread > 0)
            {
                btnNotifications.Text = string.Format("          Notifications ({0})", unread);
                btnNotifications.Image = Properties.Resources.icon_notification_unread_1_;
            }
            else
            {
                btnNotifications.Text = "          Notifications";
                btnNotifications.Image = Properties.Resources.icon_notification;
            }
        }
    }
}