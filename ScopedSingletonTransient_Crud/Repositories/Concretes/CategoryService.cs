using ScopedSingletonTransient_Crud.Models.NorthwindData;
using ScopedSingletonTransient_Crud.Repositories.Abstracts;

namespace ScopedSingletonTransient_Crud.Repositories.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly NorthwindContext _northwindContext;

        //private readonly IRepository<Category> _categoryRepository;

        //public CategoryService(IRepository<Category> categoryRepository)
        //{
        //    _categoryRepository = categoryRepository;
        //}
        //public void AddCategory(Category category)
        //{
        //    _categoryRepository.Add(category);
        //}

        //public void DeleteCategory(int id)
        //{
        //    _categoryRepository.Delete(id);
        //}

        //public IEnumerable<Category> GetAllCategories()
        //{
        //    return _categoryRepository.GetAll();
        //}

        //public Category GetCategoryById(int id)
        //{
        //    return _categoryRepository.GetById(id);
        //}

        //public void UpdateCategory(Category category)
        //{
        //    _categoryRepository.Update(category);
        //}
        public CategoryService(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public void CreateCategory(Category category)
        {
            _northwindContext.Categories.Add(category);
            _northwindContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            _northwindContext.Remove(id);
            _northwindContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _northwindContext.Categories.ToList();
        }

        public void UpdateCategory(Category categoryUpdated)
        {
            var updated = _northwindContext.Categories.Find(categoryUpdated.CategoryId);
            _northwindContext.Entry(updated).CurrentValues.SetValues(categoryUpdated);
            _northwindContext.SaveChanges();
        }
    }
}
