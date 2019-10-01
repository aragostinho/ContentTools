using ContentTools.API.Filters;
using ContentTools.API.Models.Enums;
using ContentTools.Server.Models;
using System;

namespace ContentTools.Server.Components.Interfaces
{
    public interface IPublicContent
    {
        Response Get();
        void AddFilter(ContentType contentType);
        void AddFilter(Paginate paginate);
        void AddFilter(bool getDeletedContents = true);
        void AddFilter(Status status);
        void AddFilter(DateTime? dategt, DateTime? datelt);
    }
}
