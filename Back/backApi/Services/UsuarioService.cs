

using backApi.Models;
using Microsoft.EntityFrameworkCore;

namespace backApi.Services
{
    public class UsuarioService
    {
        public List<UsuarioModel> ListarUsuarios()
        {
            DataContext db = new DataContext();
            return db.Usuarios.ToList();
        }
        public void CriarUsuario(UsuarioModel usuario)
        {
            DataContext db = new DataContext();
            db.Add(usuario);
            db.SaveChanges();
        }

        public void AtualizarUsuario(UsuarioModel usuario)
        {
            DataContext db = new DataContext();
            db.Update(usuario);
            db.SaveChanges();
        }

        public void DeletarUsuario(int usuarioId)
        {
            DataContext db = new DataContext();
            UsuarioModel usuario = db.Usuarios.Where(x => x.Id == usuarioId).First();
            db.Remove(usuario);
            db.SaveChanges();
        }

        public bool AutenticarUsuario(string emailLogin , string senha)
        {
            DataContext db = new DataContext();
            UsuarioModel usuario = db.Usuarios.Where(x => x.Email == emailLogin && x.Senha == senha).FirstOrDefault();
            if (usuario == null)
                return false;

            return true;

        }

            

    }
}
