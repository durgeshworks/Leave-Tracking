using System.Threading.Tasks;

namespace RestBusiness.RestHandlers
{
    public interface IRestHelper
    {
        Task<TResult> Get<TResult>(string uri);

        Task<TResult> Put<TInput, TResult>(string uri, TInput args);

        Task<TResult> Post<TInput, TResult>(string uri, TInput args);

        Task<TResult> Delete<TInput, TResult>(string uri, TInput args);
        
    }
}
