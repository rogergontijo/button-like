using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Interfaces.Services;

namespace RockContentChallenge.Domain.Services
{
    public class ArticleService : BaseService<Article>, IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
            : base(articleRepository)
        {
            _articleRepository = articleRepository;
        }       
    }
}
