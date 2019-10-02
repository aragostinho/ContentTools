using ContentTools.Net;
using ContentTools.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = ConfigurationManager.AppSettings["ContentToolsAPIBaseEndpoint"];

            string token = ConfigurationManager.AppSettings["ContentToolsAPIToken"];

            string emailAccount = ConfigurationManager.AppSettings["ContentToolsAPIEmailAccount"];

            int projectId = int.Parse(ConfigurationManager.AppSettings["ContentToolsAPIProjectId"]);

            ContentToolClient client = new ContentToolClient(baseUrl, token, emailAccount, projectId);

            //client.Posts.AddFilter(true);
            //client.Posts.AddFilter(new Paginate(10, 0));            
            //client.Posts.AddFilter(DateTime.Now.AddDays(-10), null);
            client.Posts.AddFilter(ContentType.blogpost);
            client.Posts.AddFilter(Status.Published);

            var posts = client.Posts.Get();

        }
    }
}
