namespace Projeto_EvSoft.Dtos.PessoaDtos
{
    public class ReadPessoaDto
    {
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string complemento { get; set; }

        public string Bairro { get; set; }

        public string UF { get; set; }
    }
}
