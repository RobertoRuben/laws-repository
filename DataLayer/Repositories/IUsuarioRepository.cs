using EntitiesLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Login(string nombre, string contraseña);
        bool UpdateCredentials(int id, string nombreUsuario, string contraseña);
    }
}