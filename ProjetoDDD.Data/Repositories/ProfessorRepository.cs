using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class ProfessorRepository : RepositoryBase<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}