namespace BlazorApp.Components
{
    public class Log
    {
        public Log (LogLevel severity, string message)
        {
            Severity = severity;
            Message = message;
        }

        public LogLevel Severity { get; set; }

        public string Message { get; set; }

        public override string ToString() => Message;
    }
}
