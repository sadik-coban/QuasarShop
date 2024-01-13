using Microsoft.EntityFrameworkCore;
using QuasarShopData;
using QuasarShopServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder
    .Services
    .AddDbContext<AppDbContext>(config =>
    {
        var dbProvider = builder.Configuration.GetValue<string>("DbProvider");
        var cs = builder.Configuration.GetConnectionString(dbProvider!);
        switch (dbProvider)
        {
            case "PostgreSql":
                config.UseNpgsql(cs, p => p.MigrationsAssembly("MigrationsPostgreSql"));
                break;
            case "MySql":
                config.UseMySql(cs, ServerVersion.AutoDetect(cs), p => p.MigrationsAssembly("MigrationsMySql"));
                break;
            case "SqlServer":
            default:
                config.UseSqlServer(cs, p => p.MigrationsAssembly("MigrationsSqlServer"));
                break;
        }
    });


builder.Services.AddScoped<ICatalogsService, CatalogsService>();
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IFilesService, FileService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(config => config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
