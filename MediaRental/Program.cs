using MediaRental.Forms;
using Unity;
using MediaRental.Data;
using Serilog;

namespace MediaRental;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(DataContext.ReadConfiguration())
            .CreateLogger();

        try
        {
            using IUnityContainer container = ContainerConfig.CreateContainer(Log.Logger);
            Application.Run(container.Resolve<MainForm>());
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
