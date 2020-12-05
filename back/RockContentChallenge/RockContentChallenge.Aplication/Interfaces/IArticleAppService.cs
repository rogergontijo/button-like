using System.Threading.Tasks;

namespace RockContentChallenge.Aplication.Interfaces
{
    public interface IArticleAppService
    {
        Task UpdateAsync(object value);
    }
}
