namespace Notification.Service.Email;

public interface IEmailService<in TRequest, TResponse>
{
    public Task<TResponse> SendEmailAsync(TRequest request);
}