using Microsoft.Extensions.DependencyInjection;

namespace QuasarShopServices;

public static class AppExtensions
{
    public static IServiceCollection AddQuasarShop(this IServiceCollection services)
    {

        services
            .AddScoped<ICatalogsService, CatalogsService>();
        services
            .AddScoped<IProductsService, ProductsService>();
        services
            .AddScoped<IFilesService, FileService>();

        return services;
    }
}
