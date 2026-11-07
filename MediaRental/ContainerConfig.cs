using MediaRental.Repositories;
using MediaRental.Repositories.Implementations;
using Unity;

namespace MediaRental;

public static class ContainerConfig
{
    public static IUnityContainer CreateContainer()
    {
        IUnityContainer container = new UnityContainer();
        container.RegisterType<IProductRepository, ProductRepository>();
        container.RegisterType<IClientRepository, ClientRepository>();
        container.RegisterType<IConsultantRepository, ConsultantRepository>();
        container.RegisterType<IRentalRepository, RentalRepository>();
        container.RegisterType<IRentalReturnRepository, RentalReturnRepository>();
        return container;
    }
}
