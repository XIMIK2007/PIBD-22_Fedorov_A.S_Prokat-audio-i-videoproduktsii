using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class Client
{
    protected Client() { }

    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; private set; }

    [System.ComponentModel.DataAnnotations.Required]
    public string FullName { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public bool IsRegular { get; private set; }

    public static Client CreateEntity(int id, string? fullName, string? phone, string? email, bool isRegular)
    {
        return new Client
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            Phone = phone ?? string.Empty,
            Email = email ?? string.Empty,
            IsRegular = isRegular,
        };
    }
}
