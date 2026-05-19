using Bank.Models;

namespace Bank.UI.Controls
{
    public interface IUserPage
    {
        void SetUser(User user);
        void LoadData();
    }
}