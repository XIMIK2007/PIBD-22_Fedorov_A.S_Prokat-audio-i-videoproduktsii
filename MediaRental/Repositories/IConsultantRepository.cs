using MediaRental.Entities;

namespace MediaRental.Repositories;

public interface IConsultantRepository
{
    IEnumerable<Consultant> ReadConsultants();

    Consultant? ReadConsultantById(int id);

    void CreateConsultant(Consultant entity);

    void UpdateConsultant(Consultant entity);

    void DeleteConsultant(int id);
}
