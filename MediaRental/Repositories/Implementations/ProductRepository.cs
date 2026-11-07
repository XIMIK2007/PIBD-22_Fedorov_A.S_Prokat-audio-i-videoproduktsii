using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

// Заглушка первой лабораторной. Работа с БД будет добавлена во второй.
public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> ReadProducts() => [];

    public Product? ReadProductById(int id) => null;

    public void CreateProduct(Product entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void UpdateProduct(Product entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
    }

    public void DeleteProduct(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
    }
}
