namespace Bank.UI.Forms
{
    public class BaseForm : Form
    {
        protected void ShowError(string message)
        {
            MessageBox.Show(message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected bool Confirm(string message)
        {
            return MessageBox.Show(message, "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        protected void NavigateTo(Form form)
        {
            form.Show();
            Hide();
        }
    }
}