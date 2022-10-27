using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto_EvSoft.Dtos.PessoaDtos;
using Projeto_EvSoft.Models;
using Projeto_EvSoft.Persistance;

namespace Projeto_EvSoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private ProjetoContext _context;
        private IMapper _mapper;

        public PessoaController(ProjetoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePessoaDto pessoaDto)
        {

            Pessoa pessoa = _mapper.Map<Pessoa>(pessoaDto);

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOne), new { Id = pessoa.Id }, pessoa);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Pessoas);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            Pessoa pessoa = _context.Pessoas.Find(id);

            if (pessoa != null)
            {
                ReadPessoaDto pessoaDto = _mapper.Map<ReadPessoaDto>(pessoa);

                return Ok(pessoaDto);
            }
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePessoaDto pessoaDto)
        {
            Pessoa pessoa = _context.Pessoas.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            _mapper.Map(pessoaDto, pessoa);

            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Pessoa pessoa = _context.Pessoas.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
