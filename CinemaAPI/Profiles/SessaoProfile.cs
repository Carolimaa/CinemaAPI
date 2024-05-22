using AutoMapper;
using CinemaAPI.Data.Dtos;
using CinemaAPI.Models;

namespace CinemaAPI.Profiles;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>();
    }
}
