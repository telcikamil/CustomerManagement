namespace customerManagement.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Add(T entity);
        T GetById(Guid id);
        bool Update(T entity);
    }
}
