using Notification.Service.Email.Requests;
using Notification.Service.Email.Responses;

namespace Notification.Service.Email.Services;

public class MailKitEmailService : IEmailService<MailKitRequest, MailKitResponse>
{
    public Task<MailKitResponse> SendEmailAsync(MailKitRequest request)
    {
        throw new NotImplementedException();
    }
}