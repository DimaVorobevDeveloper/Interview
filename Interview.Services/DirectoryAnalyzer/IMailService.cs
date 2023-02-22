namespace Interview.Services.DirectoryAnalyzer;

public interface IMailService
{
    Task Send(string to, string from = "", string subject = "", string body = "");

    Task Send(string[] to);
}