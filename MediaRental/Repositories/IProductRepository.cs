using MediaRental.Entities;

namespace MediaRental.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> ReadProducts();

    Product? ReadProductById(int id);

    void CreateProduct(Product entity);

    void UpdateProduct(Product entity);

    void DeleteProduct(int id);
}
