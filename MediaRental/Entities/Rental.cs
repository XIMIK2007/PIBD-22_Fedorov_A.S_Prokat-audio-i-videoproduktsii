using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class Rental
{
    protected Rental() { }

    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; private set; }

    public int ClientId { get; private set; }

    public int ConsultantId { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "timestamp without time zone")]
    public DateTime RentalDate { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "timestamp without time zone")]
    public DateTime DueDate { get; private set; }

    public List<RentalItem> Items { get; private set; } = [];

    public static Rental CreateOperation(int id, int clientId, int consultantId, DateTime dueDate, IEnumerable<RentalItem>? items)
    {
        return new Rental
        {
            Id = id,
            ClientId = clientId,
            ConsultantId = consultantId,
            RentalDate = DateTime.Now,
            DueDate = dueDate,
            Items = items?.ToList() ?? [],
        };
    }
}
