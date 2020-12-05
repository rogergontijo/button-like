using AutoMapper;

namespace RockContentChallenge.Aplication.AutoMapper
{
    public static class AutoMapperConfig
    {   
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToDtoMappingProfile>();
                cfg.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
