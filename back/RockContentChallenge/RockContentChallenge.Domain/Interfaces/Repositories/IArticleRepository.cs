using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Interfaces.Repositories
{
    public interface IArticleRepository
    {
        Task UpdateAmountLikeAsync(int value);
    }
}
