using Microsoft.EntityFrameworkCore;
using ProjetoDDD.Domain.Entidades;

namespace ProjetoDDD.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> x)
        :base(x)
        {
            
        }

        public DbSet <Aluno> Alunos { get; set; }
        public DbSet <Professor> Professor { get; set; }
        public DbSet <Materia> Materia { get; set; }       


    }
}