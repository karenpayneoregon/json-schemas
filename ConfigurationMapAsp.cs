
namespace WinFormsApp1
{
    public enum ConfigurationMapAsp
    {
        Development,
        Stage,
        Production
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }


}
