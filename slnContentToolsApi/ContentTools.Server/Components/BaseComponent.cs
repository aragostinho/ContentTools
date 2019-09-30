using ContentTools.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server.Components
{
    public class BaseComponent
    {
        protected ContentToolClient _client;
        protected string _baseRoute;

        public BaseComponent(ContentToolClient client)
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
