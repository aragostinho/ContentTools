using ContentTools.API;
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
            var posts = client.Posts.ListPosts();

        }
    }
}
