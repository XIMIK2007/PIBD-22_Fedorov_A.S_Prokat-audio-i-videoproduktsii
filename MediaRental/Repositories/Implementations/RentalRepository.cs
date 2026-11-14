using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

using MediaRental.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

public class RentalRepository(Func<DataContext> createContext, ILogger logger)
    : DatabaseRepository(createContext, logger), IRentalRepository
{
    public IEnumerable<Rental> ReadRentals() =>
        Execute(nameof(ReadRentals), null, db => db.Rentals.AsNoTracking().Include(x => x.Items).OrderBy(x => x.Id).ToList());

    public void CreateRental(Rental entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(CreateRental), new { entity.ClientId, entity.ConsultantId, entity.DueDate, ItemCount = entity.Items.Count() }, db =>
        {
            var items = entity.Items.Select(item => RentalItem.CreateEntity(0, 0, item.ProductId, item.DailyPrice));
            var rental = Rental.CreateOperation(0, entity.ClientId, entity.ConsultantId, entity.DueDate, items);
            using var transaction = db.Database.BeginTransaction();
            db.Rentals.Add(rental);
            db.SaveChanges();
            transaction.Commit();
            return rental.Id;
        });
    }
}
