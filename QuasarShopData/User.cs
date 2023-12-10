using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuasarShopData;

namespace QuasarShopData;

public class User : IdentityUser<Guid>
{
    public string Name { get; set; }

}
public class Manager : User
{
    public ICollection<Catalog> Catalogs { get; set; } = new HashSet<Catalog>();
    public ICollection<CarouselImage> CarouselImages { get; set; } = new HashSet<CarouselImage>();
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    public ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
    public ICollection<UserAddress> DeliveryAddresses { get; set; } = new HashSet<UserAddress>();
    public ICollection<UserAddress> BillingAddresses { get; set; } = new HashSet<UserAddress>();
}

public class ManagerEntityTypeConfiguration : IEntityTypeConfiguration<Manager>
{
    public void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder
            .HasMany(p => p.CarouselImages)
            .WithOne(p => (Manager)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        builder
            .HasMany(p => p.Catalogs)
            .WithOne(p => (Manager)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(p => p.Products)
            .WithOne(p => (Manager)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        builder
            .HasMany(p => p.ProductImages)
            .WithOne(p => (Manager)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}

public class Customer : User
{
    public ICollection<UserAddress> Addresses { get; set; } = new HashSet<UserAddress>();
    public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = new HashSet<ShoppingCartItem>();

}

public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .HasMany(p => p.Addresses)
            .WithOne(p => (Customer)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(p => p.Comments)
            .WithOne(p => (Customer)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(p => p.Orders)
            .WithOne(p => (Customer)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(p => p.ShoppingCartItems)
            .WithOne(p => (Customer)p.User!)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);


    }
}