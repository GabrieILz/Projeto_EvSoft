using AutoMapper;
using Projeto_EvSoft.Dtos.PessoaDtos;
using Projeto_EvSoft.Models;

namespace Projeto_EvSoft.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<CreatePessoaDto, Pessoa>();
            CreateMap<Pessoa, ReadPessoaDto>();
            CreateMap<UpdatePessoaDto, Pessoa>();

        }
    }
}
