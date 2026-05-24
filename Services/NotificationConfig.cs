// Services/NotificationConfig.cs
namespace NotificationService.Services
{
    public class NotificationConfig
    {
        // Pehle se mojood
        public int DefaultNumberOfNotifications { get; set; } = 3;
        public string NotificationStyle { get; set; } = "Compact"; // "Compact" or "Detailed"

        // Naye add kiye
        public bool EmailEnabled { get; set; } = true;
        public bool SmsEnabled { get; set; } = false;
        public bool PushEnabled { get; set; } = true;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}