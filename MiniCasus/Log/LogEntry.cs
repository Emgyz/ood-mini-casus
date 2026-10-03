namespace MiniCasus.LogTypes;

public enum Severity
{
    Low,
    Medium,
    Critical
}

public interface ILogEntry
{
    public Severity Severity { get; set; }
    public DateTime DateTime { get; set; }
}

public class LogEntry
{
    public Severity Severity { get; set; }
    public DateTime DateTime { get; set; }
}