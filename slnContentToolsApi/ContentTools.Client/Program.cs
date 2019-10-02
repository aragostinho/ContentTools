
using ContentTools.Net.Client;
using ContentTools.Net.Models;
using System.Configuration;

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
            client.Posts.AddFilter(ObjectContentType.blogpost);
            client.Posts.AddFilter(Status.Published);

            var posts = client.Posts.Get();

        }
    }
}
