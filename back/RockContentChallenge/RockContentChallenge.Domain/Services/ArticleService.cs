using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task UpdateAmountLikeAsync(int value)
        {
            await _articleRepository.UpdateAmountLikeAsync(value);
        }
    }
}
