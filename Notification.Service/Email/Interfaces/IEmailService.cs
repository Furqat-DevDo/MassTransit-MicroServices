namespace Notification.Service.Email.Interfaces;

public interface IEmailService
{
    public Task<TResponse> SendEmailAsync<TRequest, TResponse>(TRequest request);
}