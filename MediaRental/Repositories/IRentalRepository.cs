using MediaRental.Entities;

namespace MediaRental.Repositories;

public interface IRentalRepository
{
    IEnumerable<Rental> ReadRentals();

    void CreateRental(Rental entity);
}
