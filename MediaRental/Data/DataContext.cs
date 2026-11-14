using MediaRental.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MediaRental.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Consultant> Consultants => Set<Consultant>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Rental> Rentals => Set<Rental>();
    public DbSet<RentalItem> RentalItems => Set<RentalItem>();
    public DbSet<RentalReturn> RentalReturns => Set<RentalReturn>();

    internal static IConfigurationRoot ReadConfiguration() => new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .AddJsonFile("appsettings.local.json", optional: true)
        .Build();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string connection = Environment.GetEnvironmentVariable("MEDIARENTAL_CONNECTION")
            ?? ReadConfiguration().GetConnectionString("MediaRental")
            ?? throw new InvalidOperationException("Не задано подключение к базе проката.");
        options.UseNpgsql(connection);
    }

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Product>().HasIndex(x => x.InventoryNumber).IsUnique();

        model.Entity<Rental>()
            .HasOne<Client>().WithMany().HasForeignKey(x => x.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
        model.Entity<Rental>()
            .HasOne<Consultant>().WithMany().HasForeignKey(x => x.ConsultantId)
            .OnDelete(DeleteBehavior.Restrict);
        model.Entity<Rental>()
            .HasMany(x => x.Items).WithOne().HasForeignKey(x => x.RentalId)
            .OnDelete(DeleteBehavior.Cascade);

        model.Entity<RentalItem>()
            .HasOne<Product>().WithMany().HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
        model.Entity<RentalItem>().HasIndex(x => new { x.RentalId, x.ProductId }).IsUnique();

        model.Entity<RentalReturn>()
            .HasOne<Rental>().WithOne().HasForeignKey<RentalReturn>(x => x.RentalId)
            .OnDelete(DeleteBehavior.Restrict);
        model.Entity<RentalReturn>()
            .HasOne<Consultant>().WithMany().HasForeignKey(x => x.ConsultantId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
