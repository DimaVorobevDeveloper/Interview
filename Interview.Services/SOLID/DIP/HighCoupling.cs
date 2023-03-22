namespace Interview.Services.SOLID.DIP;

public class NotificationWithHighCoupling
{
    private readonly Email email;

    public NotificationWithHighCoupling(Email email)
    {
        this.email = email;
    }

    public void EmailDistribution()
    {
        email.Send();
    }
}


public class Email
{
    public void Send()
    {
        // код для отправки email-письма
    }
}
