using System.Linq;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IRepositoryBase <T>
    {
       void Add(T t);

       T GetById(int Id);

        IQueryable<T> GetAll();

        void Update(T t);

        void Remove(T t);
         
    }
}