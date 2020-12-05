using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Infra.Context;

namespace RockContentChallenge.Infra.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(ContextDb contextDb)
            : base(contextDb)
        {
        }       
    }
}
