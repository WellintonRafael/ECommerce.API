namespace eCommerce.API.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<Usuario?> Get(int id);

        public Task Delete(int id);

        public Task<List<Usuario>> GetAll();

        public Task Add(Usuario usuario);

        public Task Update(Usuario usuario);
    }
}
