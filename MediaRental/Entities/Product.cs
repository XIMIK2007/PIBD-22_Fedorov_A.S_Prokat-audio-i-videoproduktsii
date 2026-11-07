using MediaRental.Entities.Enums;

namespace MediaRental.Entities;

public class Product
{
    public int Id { get; private set; }

    public string Title { get; private set; } = string.Empty;

    public string InventoryNumber { get; private set; } = string.Empty;

    public ProductType ProductType { get; private set; }

    public DiscFormat DiscFormat { get; private set; }

    public Genre Genres { get; private set; }

    public string Performers { get; private set; } = string.Empty;

    public string Actors { get; private set; } = string.Empty;

    public decimal DailyPrice { get; private set; }

    public static Product CreateEntity(int id, string? title, string? inventoryNumber, ProductType productType, DiscFormat discFormat, Genre genres, string? performers, string? actors, decimal dailyPrice)
    {
        return new Product
        {
            Id = id,
            Title = title ?? string.Empty,
            InventoryNumber = inventoryNumber ?? string.Empty,
            ProductType = productType,
            DiscFormat = discFormat,
            Genres = genres,
            Performers = performers ?? string.Empty,
            Actors = actors ?? string.Empty,
            DailyPrice = dailyPrice,
        };
    }
}
