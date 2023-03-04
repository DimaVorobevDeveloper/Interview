using System.Text.RegularExpressions;

namespace Interview.Services.DirectoryAnalyzer;

public static class DirectoryAnalyzer
{
    private const int TextLengthMax = 65535;
    private const string EmailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

    public static void Do(string directory)
    {
        IMailService mailService = new MailService(null);

        foreach (var f in Directory.GetFiles(directory))
        {
            var ext = Path.GetExtension(f);
            switch (ext)
            {
                case ".log" when File.ReadAllText(f).Length > TextLengthMax:
                    File.WriteAllText(f, "");
                    break;
                case ".log":
                    File.AppendAllLines(f, new[] { "Analyzed " + DateTime.Today.ToString() });
                    break;
                case ".tmp":
                    File.Delete(f);
                    break;
                case ".txt" when Regex.IsMatch(f, @"e-mail\s"):
                {
                    var lines = File.ReadAllLines(f);
                    var values = lines.SelectMany(line => Regex.Matches(line, EmailPattern)).Select(x => x.Value);
                    mailService.Send(values.ToArray());
                    //foreach (var line in File.ReadAllLines(f))
                    //{
                    //    foreach (Match to in Regex.Matches(line, EmailPattern))
                    //    {
                    //        IMailService mailService = new MailService(null);
                    //        mailService.Send(to.Value);
                    //    }
                    //}

                    break;
                }
            }
        }

        foreach (var d in Directory.GetDirectories(directory))
        {
            Do(d);
        }
    }
}