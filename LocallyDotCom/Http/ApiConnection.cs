using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace LocallyDotCom
{
    public class ApiConnection : IApiConnection
    {
        public ApiConnection(string apiKey) : 
            this(ApiUrls.Base, apiKey) { }

        public ApiConnection(Uri baseUri, string apiKey) : 
            this(baseUri, apiKey, "LocallyDotCom/1.0") { }

        public ApiConnection(Uri baseUri, string apiKey, string userAgent)
        {
            RestClient = new RestClient(baseUri)
            {
                Authenticator = new ApiKeyAuthenticator(apiKey),
                UserAgent = userAgent
            };
        }

        public IRestClient RestClient { get; private set; }

        public Task<T> Get<T>(Uri relativeUri) where T : new()
        {
            return Get<T>(relativeUri, null);
        }

        public Task<T> Get<T>(Uri relativeUri, IEnumerable<KeyValuePair<string, string>> requestParams) where T : new()
        {
            var request = new RestRequest(relativeUri, Method.GET);
            if (requestParams != null)
            {
                foreach (var param in requestParams)
                {
                    request.AddQueryParameter(param.Key, param.Value);
                }
            }

            return RestClient.GetTaskAsync<T>(request);
        }
    }
}