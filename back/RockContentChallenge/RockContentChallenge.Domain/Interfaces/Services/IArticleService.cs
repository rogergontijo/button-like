using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Interfaces.Services
{
    public interface IArticleService
    {
        Task UpdateAmountLikeAsync(int value);
    }
}
