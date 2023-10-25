using backApi.Services;

namespace backApi.Models
{
    public class UsuarioModel : UsuarioService
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
       
        public UsuarioModel()
        {
        }
    }
}
