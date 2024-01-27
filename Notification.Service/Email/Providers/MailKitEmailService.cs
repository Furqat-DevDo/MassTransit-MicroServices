using Notification.Service.Email.Interfaces;

namespace Notification.Service.Email.Providers;

public class MailKitEmailService : IEmailService
{
    public Task<TResponse> SendEmailAsync<TRequest, TResponse>(TRequest request)
    {
        throw new NotImplementedException();
    }
}