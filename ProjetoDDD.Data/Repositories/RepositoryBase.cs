using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Data.Context;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T t)
        {
            _context.Set<T>().Add(t);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable().AsNoTracking();
        }

        public T GetById(int Id)
        {
            return Id > 0 ? _context.Set<T>().Find(Id) : null;
        }

        public void Remove(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public void Update(T t)
        {
             _context.Set<T>().Update(t);
        }
    }
}