using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

using MediaRental.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

public class ConsultantRepository(Func<DataContext> createContext, ILogger logger)
    : DatabaseRepository(createContext, logger), IConsultantRepository
{
    public IEnumerable<Consultant> ReadConsultants() =>
        Execute(nameof(ReadConsultants), null, db => db.Consultants.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Consultant? ReadConsultantById(int id) =>
        Execute(nameof(ReadConsultantById), id, db => db.Consultants.AsNoTracking().SingleOrDefault(x => x.Id == id));

    public void CreateConsultant(Consultant entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(CreateConsultant), new { HasPhone = entity.Phone.Length > 0 }, db =>
        {
            db.Consultants.Add(entity);
            db.SaveChanges();
            return entity.Id;
        });
    }

    public void UpdateConsultant(Consultant entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(UpdateConsultant), entity.Id, db =>
        {
            db.Consultants.Update(entity);
            return db.SaveChanges();
        });
    }

    public void DeleteConsultant(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
        Execute(nameof(DeleteConsultant), id, db =>
        {
            var entity = db.Consultants.Find(id);
            if (entity is null)
                return 0;

            db.Consultants.Remove(entity);
            return db.SaveChanges();
        });
    }
}
