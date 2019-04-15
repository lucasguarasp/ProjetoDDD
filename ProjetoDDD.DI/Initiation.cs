using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoDDD.Data.Context;
using ProjetoDDD.Data.Repositories;
using ProjetoDDD.Domain.Interfaces;

namespace ProjetoDDD.DI
{
    public class Initiation
    {
        public static void ConfigureServices(IServiceCollection services, string connection){
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer (connection));

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IAlunoRepository), typeof(AlunoRepository));
            services.AddScoped(typeof(IProfessorRepository), typeof(ProfessorRepository));
            services.AddScoped(typeof(IMateriaRepository), typeof(MateriaRepository));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }



    }
}