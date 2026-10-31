using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class Consultant
{
    public int Id { get; private set; }

    public string FullName { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public static Consultant CreateEntity(int id, string? fullName, string? phone)
    {
        return new Consultant
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            Phone = phone ?? string.Empty,
        };
    }
}
