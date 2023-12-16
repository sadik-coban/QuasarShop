using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuasarShop.Models;
using QuasarShopData;
using QuasarShopServices;
using System.Security.Claims;

namespace QuasarShop.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators,ProductAdministrators")]
public class CatalogsController : ControllerBase
{
    private readonly ICatalogsService catalogsService;

    public CatalogsController(
        ICatalogsService catalogsService
        )
    {
        this.catalogsService = catalogsService;
    }

    [Authorize(Roles = "Administrators,ProductAdministrators,OrderAdministrators")]
    public async Task<IActionResult> Index()
    {
        return View(await catalogsService.GetAll());
    }
    public IActionResult Create()
    {
        return View(new CatalogViewModel { Enabled = true });
    }

    [HttpPost]
    public async Task<IActionResult> Create(CatalogViewModel model)
    {
        await catalogsService.Create(model.Name, model.Enabled, UserId);
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Edit(Guid id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Catalog model)
    {
        return View();
    }
    public IActionResult Delete(Guid id)
    {
        return View();
    }

}
