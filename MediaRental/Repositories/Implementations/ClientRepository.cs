using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

// Заглушка первой лабораторной. Работа с БД будет добавлена во второй.
public class ClientRepository : IClientRepository
{
    public IEnumerable<Client> ReadClients() => [];

    public Client? ReadClientById(int id) => null;

    public void CreateClient(Client entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void UpdateClient(Client entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void DeleteClient(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
    }
}
