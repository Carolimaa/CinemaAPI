﻿using AutoMapper;
using CinemaAPI.Data.Dtos;
using CinemaAPI.Models;


namespace CinemaAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>()
            .ForMember(FilmeDto => FilmeDto.Sessoes,
                opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
