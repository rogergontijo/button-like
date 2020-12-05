using RockContentChallenge.Aplication.Interfaces;
using RockContentChallenge.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace RockContentChallenge.Aplication.Services
{
    public class ArticleAppService : IArticleAppService
    {
        private readonly IArticleService _articleService;

        public ArticleAppService(IArticleService articleService)
        {
            _articleService = articleService;
        }        

        public async Task UpdateAsync(object value)
        {
            //await _articleService.Update(value);
        }
    }
}
