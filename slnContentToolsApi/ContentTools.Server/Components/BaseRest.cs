using RestSharp;

namespace ContentTools.Server.Components
{
    public class BaseRest
    {
        protected ContentToolClient _client;
        protected string _baseRoute;

        public BaseRest(ContentToolClient client)
        {
            _client = client;
        }

        protected RestRequest BuildRequest(Method httpMethod = Method.GET)
        {
            var request = new RestRequest();
            request.Resource = _baseRoute;
            request.Method = httpMethod;

            return request;
        }
    }
}
