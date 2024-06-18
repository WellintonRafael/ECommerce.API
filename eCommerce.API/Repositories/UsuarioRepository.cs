using eCommerce.API.Repositories.Interfaces;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected static List<Usuario> _db = new List<Usuario>();

        public async Task<Usuario?> Get(int id)
        {
            return _db.Find(usuario => usuario.Id == id);
        }

        public async Task Delete(int id)
        {
            Usuario? usuario = _db.Find(usuario => usuario.Id == id);

            if (usuario == null) return;

            _db.Remove(usuario);
        }

        async Task IRepository<Usuario>.Add(Usuario usuario)
        {
            _db.Add(usuario);
        }

        async Task<List<Usuario>> IRepository<Usuario>.GetAll()
        {
            return _db;
        }

        async Task IRepository<Usuario>.Update(Usuario usuario)
        {
            Usuario u = await Get(usuario.Id);

            _db.Remove(u);

            _db.Add(usuario);
        }
    }
}
