using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

// Заглушка первой лабораторной. Работа с БД будет добавлена во второй.
public class RentalReturnRepository : IRentalReturnRepository
{
    public IEnumerable<RentalReturn> ReadRentalReturns() => [];

    public void CreateRentalReturn(RentalReturn entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }
}
