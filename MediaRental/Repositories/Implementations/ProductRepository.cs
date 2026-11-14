using MediaRental.Entities;

namespace MediaRental.Repositories.Implementations;

using MediaRental.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

public class ProductRepository(Func<DataContext> createContext, ILogger logger)
    : DatabaseRepository(createContext, logger), IProductRepository
{
    public IEnumerable<Product> ReadProducts() =>
        Execute(nameof(ReadProducts), null, db => db.Products.AsNoTracking().OrderBy(x => x.Id).ToList());

    public Product? ReadProductById(int id) =>
        Execute(nameof(ReadProductById), id, db => db.Products.AsNoTracking().SingleOrDefault(x => x.Id == id));

    public void CreateProduct(Product entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(CreateProduct), new { entity.InventoryNumber, entity.DailyPrice }, db =>
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.Id;
        });
    }

    public void UpdateProduct(Product entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        Execute(nameof(UpdateProduct), entity.Id, db =>
        {
            db.Products.Update(entity);
            return db.SaveChanges();
        });
    }

    public void DeleteProduct(int id)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
        Execute(nameof(DeleteProduct), id, db =>
        {
            var entity = db.Products.Find(id);
            if (entity is null)
                return 0;

            db.Products.Remove(entity);
            return db.SaveChanges();
        });
    }
}
