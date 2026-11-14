using MediaRental.Repositories;
using MediaRental.Repositories.Implementations;
using Unity;
using MediaRental.Data;
using Serilog;

namespace MediaRental;

public static class ContainerConfig
{
    public static IUnityContainer CreateContainer(ILogger logger)
    {
        IUnityContainer container = new UnityContainer();
        container.RegisterType<DataContext>();
        container.RegisterFactory<Func<DataContext>>(c => () => c.Resolve<DataContext>());
        container.RegisterInstance<ILogger>(logger);
        container.RegisterType<IProductRepository, ProductRepository>();
        container.RegisterType<IClientRepository, ClientRepository>();
        container.RegisterType<IConsultantRepository, ConsultantRepository>();
        container.RegisterType<IRentalRepository, RentalRepository>();
        container.RegisterType<IRentalReturnRepository, RentalReturnRepository>();
        return container;
    }
}
