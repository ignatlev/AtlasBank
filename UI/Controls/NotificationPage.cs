using Bank.Models;
using Bank.Repositories;
using Bank.Services;
using Bank.Utils;

namespace Bank.UI.Controls
{
    public partial class NotificationPage : System.Windows.Forms.UserControl, IUserPage
    {
        private User? _currentUser;
        private readonly NotificationService _notificationService;

        public NotificationPage()
        {
            InitializeComponent();
            GridHelper.SetupNotificationsGrid(dgvNotifications);

            _notificationService = new NotificationService(new NotificationRepository());
        }

        public void SetUser(User user)
        {
            _currentUser = user;
        }

        public void LoadData()
        {
            if (_currentUser == null)
            {
                return;
            }

            List<Notification> notifications = _notificationService.GetAll(_currentUser.Id);
            GridHelper.LoadNotifications(dgvNotifications, notifications);

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
                lblUnread.Text = string.Format("{0} unread notification(s)", unread);
                lblUnread.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblUnread.Text = "All caught up!";
                lblUnread.ForeColor = Color.DarkGreen;
            }
        }

        private void btnMarkAllRead_Click_1(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                return;
            }

            _notificationService.MarkAllRead(_currentUser.Id);
            LoadData();
        }
    }
}