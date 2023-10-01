namespace Core.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> Get(Guid Id);
    Task<List<TEntity>> GetAll();
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(Guid Id, TEntity entity);
    Task<TEntity> Delete(Guid Id);
}