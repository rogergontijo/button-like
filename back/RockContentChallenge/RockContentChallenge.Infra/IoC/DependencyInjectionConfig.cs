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
        private IServiceCollection _services;

        public DependencyInjectionConfig(IServiceCollection services)
        {
            _services = services;
        }

        public void RegisterServices()
        {
            _services.AddScoped<IArticleAppService, ArticleAppService>();

            _services.AddScoped<IArticleService, ArticleService>();

            _services.AddScoped<IArticleRepository, ArticleRepository>();
        }
    }
}
