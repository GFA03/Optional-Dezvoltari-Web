using tema_lab4.Models.Base;

namespace tema_lab4.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();

        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entity);
        Task CreateRangeAsync(IEnumerable<TEntity> entity);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entity);


        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entity);

        TEntity FindById(Guid id);
        Task<TEntity> FindByAsync(Guid id);

        bool Save();
        Task<bool> SaveAsync();

    }
}
