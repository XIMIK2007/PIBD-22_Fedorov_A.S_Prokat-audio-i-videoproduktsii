using MediaRental.Entities;

namespace MediaRental.Repositories;

public interface IClientRepository
{
    IEnumerable<Client> ReadClients();

    Client? ReadClientById(int id);

    void CreateClient(Client entity);

    void UpdateClient(Client entity);

    void DeleteClient(int id);
}
