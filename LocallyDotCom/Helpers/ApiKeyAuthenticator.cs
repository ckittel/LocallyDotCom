using RestSharp;

namespace LocallyDotCom
{
    internal class ApiKeyAuthenticator : IAuthenticator
    {
        private readonly string _apiKey;

        public ApiKeyAuthenticator(string apiKey)
        {
            _apiKey = apiKey;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddQueryParameter("key", _apiKey);
        }
    }
}