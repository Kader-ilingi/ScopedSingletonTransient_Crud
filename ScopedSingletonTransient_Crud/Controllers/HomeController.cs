using Microsoft.AspNetCore.Mvc;
using ScopedSingletonTransient_Crud.Models;
using ScopedSingletonTransient_Crud.Repositories.Abstracts;
using System.Diagnostics;

namespace ScopedSingletonTransient_Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public HomeController(ICategoryService category)
        {
            _categoryService = category;
        }
        public IActionResult Index()
        {
            var categories=_categoryService.GetAllCategories();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
