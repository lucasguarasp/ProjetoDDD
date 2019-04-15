using ProjetoDDD.Domain.Entidades;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IAlunoRepository : IRepositoryBase<Aluno>
    {
         Aluno GetByRa(string Ra);
    }
}