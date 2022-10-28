using System.ComponentModel.DataAnnotations;

namespace Projeto_EvSoft.Dtos.ContatoDtos
{
    public class ReadContatoDto
    {
        
        public int ContatoId { get; set; }

        public string Nome { get; set; }

        public string Celular { get; set; }
    }
}
