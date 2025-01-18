using LocalShare.Responses;

namespace LocalBackend.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ActionResponse<T>> GetAsync(Guid id);

        Task<ActionResponse<IEnumerable<T>>> GetAsync();

        Task<ActionResponse<T>> AddAsync(T item);

        Task<ActionResponse<T>> DeleteAsync(Guid id);

        Task<ActionResponse<T>> UpdateAsync(T entity);
    }
}