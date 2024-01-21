using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QuasarShop.Components
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly ICatalogsService catalogsService;

        public NavBarViewComponent(
            ICatalogsService catalogsService
            )
        {
            this.catalogsService = catalogsService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await catalogsService.GetAll().Where(p => p.Enabled).ToListAsync());
        }
    }
}
