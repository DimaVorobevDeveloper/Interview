using System.Security;

namespace Interview.Services.DirectoryAnalyzer;

public class EmailConfiguration
{
    public string? Host { get; set; }
    public int? Port { get; set; }
    public string? Login { get; set; }
    public SecureString Password { get; set; }
}