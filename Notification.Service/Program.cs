using Notification.Service.Email.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<SmtpOptions>(builder.Configuration.GetSection("SmtpOptions"));
builder.Services.Configure<MailKitOptions>(builder.Configuration.GetSection("MailKitOptions"));
    
var app = builder.Build();

app.UseHttpsRedirection();

app.Run();
