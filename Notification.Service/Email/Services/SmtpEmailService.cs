using Notification.Service.Email.Requests;
using Notification.Service.Email.Responses;

namespace Notification.Service.Email.Services;

public class SmtpEmailService : IEmailService<SmtpRequest,SmtpResponse>
{
    public Task<SmtpResponse> SendEmailAsync(SmtpRequest request)
    {
        throw new NotImplementedException();
    }
}