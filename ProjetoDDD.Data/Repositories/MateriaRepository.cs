using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class MateriaRepository : RepositoryBase<Materia>, IMateriaRepository
    {
        public MateriaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}