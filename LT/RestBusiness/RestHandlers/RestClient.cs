using System.Net.Http;

namespace RestBusiness.RestHandlers
{
    public class RestClient : IRestClient
    {
        public HttpClient GetRestClient(IRequestParameters parameters)
        {
            var client = new HttpClient
                       {
                           BaseAddress = parameters.BaseAddress
                       };
                        client.DefaultRequestHeaders.Accept.Clear();
            return client;
        }


    }
}
