using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestBusiness.RestHandlers
{
    public class RestHelper : IRestHelper
    {
        private readonly IRequestParameters _requestParameters;
        private readonly HttpClient _client;


        public RestHelper(IRequestParameters requestParameters)
        {
            _requestParameters = requestParameters;

            _client = PrpeareClient();
        }

        private HttpClient PrpeareClient()
        {
            var restClient = new RestClient();

            return restClient.GetRestClient(_requestParameters);
        }

        #region IRestHelper Members

        public async Task<TResult> Get<TResult>(string uri)
        {
            var response = await _client.GetAsync(uri);

            return await HandleResponse<TResult>(response);
        }

        public async Task<TResult> Put<TInput, TResult>(string uri, TInput args)
        {
            var response = await _client.PutAsJsonAsync(uri, args);

            return await HandleResponse<TResult>(response);
        }

        public async Task<TResult> Post<TInput, TResult>(string uri, TInput args)
        {
            var response = await _client.PostAsJsonAsync(uri, args);

            return await HandleResponse<TResult>(response);
        }

        public async Task<TResult> Delete<TInput, TResult>(string uri, TInput args)
        {
            var response = await _client.DeleteAsync(uri);

            return await HandleResponse<TResult>(response);
        }

        #endregion

        private static Task<TResult> HandleResponse<TResult>(HttpResponseMessage response)
        {
            return response.Content.ReadAsAsync<TResult>();
        }

        //private static HttpContent GetHttpContent()
        //{
        //    return new 
        //}

    }
}
