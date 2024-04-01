using Serilog.Configuration;

namespace Serilog.Sinks.Onspring
{
  /// <summary>
  /// Class containing extension methods to <see cref="LoggerSinkConfiguration"/>, configuring sinks 
  /// sending log events to Onspring.
  /// </summary>
  public static class LoggerConfigurationOnspringExtensions
  {
    /// <summary>
    /// Adds a non-durable sink that will send log events to Onspring.
    /// A non-durable sink will lose data after a system or process restart.
    /// </summary>
    /// <param name="loggerConfiguration"></param>
    public static LoggerConfiguration Onspring(this LoggerSinkConfiguration loggerConfiguration)
    {
      return loggerConfiguration.Sink(new OnspringSink());
    }
  }
}