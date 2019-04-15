using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoDDD.Domain.Entidades;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.WEB.ViewModels;

namespace ProjetoDDD.WEB.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public AlunoController(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;    
        }

        [HttpGet]
        public IActionResult AddAluno(){            

            return View();
        }

        [HttpPost]
        public IActionResult AddAluno(AlunoViewModels aluno){
            var alunoMapper = _mapper.Map<Aluno>(aluno);
            _alunoRepository.Add(alunoMapper);

            
            return View();
        }
        
    }
}