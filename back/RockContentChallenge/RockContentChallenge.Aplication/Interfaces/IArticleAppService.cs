using RockContentChallenge.Aplication.Dtos;
using System;
using System.Threading.Tasks;

namespace RockContentChallenge.Aplication.Interfaces
{
    public interface IArticleAppService
    {
        Task<ArticleDto> GetByIdAsync(Guid guid);
        Task UpdateAsync(ArticleDto value);       
    }
}
