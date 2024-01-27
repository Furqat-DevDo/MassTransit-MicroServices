namespace Notification.Service.Email.Options;

public record SmtpOptions(string From, string SmtpServer, string Port, string Username, string Password);
