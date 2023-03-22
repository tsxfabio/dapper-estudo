using eCommerce.API.Models;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static List<Usuario> _db = new List<Usuario>()
        {
            new Usuario()
            {
                Id = 1,
                Nome = "Helena Nascimento",
                Email = "helena.nascimento@gmail.com"
            },

            new Usuario()
            {
                Id = 2,
                Nome = "Taíssa Santos",
                Email = "taissa.santos@gmail.com"
            },

            new Usuario()
            {
                Id = 3,
                Nome = "Caroline Neves",
                Email = "caroline.neves@gmail.com"
            },

            new Usuario()
            {
                Id = 4,
                Nome = "Marina Neves",
                Email = "marina.neves@gmail.com"
            }
        };

        public void DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public void InsertUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
