using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        public IList<Usuario> GetUsuarios();
        public Usuario GetUsuarioById(int id);
        public void InsertUsuario(Usuario usuario);
        public void UpdateUsuario(int id, Usuario usuario);
        public void DeleteUsuario(int id);
    }
}
