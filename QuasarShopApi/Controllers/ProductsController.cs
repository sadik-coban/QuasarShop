using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuasarShopData;
using QuasarShopServices;

namespace QuasarShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService productsService;

        public ProductsController(
            IProductsService productsService
            )
        {
            this.productsService = productsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
#if DEBUG
            Thread.Sleep(5000);
#endif

            return Ok(await productsService
                .GetAll()
                .Include(p => p.User)
                .Include(p => p.Catalogs)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,
                    p.Price,
                    p.Image,
                    Catalogs = p.Catalogs.Select(q => new { q.Id, q.Name })
                })
                .OrderByDescending(p => p.Price)
                .Take(10)
                .ToListAsync()
                );
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await productsService
                .GetAll()
                .Include(p => p.User)
                .Include(p => p.Catalogs)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Description,
                    p.Price,
                    p.Image,
                    Catalogs = p.Catalogs.Select(q => new { q.Id, q.Name })
                })
                .SingleOrDefaultAsync(p => p.Id == id)
                );
        }

    }
}
