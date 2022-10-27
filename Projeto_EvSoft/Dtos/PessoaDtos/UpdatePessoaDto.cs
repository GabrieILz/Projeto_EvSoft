using System.ComponentModel.DataAnnotations;

namespace Projeto_EvSoft.Dtos.PessoaDtos
{
    public class UpdatePessoaDto
    {
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(30, ErrorMessage = "O campo Nome deve ter no maximo 30 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de E-Mail é obrigatório.")]
        public string Email { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string complemento { get; set; }

        public string Bairro { get; set; }

        public string UF { get; set; }
    }
}
