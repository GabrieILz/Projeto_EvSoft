using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_EvSoft.Models
{
    public class Contato
    {
        [Column("Id")]
        public int ContatoId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        public string Celular { get; set; }
    }
}
