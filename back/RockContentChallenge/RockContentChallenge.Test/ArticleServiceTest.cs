using Moq;
using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RockContentChallenge.Test
{
    public class ArticleServiceTest
    {
        private readonly Mock<IArticleRepository> _mockArticleRepository;

        public ArticleServiceTest()
        {
            _mockArticleRepository = new Mock<IArticleRepository>();
        }

        [Theory]
        [InlineData("D6283F6D-3465-4D37-8C01-8DC4B85AC95D")]
        public async Task GetByIdAsync_ReturnArticle(string id)
        {
            //Arrange
            var guid = new Guid(id);
            _mockArticleRepository.Setup(x => x.GetByIdAsync(guid)).ReturnsAsync(new Article() { AmountLike = 1, Guid = guid, Name = "Oportunidade Rock Content" });
            var _articleRepository = new ArticleService(_mockArticleRepository.Object);

            //Act
            var article = await _articleRepository.GetByIdAsync(guid);

            //Assert
            Assert.Equal(guid, article.Guid);
        }

        [Theory]
        [InlineData("D6283F6D-3465-4D37-8C01-8DC4B85AC95D", 1)]
        public async Task UpdateAsync_IncrementLike_ValidTest(string id, int amountLike)
        {
            //Arrange
            var guid = new Guid(id);
            _mockArticleRepository.Setup(x => x.GetByIdAsync(guid)).ReturnsAsync(new Article() { AmountLike = 1, Guid = guid, Name = "Oportunidade Rock Content" });
            
            var _articleRepository = new ArticleService(_mockArticleRepository.Object);

            //Act
            var article = await _articleRepository.GetByIdAsync(guid);
            article.AmountLike += amountLike;

            //Assert
            _articleRepository.UpdateAsync(article);
        }
    }
}
