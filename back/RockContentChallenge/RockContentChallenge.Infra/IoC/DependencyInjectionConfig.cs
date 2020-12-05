using Microsoft.Extensions.DependencyInjection;
using RockContentChallenge.Aplication.Interfaces;
using RockContentChallenge.Aplication.Services;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Interfaces.Services;
using RockContentChallenge.Domain.Services;
using RockContentChallenge.Infra.Repositories;

namespace RockContentChallenge.Infra.IoC
{
    public class DependencyInjectionConfig
    {
        private readonly IServiceCollection _services;

        public DependencyInjectionConfig(IServiceCollection services)
        {
            _services = services;
        }

        public void RegisterServices()
        {
            _services.AddScoped<IArticleAppService, ArticleAppService>();

            _services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            _services.AddScoped<IArticleService, ArticleService>();

            _services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            _services.AddScoped<IArticleRepository, ArticleRepository>();            
        }
    }
}
