namespace Interview.Services.SOLID.DIP;

public class NotificationWithLowCoupling
{
    private IMessenger _messenger;

    public NotificationWithLowCoupling()
    {
        _messenger = new EmailMessenger();
    }

    public void DoNotify()
    {
        _messenger.Send();
    }
}

public interface IMessenger
{
    void Send();
}

public class EmailMessenger : IMessenger
{
    public void Send()
    {
        // код для отправки email-письма
    }
}

public class SmsMessenger : IMessenger
{
    public void Send()
    {
        // код для отправки SMS
    }
}
