using ContentTools.Net.Models;
using System;

namespace ContentTools.Net.Components.Interfaces
{
    public interface IPublicContent
    {
        Response Get();
        void AddFilter(ObjectContentType contentType);
        void AddFilter(Paginate paginate);
        void AddFilter(bool getDeletedContents = false);
        void AddFilter(Status status);
        void AddFilter(DateTime? dategt, DateTime? datelt);
        void AddFilter(int limit);
    }
}
