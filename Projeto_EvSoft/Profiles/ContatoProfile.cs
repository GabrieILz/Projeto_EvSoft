using AutoMapper;
using Projeto_EvSoft.Dtos.ContatoDtos;
using Projeto_EvSoft.Models;

namespace Projeto_EvSoft.Profiles
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<CreateContatoDto, Contato>();
            CreateMap<Contato, ReadContatoDto>();
            CreateMap<UpdateContatoDto, Contato>();
        }
    }
}
