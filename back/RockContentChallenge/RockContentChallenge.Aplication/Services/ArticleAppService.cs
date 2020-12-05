using AutoMapper;
using RockContentChallenge.Aplication.Dtos;
using RockContentChallenge.Aplication.Interfaces;
using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Services;
using System;
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

        public async Task<ArticleDto> GetByIdAsync(Guid guid)
        {
            return Mapper.Map<Article, ArticleDto>(await _articleService.GetByIdAsync(guid));
        }

        public async Task UpdateAsync(ArticleDto articleDto)
        {
            var articleDb = await GetByIdAsync(new Guid(articleDto.Guid));
            articleDb.AmountLike += articleDto.AmountLike;
            
            _articleService.UpdateAsync(Mapper.Map<ArticleDto, Article>(articleDb));
        }        
    }
}
