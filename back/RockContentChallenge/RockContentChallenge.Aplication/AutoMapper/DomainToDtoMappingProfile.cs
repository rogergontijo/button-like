using AutoMapper;
using RockContentChallenge.Aplication.Dtos;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Aplication.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public override string ProfileName => "DomainToDtoMap";        

        public DomainToDtoMappingProfile()
        {
            CreateMap<Article, ArticleDto>();            
        }
    }
}
