using System.Net;
using System.Net.Mail;

namespace Interview.Services.DirectoryAnalyzer;

public class MailService : IMailService
{
    private readonly EmailConfiguration config;

    public MailService(
        EmailConfiguration config)
    {
        this.config = config;
    }

    public async Task Send(string to, string from = "", string subject = "", string body = "")
    {
        //MailMessage m = new MailMessage("mymail@gmail.com", match.Value);
        //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //smtp.Credentials = new NetworkCredential("mymail@gmail.com", "0987654321");
        //smtp.EnableSsl = true;
        //smtp.Send(m);

        var msg = new MailMessage
        {
            Subject = subject,
            From = new MailAddress(from),
            Body = body,
            To = { new MailAddress(to) },
            IsBodyHtml = true
        };

        var smtpClient = new SmtpClient(config.Host, port: config.Port.Value)
        {
            Credentials = new NetworkCredential(config.Login, config.Password),
            EnableSsl = true
        };

        try
        {
            await smtpClient.SendMailAsync(msg);
        }
        catch (Exception e)
        {
            // log error
        }
    }

    public Task Send(string[] to)
    {
        throw new NotImplementedException();
    }
}