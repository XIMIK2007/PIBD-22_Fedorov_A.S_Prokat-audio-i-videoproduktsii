using MediaRental.Entities;

namespace MediaRental.Repositories;

public interface IRentalReturnRepository
{
    IEnumerable<RentalReturn> ReadRentalReturns();

    void CreateRentalReturn(RentalReturn entity);
}
