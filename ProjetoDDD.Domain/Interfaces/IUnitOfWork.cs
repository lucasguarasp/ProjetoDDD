using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IUnitOfWork
    {
         Task CommitAsync ();

    }
}