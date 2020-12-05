using AutoMapper;
using RockContentChallenge.Aplication.Dtos;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Aplication.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public override string ProfileName => "DtoToDomainMap";

        public DtoToDomainMappingProfile()
        {
            CreateMap<ArticleDto, Article>();           
        }
    }
}
