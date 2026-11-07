using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class RentalReturn
{
    public int Id { get; private set; }

    public int RentalId { get; private set; }

    public int ConsultantId { get; private set; }

    public DateTime ReturnDate { get; private set; }

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
