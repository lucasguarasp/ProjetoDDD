using ProjetoDDD.Domain.Entidades;

namespace ProjetoDDD.WEB.ViewModels
{
    public class AlunoViewModels
    {        
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public string Ra { get; set; }
                
    }
}