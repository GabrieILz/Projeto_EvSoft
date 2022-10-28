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
            return CreatedAtAction(nameof(GetOne), new {Id = contato.ContatoId}, contato);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Contatos);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            Contato contato = _context.Contatos.Find(id);

            if(contato == null)
                return NotFound();

            ReadContatoDto contatoDto = _mapper.Map<ReadContatoDto>(contato);

            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateContatoDto contatoDto)
        {
            Contato? contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            _mapper.Map(contatoDto, contato);
            _context.Contatos.Update(contato);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Contato contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
