using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Net
{
    public static class ExtensionMethods
    {

        public static string ToBaseUrl(this string baseUrl, string token, string emailAccount ,int projectId)
        {
            return $"{baseUrl}/#endpoint#/?username={emailAccount}&api_key={token}&project__id__exact={projectId}";
        }

     

        public static string GetDescription(this Enum enumObj)
        {
            FieldInfo fieldInfo = enumObj.GetType().GetField(enumObj.ToString());
            if (fieldInfo == null)
                return string.Empty;

            object[] attribArray = fieldInfo.GetCustomAttributes(false);

            for (int i = 0; i < attribArray.Length; i++)
            {
                if (attribArray[i].ToString().Contains("Description"))
                    return ((DescriptionAttribute)attribArray[i]).Description;
            }
            return string.Empty;
        }
 


    }
}
