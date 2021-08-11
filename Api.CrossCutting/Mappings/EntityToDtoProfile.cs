using System;
using Api.Domain.Dtos;
using Api.Domain.Dtos.City;
using Api.Domain.Dtos.CodeZip;
using Api.Domain.Dtos.Uf;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region User
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();
            #endregion

            #region UF
            CreateMap<UfDto, UfEntity>().ReverseMap();
            #endregion

            #region City
            CreateMap<CityDto, CityEntity>().ReverseMap();
            CreateMap<CityDtoComplete, CityEntity>().ReverseMap();
            CreateMap<CityDtoCreateResult, CityEntity>().ReverseMap();
            CreateMap<CityDtoUpdateResult, CityEntity>().ReverseMap();
            #endregion

            #region ZipCode
            CreateMap<CodeZipDto, CodeZipEntity>().ReverseMap();
            CreateMap<CodeZipDtoCreateResult, CodeZipEntity>().ReverseMap();
            CreateMap<CodeZipDtoUpdateResult, CodeZipEntity>().ReverseMap();
            #endregion

        }
    }
}
