using ExoApi.Models;

namespace ExoApi.Interface
{
    public interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
    }
}
