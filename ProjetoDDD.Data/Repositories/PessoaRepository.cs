using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}