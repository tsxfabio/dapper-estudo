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
            },

            new Usuario()
            {
                Id = 5,
                Nome = "Mariana Campos",
                Email = "mariana.campos@gmail.com"
            },

            new Usuario()
            {
                Id = 6,
                Nome = "Thatiana Sant'Anna",
                Email = "thatiana.santanna@gmail.com"
            }
        };

        public IList<Usuario> GetUsuarios()
        {
            return _db;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _db.FirstOrDefault(a => a.Id == id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _db.Add(usuario);
        }

        public void UpdateUsuario(int id, Usuario usuario)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == usuario.Id));
            _db.Add(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == id));
        }
    }
}
