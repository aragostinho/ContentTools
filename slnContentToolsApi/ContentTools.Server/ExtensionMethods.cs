using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server
{
    public static class ExtensionMethods
    {

        public static string ToBaseUrl(this string baseUrl, string token, string emailAccount ,int projectId)
        {
            return $"{baseUrl}/#endpoint#/?username={emailAccount}&api_key={token}&project__id__exact={projectId}";
        }      

    }
}
