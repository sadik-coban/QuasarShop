using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuasarShop.Models;

namespace QuasarShop.Controllers;

public class HomeController : Controller
{
    private readonly ICarouselImageService carouselImageService;
    private readonly IProductsService productsService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(
        ICarouselImageService carouselImageService,
        IProductsService productsService,
        ILogger<HomeController> logger)
    {
        this.carouselImageService = carouselImageService;
        this.productsService = productsService;
        _logger = logger;

    }

    public async Task<IActionResult> Index()
    {
        ViewBag.CarouselImages = await carouselImageService.GetAll().Where(p => p.Enabled && (DateTime.UtcNow > p.DateFirst || p.DateFirst == null) && (DateTime.UtcNow < p.DateEnd || p.DateEnd == null)).ToListAsync();
        ViewBag.BestSellers = await productsService.GetBestSellersAsync(12);
        return View();
    }

    public async Task<IActionResult> Catalog(Guid id)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
