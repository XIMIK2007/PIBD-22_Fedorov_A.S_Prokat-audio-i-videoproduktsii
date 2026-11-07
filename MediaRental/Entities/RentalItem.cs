using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class RentalItem
{
    public int Id { get; private set; }

    public int RentalId { get; private set; }

    public int ProductId { get; private set; }

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
