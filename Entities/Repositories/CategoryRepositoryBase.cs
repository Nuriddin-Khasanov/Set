namespace Domain.Repositories
{
    public class CategoryRepositoryBase
    {

        public bool Create(Category category)
        {
            _categories.Add(category);
            return true;
        }
    }
}