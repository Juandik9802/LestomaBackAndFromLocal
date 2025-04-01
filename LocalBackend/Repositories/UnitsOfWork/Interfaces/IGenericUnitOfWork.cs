using LocalShare.Responses;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces
{
    public interface IGenericUnitOfWork<T> where T : class
    {
        Task<ActionResponse<IEnumerable<T>>> GetAsync();
        Task<ActionResponse<T>> AddAsync(T model);
        Task<ActionResponse<T>> UpdateAsync(T model);
        Task<ActionResponse<T>> DeleteAsync(Guid id);
        Task<ActionResponse<T>> GetAsync(Guid id);
    }
}
