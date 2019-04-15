using System.Threading.Tasks;
using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}