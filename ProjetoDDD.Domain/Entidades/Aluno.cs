namespace ProjetoDDD.Domain.Entidades
{
    public class Aluno : Pessoa
    {
        public string Ra { get; set; }

        public virtual Materia Materia { get; set; }
        
    }
}