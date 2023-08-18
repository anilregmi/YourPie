namespace YourPie.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly YourPieDbContext _yourPieDbContext;

        public CategoryRepository(YourPieDbContext yourPieDbContext)
        {
            _yourPieDbContext = yourPieDbContext;
        }

        public IEnumerable<Category> AllCategories => _yourPieDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
