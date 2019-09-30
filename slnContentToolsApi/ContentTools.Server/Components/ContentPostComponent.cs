using ContentTools.API;
using ContentTools.API.Models;
using ContentTools.Server.Components.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server.Components
{
    public class ContentPostComponent : BaseComponent, IContentPostComponent
    {
        public ContentPostComponent(ContentToolClient client)
            : base(client)
        {
            _baseRoute = "public_content";
        }
   

        /// <summary>
        /// List Tags
        /// </summary>
        /// <returns>Return a list of tags</returns>
        public ListResultResponseBody<ContentPost> ListPosts()
        {
            var request = base.BuildRequest(Method.GET);

            return _client.Execute<ListResultResponseBody<ContentPost>>(request);
        }
    }
}
