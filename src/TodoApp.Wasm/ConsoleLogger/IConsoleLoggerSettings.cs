using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Uno.Logging.Console
{
    public interface IConsoleLoggerSettings
    {
        bool IncludeScopes { get; }

        IChangeToken ChangeToken { get; }

        bool TryGetSwitch(string name, out LogLevel level);

        IConsoleLoggerSettings Reload();
    }
}
