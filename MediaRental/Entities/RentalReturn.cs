using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class RentalReturn
{
    protected RentalReturn() { }

    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; private set; }

    public int RentalId { get; private set; }

    public int ConsultantId { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "timestamp without time zone")]
    public DateTime ReturnDate { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric(12,2)")]
    public decimal PaidAmount { get; private set; }

    public static RentalReturn CreateOperation(int id, int rentalId, int consultantId, decimal paidAmount)
    {
        return new RentalReturn
        {
            Id = id,
            RentalId = rentalId,
            ConsultantId = consultantId,
            ReturnDate = DateTime.Now,
            PaidAmount = paidAmount,
        };
    }
}
