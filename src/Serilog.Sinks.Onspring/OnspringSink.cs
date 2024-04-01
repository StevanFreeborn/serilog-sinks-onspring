using System;

using Serilog.Core;
using Serilog.Events;

namespace Serilog.Sinks.Onspring
{
  class OnspringSink : ILogEventSink, IDisposable
  {
    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public void Emit(LogEvent logEvent)
    {
      throw new NotImplementedException();
    }
  }
}
