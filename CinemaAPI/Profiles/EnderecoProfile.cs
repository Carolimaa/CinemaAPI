using AutoMapper;
using CinemaAPI.Data.Dtos;
using CinemaAPI.Models;

namespace CinemaAPI.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
        CreateMap<UpdateEnderecoDto, Endereco>();

    }
}
