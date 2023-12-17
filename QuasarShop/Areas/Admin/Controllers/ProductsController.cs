using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuasarShop.Models;
using QuasarShopData;
using QuasarShopServices;

namespace QuasarShop.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators,ProductAdministrators")]
public class ProductsController : ControllerBase
{
    private readonly IProductsService productsService;

    public ProductsController(
        IProductsService productsService
        )
    {
        this.productsService = productsService;
    }

    [Authorize(Roles = "Administrators,ProductAdministrators,OrderAdministrators")]
    public async Task<IActionResult> Index()
    {
        return View(await productsService.GetAll().ToListAsync());
    }
    public IActionResult Create()
    {
        return View(new ProductViewModel { Enabled = true });
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductViewModel model)
    {
        await productsService.Create(
            model.Name, 
            model.Enabled, 
            UserId, 
            decimal.Parse(model.Price), 
            int.Parse(model.DiscountRate ?? "0"),
            model.Description,
            null
            );
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Edit(Guid id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Product model)
    {
        return View();
    }
    public IActionResult Delete(Guid id)
    {
        return View();
    }

}
