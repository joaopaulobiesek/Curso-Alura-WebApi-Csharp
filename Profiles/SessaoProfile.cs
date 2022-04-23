using AutoMapper;
using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;

namespace FilmeAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioDeInicio, opts => opts
                .MapFrom(dto => dto.HorarioDeEncerramento.AddMinutes(dto.Filme.Duracao * (-1)))); // Se mutiplicado por -1 diminui o Tempo
        }
    }
}
