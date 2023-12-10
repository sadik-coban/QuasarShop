using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuasarShopData.Infrastructure;

namespace QuasarShopData;

public class UserAddress : EntityBase
{

    public string Name { get; set; }
    public string Text { get; set; }
    public override string EntityName => "Kullanıcı Adresi";

    public User? User { get; set; }

}

public class UserAddressEntityTypeConfiguration : IEntityTypeConfiguration<UserAddress>
{
    public void Configure(EntityTypeBuilder<UserAddress> builder)
    {

    }
}
