using System;
using Api.Domain.Dtos;
using Api.Domain.Dtos.City;
using Api.Domain.Dtos.CodeZip;
using Api.Domain.Dtos.Uf;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
            #endregion

            #region UF
            CreateMap<UfModel, UfDto>().ReverseMap();
            #endregion

            #region City
            CreateMap<CityModel, CityDto>().ReverseMap();
            CreateMap<CityModel, CityDtoCreate>().ReverseMap();
            CreateMap<CityModel, CityDtoUpdate>().ReverseMap();
            #endregion

            #region ZipCode
            CreateMap<CodeZipModel, CodeZipDto>().ReverseMap();
            CreateMap<CodeZipModel, CodeZipDtoCreate>().ReverseMap();
            CreateMap<CodeZipModel, CodeZipDtoUpdate>().ReverseMap();
            #endregion
        }
    }
}
