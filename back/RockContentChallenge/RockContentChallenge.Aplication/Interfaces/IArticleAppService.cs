using System.Threading.Tasks;

namespace RockContentChallenge.Aplication.Interfaces
{
    public interface IArticleAppService
    {
        Task UpdateAmountLikeAsync(int value);
    }
}
