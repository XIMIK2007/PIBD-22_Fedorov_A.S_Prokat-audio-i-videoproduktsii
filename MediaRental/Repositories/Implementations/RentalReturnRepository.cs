using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

using MediaRental.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

public class RentalReturnRepository(Func<DataContext> createContext, ILogger logger)
    : DatabaseRepository(createContext, logger), IRentalReturnRepository
{
    public IEnumerable<RentalReturn> ReadRentalReturns() =>
        Execute(nameof(ReadRentalReturns), null, db => db.RentalReturns.AsNoTracking().OrderBy(x => x.Id).ToList());

    public void CreateRentalReturn(RentalReturn entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(CreateRentalReturn), new { entity.RentalId, entity.ConsultantId, entity.PaidAmount }, db =>
        {
            db.RentalReturns.Add(entity);
            db.SaveChanges();
            return entity.Id;
        });
    }
}
