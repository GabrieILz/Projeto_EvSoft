using System.ComponentModel.DataAnnotations;

namespace Projeto_EvSoft.Dtos.ContatoDtos
{
    public class CreateContatoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        public string Celular { get; set; }
    }
}
