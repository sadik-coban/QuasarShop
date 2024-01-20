using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuasarShop.Models;
using System.Security.Claims;

namespace QuasarShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrators,ProductAdministrators")]
    public class CarouselImagesController : ControllerBase
    {
        private readonly ICarouselImageService carouselImageService;
        private readonly IFilesService filesService;

        public CarouselImagesController(
            ICarouselImageService carouselImageService,
            IFilesService filesService
            )
        {
            this.carouselImageService = carouselImageService;
            this.filesService = filesService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await carouselImageService.GetAll().ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View(new CarouselImageViewModel { Enabled = true });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarouselImageViewModel model)
        {
            if (model.ImageFile is null)
            {
                TempData["error"] = "Görsel dosyası yükleyiniz";
                return View(model);
            }

            await carouselImageService.CreateAsync(
                 await filesService.ResizeImageAsync(model.ImageFile.OpenReadStream(), 1440, 480),
                 model.DateFirst,
                 model.DateEnd,
                 UserId,
                 model.Enabled);

            return RedirectToAction(nameof(Index));
        }

    }
}
