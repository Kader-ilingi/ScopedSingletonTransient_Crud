using Microsoft.AspNetCore.Mvc;
using ScopedSingletonTransient_Crud.Models.NorthwindData;
using ScopedSingletonTransient_Crud.Repositories.Abstracts;

namespace ScopedSingletonTransient_Crud.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.CreateCategory(category);
            return RedirectToAction("Index");
        }
    }
}
