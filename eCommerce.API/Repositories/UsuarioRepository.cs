using eCommerce.API.Database;
using eCommerce.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;

        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return _db.Usuarios.OrderBy(user => user.Id).ToList();
        }

        public async Task<Usuario?> Get(int id)
        {
            return await _db.Usuarios.FindAsync(id);
        }

        public async Task Add(Usuario usuario)
        {
            await _db.AddAsync(usuario);
            await _db.SaveChangesAsync();
        }

        public async Task Update(Usuario usuario)
        {
            await _db.Usuarios.Where(user => user.Id == usuario.Id).ExecuteUpdateAsync(setters => setters
                .SetProperty(u => u.Nome, usuario.Nome)
                .SetProperty(u => u.Email, usuario.Email)
                .SetProperty(u => u.Sexo, usuario.Sexo)
                .SetProperty(u => u.RG, usuario.RG)
                .SetProperty(u => u.NomeMae, usuario.NomeMae)
                .SetProperty(u => u.SituacaoCadastro, usuario.SituacaoCadastro));
        }

        public async Task Delete(int id)
        {
            await _db.Usuarios.Where(user => user.Id == id).ExecuteDeleteAsync();
        }
    }
}
