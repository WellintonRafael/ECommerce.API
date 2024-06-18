namespace eCommerce.API.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task Add(T obj);

        Task Update(T obj);
    }
}