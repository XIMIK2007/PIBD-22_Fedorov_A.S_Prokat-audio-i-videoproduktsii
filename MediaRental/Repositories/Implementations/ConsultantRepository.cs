using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

// Заглушка первой лабораторной. Работа с БД будет добавлена во второй.
public class ConsultantRepository : IConsultantRepository
{
    public IEnumerable<Consultant> ReadConsultants() => [];

    public Consultant? ReadConsultantById(int id) => null;

    public void CreateConsultant(Consultant entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void UpdateConsultant(Consultant entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void DeleteConsultant(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
    }
}
