using ExoApi.Contexts;
using ExoApi.Interface;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class UsuarioRepository :IUsuarioRepository
    {
        private readonly ProjetoContext _context;
        public UsuarioRepository(ProjetoContext context)
        {
            _context = context;
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuario.FirstOrDefault(usuario => usuario.Email == email && usuario.Senha == senha);
        }
    }
}
