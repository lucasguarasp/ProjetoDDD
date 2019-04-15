namespace ProjetoDDD.Domain.Entidades
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public virtual Materia Materia { get; set; }
        
    }
}