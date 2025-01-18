namespace LocalWeb.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(String url, T model);
        Task<HttpResponseWrapper<object>> DeleteAsync<T>(string url);
        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutAsync<T, TActionResponse>(String url, T model);
    }
}
