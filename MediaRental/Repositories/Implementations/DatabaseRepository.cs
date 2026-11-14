using MediaRental.Data;
using Serilog;

namespace MediaRental.Repositories.Implementations;

public abstract class DatabaseRepository(Func<DataContext> createContext, ILogger logger)
{
    protected TResult Execute<TResult>(string operation, object? input, Func<DataContext, TResult> action)
    {
        logger.Information("Начало операции {Operation}. Параметры: {@Input}", operation, input);
        try
        {
            using var context = createContext();
            TResult result = action(context);
            object summary = result switch
            {
                System.Collections.ICollection rows => rows.Count,
                int number => number,
                _ => result is not null
            };
            logger.Information("Операция {Operation} выполнена. Результат: {Result}", operation, summary);
            return result;
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Ошибка операции {Operation}", operation);
            throw;
        }
    }
}
