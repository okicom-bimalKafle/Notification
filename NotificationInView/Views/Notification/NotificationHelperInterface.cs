namespace NotificationInView.Views.Notification
{
    public interface NotificationHelperInterface
    {
        void ShowSuccess(string message);
        void ShowError(string message);
        void ShowWarning(string message);
        void ShowInfo(string message);
    }
}
