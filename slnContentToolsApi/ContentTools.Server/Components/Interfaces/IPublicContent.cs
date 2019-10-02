using ContentTools.Server.Models;
using ContentTools.Server.Models.Enums;
using System;

namespace ContentTools.Server.Components.Interfaces
{
    public interface IPublicContent
    {
        Response Get();
        void AddFilter(ContentType contentType);
        void AddFilter(Paginate paginate);
        void AddFilter(bool getDeletedContents = false);
        void AddFilter(Status status);
        void AddFilter(DateTime? dategt, DateTime? datelt);
    }
}
