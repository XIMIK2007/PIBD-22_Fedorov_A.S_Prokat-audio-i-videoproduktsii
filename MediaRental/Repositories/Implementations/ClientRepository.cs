using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

using MediaRental.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

public class ClientRepository(Func<DataContext> createContext, ILogger logger)
    : DatabaseRepository(createContext, logger), IClientRepository
{
    public IEnumerable<Client> ReadClients() =>
        Execute(nameof(ReadClients), null, db => db.Clients.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Client? ReadClientById(int id) =>
        Execute(nameof(ReadClientById), id, db => db.Clients.AsNoTracking().SingleOrDefault(x => x.Id == id));

    public void CreateClient(Client entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(CreateClient), new { entity.IsRegular }, db =>
        {
            db.Clients.Add(entity);
            db.SaveChanges();
            return entity.Id;
        });
    }

    public void UpdateClient(Client entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(UpdateClient), entity.Id, db =>
        {
            db.Clients.Update(entity);
            return db.SaveChanges();
        });
    }

    public void DeleteClient(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
        Execute(nameof(DeleteClient), id, db =>
        {
            var entity = db.Clients.Find(id);
            if (entity is null)
                return 0;

            db.Clients.Remove(entity);
            return db.SaveChanges();
        });
    }
}
