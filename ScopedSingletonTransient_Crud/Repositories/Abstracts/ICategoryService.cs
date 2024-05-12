using ScopedSingletonTransient_Crud.Models.NorthwindData;

namespace ScopedSingletonTransient_Crud.Repositories.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
