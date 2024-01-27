using Notification.Service.Email.Interfaces;

namespace Notification.Service.Email.Providers;

public class SmtpEmailService : IEmailService
{
    public Task<TResponse> SendEmailAsync<TRequest, TResponse>(TRequest request)
    {
        throw new NotImplementedException();
    }
}