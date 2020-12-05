namespace RockContentChallenge.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
    {
        void Update(TEntity entity);
        void Dispose();
    }
}
