using MediaRental.Forms;
using Unity;

namespace MediaRental;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        using IUnityContainer container = ContainerConfig.CreateContainer();
        Application.Run(container.Resolve<MainForm>());
    }
}
