using System.Linq;
using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class AlunoRepository : RepositoryBase<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Aluno GetByRa(string Ra)
        {
            return _context.Alunos.FirstOrDefault(c => c.Ra == Ra);
        }
    }
}