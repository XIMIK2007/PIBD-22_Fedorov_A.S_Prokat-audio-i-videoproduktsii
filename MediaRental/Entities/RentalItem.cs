using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class RentalItem
{
    protected RentalItem() { }

    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; private set; }

    public int RentalId { get; private set; }

    public int ProductId { get; private set; }

    [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "numeric(12,2)")]
    public decimal DailyPrice { get; private set; }

    public static RentalItem CreateEntity(int id, int rentalId, int productId, decimal dailyPrice)
    {
        return new RentalItem
        {
            Id = id,
            RentalId = rentalId,
            ProductId = productId,
            DailyPrice = dailyPrice,
        };
    }
}
