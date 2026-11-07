using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

// Заглушка первой лабораторной. Работа с БД будет добавлена во второй.
public class RentalRepository : IRentalRepository
{
    public IEnumerable<Rental> ReadRentals() => [];

    public void CreateRental(Rental entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }
}
