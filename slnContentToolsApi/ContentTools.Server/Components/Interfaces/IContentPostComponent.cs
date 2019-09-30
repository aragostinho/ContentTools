using ContentTools.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server.Components.Interfaces
{
    public interface IContentPostComponent
    {
        ListResultResponseBody<ContentPost> ListPosts();
    }
}
