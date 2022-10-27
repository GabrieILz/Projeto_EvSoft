using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto_EvSoft.Dtos.ContatoDtos;
using Projeto_EvSoft.Models;
using Projeto_EvSoft.Persistance;

namespace Projeto_EvSoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private ProjetoContext _context;
        private IMapper _mapper;

        public ContatoController(ProjetoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateContatoDto contatoDto)
        {
            Contato contato = _mapper.Map<Contato>(contatoDto);

            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Created("localhost:5271/Contato/" + contato.ContatoId, contato);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Contatos);
        }
    }
}
