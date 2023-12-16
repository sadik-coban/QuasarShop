using Microsoft.EntityFrameworkCore;
using QuasarShopData;

namespace QuasarShopServices;

public interface ICatalogsService
{
    Task<List<Catalog>> GetAll();

    Task<Catalog?> GetById(Guid id);

    Task Create(Catalog catalog);
    Task Create(string Name, bool enabled, Guid userId);

    Task Update(Catalog catalog);

    Task Delete(Guid id);
}

public class CatalogsService : ICatalogsService
{
    private readonly AppDbContext context;

    public CatalogsService(
        AppDbContext context
        )
    {
        this.context = context;
    }

    public async Task Create(Catalog catalog)
    {
        catalog.DateCreated = DateTime.UtcNow;

        await context.Catalogs.AddAsync(catalog);
        await context.SaveChangesAsync();
    }

    public async Task Create(string name, bool enabled, Guid userId)
    {
        await Create(new Catalog { UserId = userId, Name = name, Enabled = enabled });
    }

    public async Task Delete(Guid id)
    {
        var item = await GetById(id);
        if (item is null)
            throw new Exception("Katalog bulunamadı");
        context.Catalogs.Remove(item);
        await context.SaveChangesAsync();
    }

    public Task<List<Catalog>> GetAll()
    {
        return context.Catalogs.ToListAsync();
    }

    public Task<Catalog?> GetById(Guid id)
    {
        return context.Catalogs.SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task Update(Catalog catalog)
    {
        context.Catalogs.Update(catalog);
        await context.SaveChangesAsync();
    }
}