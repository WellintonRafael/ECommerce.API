namespace eCommerce.API.Repositories.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        public Task<Usuario?> Get(int id);

        public Task Delete(int id);
    }
}
