using AutoMapper;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.WEB.ViewModels;

namespace ProjetoDDD.WEB.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap <Aluno,AlunoViewModels> ().ReverseMap() ;
        }
    }
}