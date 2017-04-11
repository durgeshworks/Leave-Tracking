using System.Net.Http;

namespace RestBusiness.RestHandlers
{
    public interface IRestClient 
    {
        HttpClient GetRestClient(IRequestParameters parameters);
    }
}
