using System.ComponentModel.DataAnnotations.Schema;

namespace QuasarShopData.Infrastructure;

public abstract class EntityBase
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public bool Enabled { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public User? User { get; set; }

    [NotMapped]
    public virtual string EntityName => "QuasarShop Entity";
}

