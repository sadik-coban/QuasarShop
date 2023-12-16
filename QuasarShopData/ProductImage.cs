using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuasarShopData.Infrastructure;

namespace QuasarShopData;

public class ProductImage : EntityBase
{

    public Guid ProductId { get; set; }
    public string Image { get; set; }

    public Product? Product { get; set; }

}

public class ProductImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        builder
            .Property(p => p.Image)
            .IsUnicode(false);
    }
}