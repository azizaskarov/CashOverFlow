using System;

namespace CashOverFlow.Brokers.Loggings;

public interface ILoggingBroker
{
    void LogError(Exception  exception);
    void LogCritical(Exception  exception);
}
