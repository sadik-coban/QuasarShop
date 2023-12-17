using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuasarShop.Models;
using QuasarShopServices;
using System.Globalization;

namespace QuasarShop.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators,ProductAdministrators")]
public class ProductsController : ControllerBase
{
    private readonly IProductsService productsService;
    private readonly string entityName = "Katalog";
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
            description: model.Description,
            price: decimal.Parse(model.Price, CultureInfo.CreateSpecificCulture("tr-TR")),
            discountRate: int.Parse(model.DiscountRate),
            image: model.Image
            );
        TempData["success"] = $"{entityName} ekleme işlemi başarıyla tamamlanmıştır!";
        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> Edit(Guid id)
    {
        var item = await productsService.GetById(id);
        if (item is null)
            return RedirectToAction(nameof(Index));
        return View(new ProductViewModel
        {
            Name = item.Name,
            Enabled = item.Enabled
        });
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Guid id, ProductViewModel model)
    {
        var item = await productsService.GetById(id);

        item.Name = model.Name;
        item.Enabled = model.Enabled;

        TempData["success"] = $"{entityName} güncelleme işlemi başarıyla tamamlanmıştır!";

        await productsService.Update(item);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        await productsService.Delete(id);
        TempData["success"] = $"{entityName} silme işlemi başarıyla tamamlanmıştır!";
        return RedirectToAction(nameof(Index));
    }

}
